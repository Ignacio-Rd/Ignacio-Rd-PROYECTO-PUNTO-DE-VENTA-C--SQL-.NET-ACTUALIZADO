using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Negocio_;


namespace TPFinalNivel2_RuizDiaz
{
    public partial class Configurar_Impresora : Form
    {
        public Configurar_Impresora()
        {
            InitializeComponent();
        }

        private void Configurar_Impresora_Load(object sender, EventArgs e)
        {
            // 1. Cargamos el ComboBox con las impresoras instaladas en Windows
            // Esto incluye las USB, PDF y las Wi-Fi ya vinculadas.
            foreach (string impresora in PrinterSettings.InstalledPrinters)
            {
                cboImpresoras.Items.Add(impresora);
            }

            // 2. Opcional: Mostrar cuál es la que está guardada actualmente
             ImpresionNeogcio negocio = new ImpresionNeogcio();
            cboImpresoras.Text = negocio.ObtenerImpresora();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboImpresoras.SelectedItem != null)
            {
                string seleccionada = cboImpresoras.SelectedItem.ToString();

                ImpresionNeogcio negocio = new ImpresionNeogcio();
                try
                {
                    negocio.GuardarImpresora(seleccionada);
                    MessageBox.Show("¡Configuración guardada! Ahora los tickets se imprimirán en: " + seleccionada);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una impresora de la lista.");
            }
        }
    }
}
 
