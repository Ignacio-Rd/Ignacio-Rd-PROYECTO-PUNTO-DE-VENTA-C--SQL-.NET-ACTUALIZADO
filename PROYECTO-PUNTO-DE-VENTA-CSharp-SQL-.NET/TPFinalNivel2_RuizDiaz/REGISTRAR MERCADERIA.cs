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
    public partial class PAGAR_A_PROVEEDOR : Form
    {
        public PAGAR_A_PROVEEDOR()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbxProveedores.DataSource != null)


            {

                int idProv = Convert.ToInt32(cbxProveedores.SelectedValue);
                ENTRADA_DE_MERCADERIA formulario = new ENTRADA_DE_MERCADERIA(cbxProveedores.Text, idProv);

                formulario.Show();
            }
            else
            {
                MessageBox.Show("No hay métodos de pago cargados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            CargarProveedor formulario = new CargarProveedor();

            formulario.ShowDialog();

            cargar();
        }

        private void cargar()
        {
            ProveedorNegocio negocio = new ProveedorNegocio();
            var lista = negocio.listar();

            cbxProveedores.DataSource = lista;

            // Lo que el usuario ve:
            cbxProveedores.DisplayMember = "Nombre";

            // Lo que el sistema usa por detrás (el ID):
            cbxProveedores.ValueMember = "Id";
        }

        private void PAGAR_A_PROVEEDOR_Load(object sender, EventArgs e)
        {
            cargar();

        }
    }
}
