using System;
using System.Windows.Forms;
using LibreriaT3SJ;

namespace T3SSTEst1
{
    public partial class CargarInfoPersona : Form
    {
        private ConectorBD bdCN;

        public CargarInfoPersona()
        {
            InitializeComponent();
            //bdCN = new ConectorBD();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            bdCN = new ConectorBD();
            Persona P1 = new Persona();
            P1 = bdCN.CargarInformacionPersona(txtConsultaCedula.Text);
            if (P1.Cedula != "0")
            {
                txtCedula.Text = P1.Cedula;
                txtNombre.Text = P1.Nombre;
                txtApellido1.Text = P1.Apellido1;
                txtApellido2.Text = P1.Apellido2;
                txtProvincia.Text = P1.Provincia1.ToString();
                txtGenero.Text = P1.Genero.ToString();
            }
            else
            {
                MessageBox.Show("No se encuentra informacion de esa persona.", "Info Personas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtConsultaCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //Tecla Enter presionada
            {
                btnConsultar_Click(sender, e);
            }
        }

        private void txtConsultaCedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CargarInfoPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
