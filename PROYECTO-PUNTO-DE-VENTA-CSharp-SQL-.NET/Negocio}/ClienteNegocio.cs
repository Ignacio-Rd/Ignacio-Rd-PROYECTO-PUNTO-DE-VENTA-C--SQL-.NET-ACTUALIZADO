using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocios;
using Negocio_;

namespace Negocio_
{
    public class ClienteNegocio
    {

        // Método para listar TODOS los clientes (útil para una grilla de administración)
        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDATOS datos = new AccesoDATOS();

            try
            {
                // Usamos los nombres exactos de tu tabla (Captura 281)
                datos.SetearConsulta("SELECT Id, Nombre, NumeroID, Estado FROM Clientes ORDER BY Nombre ASC");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];

                    // Manejo de nulos para NumeroID ya que en DB permite NULL
                    if (!(datos.Lector["NumeroID"] is DBNull))
                        aux.NumeroID = (string)datos.Lector["NumeroID"];

                    aux.Estado = (bool)datos.Lector["Estado"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        // Método para listar solo Clientes Activos (útil para el ComboBox de Ventas)
        public List<Cliente> listarActivos()
        {
            // Podemos reutilizar el método listar y filtrar con LINQ para ahorrar código
            return listar().FindAll(x => x.Estado == true);
        }

        public decimal ObtenerDeudaActual(int idCliente)
        {
            AccesoDATOS datos = new AccesoDATOS();
            try
            {
                // La magia está aquí: Suma de Ventas Fiadas (11) MENOS Suma de Pagos
                datos.SetearConsulta(@"
            SELECT 
                (SELECT ISNULL(SUM(Total), 0) FROM VENTAS WHERE IdCliente = @id AND id_metodo = 11) - 
                (SELECT ISNULL(SUM(Monto), 0) FROM PAGOS_DEUDORES WHERE IdCliente = @id) 
            AS SaldoReal");

                datos.setearParametro("@id", idCliente);
                object resultado = datos.EjecutarScalar();

                return resultado != null && resultado != DBNull.Value ? Convert.ToDecimal(resultado) : 0;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.CerrarConexion(); }
        }

        public List<MovimientoCuenta> ListarHistorialMantenimiento(int idCliente)
        {
            List<MovimientoCuenta> lista = new List<MovimientoCuenta>();
            AccesoDATOS datos = new AccesoDATOS();

            try
            {
                // La consulta une Ventas y Pagos, ordenando todo por fecha
                datos.SetearConsulta(@"
    SELECT V.Fecha, V.Total AS Monto, 'FIÓ' AS Tipo 
    FROM VENTAS V
    INNER JOIN metodos_de_pago M ON V.id_metodo = M.id_metodo
    WHERE V.IdCliente = @idV AND M.metodo_pago = 'FIADO'
    
    UNION ALL
    
    SELECT Fecha, Monto, 'PAGÓ' AS Tipo 
    FROM PAGOS_DEUDORES 
    WHERE IdCliente = @idP
    
    ORDER BY Fecha DESC");

                datos.setearParametro("@idV", idCliente);
                datos.setearParametro("@idP", idCliente);

                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    MovimientoCuenta aux = new MovimientoCuenta();
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Monto = (decimal)datos.Lector["Monto"];
                    aux.Tipo = (string)datos.Lector["Tipo"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void RegistrarPago(int idCliente, decimal monto, int idMetodoPago)
        {
            AccesoDATOS datos = new AccesoDATOS();
            try
            {
                // Añadimos IdMetodoPago a la consulta
                datos.SetearConsulta("INSERT INTO PAGOS_DEUDORES (IdCliente, Fecha, Monto, IdMetodoPago) " +
                                   "VALUES (@idCliente, @fecha, @monto, @idMetodo)");

                datos.setearParametro("@idCliente", idCliente);
                datos.setearParametro("@fecha", DateTime.Now);
                datos.setearParametro("@monto", monto);
                datos.setearParametro("@idMetodo", idMetodoPago); // Nuevo parámetro

                datos.EjecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally { datos.CerrarConexion(); }
        }

        public void AgregarNuevo(string nombre)
        {
            AccesoDATOS datos = new AccesoDATOS();
            try
            {
                // Insertamos el nombre, dejamos NumeroID como NULL y Estado como 1 (Activo)
                datos.SetearConsulta("INSERT INTO Clientes (Nombre, NumeroID, Estado) VALUES (@nombre, NULL, 1)");
                datos.setearParametro("@nombre", nombre);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public List<VentaDetalle> ListarHistorial(int idCliente)
        {
            List<VentaDetalle> lista = new List<VentaDetalle>();
            AccesoDATOS datos = new AccesoDATOS();

            try
            {
                // Traemos la fecha y el monto de las ventas fiadas
                datos.SetearConsulta("SELECT Fecha, Total FROM VENTAS WHERE IdCliente = @id AND id_metodo = 11 ORDER BY Fecha DESC");
                datos.setearParametro("@id", idCliente);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    VentaDetalle aux = new VentaDetalle();
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Total = (decimal)datos.Lector["Total"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void GuardarCompraFinal(int idProveedor, List<DetalleCompra> lista, decimal DineroAProveedor, decimal TotalCompra, string Metodo)
        {
            MetodoDePagoNegocio negociometodo = new MetodoDePagoNegocio();
            int idmetodo = negociometodo.IdDelMetodo(Metodo);
            AccesoDATOS datos = new AccesoDATOS();
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            


            try
            {



                // 2. Insertamos la Compra (Cabecera)
                // Usamos SCOPE_IDENTITY() para saber qué ID de compra se generó
                // ✅ AFTER - todo en el mismo objeto 'datos', sin EjecutarAccion
                datos.SetearConsulta("INSERT INTO COMPRAS (IdProveedor, Fecha, TotalCompra) VALUES (@idProv, GETDATE(), @total); SELECT SCOPE_IDENTITY();");
                datos.setearParametro("@idProv", idProveedor);
                datos.setearParametro("@total", TotalCompra);
                int idCompraGenerada = Convert.ToInt32(datos.EjecutarScalar());
                datos.CerrarConexion();

                

                // 3. Recorremos la lista para el Detalle y el Stock
                foreach (var item in lista)
                {
                    // A. Insertar en DETALLE_COMPRAS
                    datos.LimpiarParametros();
                    


                    datos.SetearConsulta("INSERT INTO DETALLE_COMPRAS (IdCompra, IdProducto, Cantidad, PrecioCostoUnitario) VALUES (@idC, @idP, @cant, @precio)");
                    datos.setearParametro("@idC", idCompraGenerada);
                    datos.setearParametro("@idP", item.IdProducto); // El código de barras o ID
                    datos.setearParametro("@cant", item.Cantidad);
                    datos.setearParametro("@precio", item.PrecioCosto);
                    datos.EjecutarAccion();
                    datos.CerrarConexion();
                    // B. ACTUALIZAR STOCK (Lo que antes hacías en el botón ahora se hace acá)
                    artNegocio.SumarSoloCantidadStock(item.Cantidad, item.IdProducto.ToString());
                }

                

                datos.LimpiarParametros();
                datos.SetearConsulta("INSERT INTO PAGOS_PROVEEDORES (IdProveedor, IdCompra, Monto, Fecha, IdMetodoPago) VALUES (@proveedor, @compra, @monto, GETDATE(), @idmetodo)");
                datos.setearParametro("@proveedor", idProveedor );
                datos.setearParametro("@compra", idCompraGenerada);
                datos.setearParametro("@monto", DineroAProveedor);
                datos.setearParametro("@idmetodo", idmetodo);
                datos.EjecutarAccion();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public int ObtenerIdCompra() {

            AccesoDATOS datos = new AccesoDATOS();
            int idCompraGenerada = Convert.ToInt32(datos.EjecutarScalar());
            return idCompraGenerada;
        }
    }
}

