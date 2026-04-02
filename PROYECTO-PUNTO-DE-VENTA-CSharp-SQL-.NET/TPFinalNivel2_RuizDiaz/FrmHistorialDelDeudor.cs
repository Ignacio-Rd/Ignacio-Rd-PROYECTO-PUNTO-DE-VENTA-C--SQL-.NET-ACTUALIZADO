using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Negocio_;
using Dominio;

namespace TPFinalNivel2_RuizDiaz
{
    public partial class FrmHistorialDelDeudor : Form
    {
        private Cliente cliente;

        public FrmHistorialDelDeudor(Cliente clienteRecibido)
        {
            InitializeComponent();
            this.cliente = clienteRecibido;
            this.Text = "Historial de " + cliente.Nombre;
        }

      

       

        /*private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            VerDetalleCompra formulario = new VerDetalleCompra();

            formulario.ShowDialog();
        }*/

        private void FrmHistorialDelDeudor_Load_1(object sender, EventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();
            // 'idDeudor' es el que recibiste al abrir el form
            dgvHistorial.DataSource = negocio.ListarHistorialMantenimiento(cliente.Id);
        }

            private void dgvHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {
                // 1. Verificamos que no estemos en la fila de encabezado
                if (e.RowIndex < 0) return;

                // 2. Obtenemos el objeto completo de la fila actual
                // Asegurate que el DataSource sea la lista de 'MovimientoCuenta'
                if (dgvHistorial.Rows[e.RowIndex].DataBoundItem is MovimientoCuenta mov)
                {
                    // 3. Si es una VENTA, pintamos el texto de ROJO (Debe)
                    if (mov.Tipo == "FIÓ")
                    {
                        dgvHistorial.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                        dgvHistorial.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Red; // Opcional: fondo al seleccionar
                    }
                    // 4. Si es un PAGO, pintamos el texto de VERDE (Haber/Pago)
                    else if (mov.Tipo == "PAGÓ")
                    {
                        dgvHistorial.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
                        dgvHistorial.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Green;
                    }
                }
            }
        }
    }

