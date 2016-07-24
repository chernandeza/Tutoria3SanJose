using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibreriaT3SJ;

namespace T3SSTEst1
{
    public partial class CapturaPersonas : Form
    {
        private ListaPersonas lista1;
        private Persona p1;
        private ConectorBD cnBD;

        public CapturaPersonas()
        {
            InitializeComponent();
            lista1 = new ListaPersonas();
            p1 = new Persona();
            cnBD = new ConectorBD();
        }

        private void btnGuardarPersona_Click(object sender, EventArgs e)
        {
            p1 = new Persona();
            p1.Cedula = txtCedula.Text;
            p1.Nombre = txtNombre.Text;
            p1.Apellido1 = txtApellido1.Text;
            p1.Apellido2 = txtApellido2.Text;
            p1.Provincia1 = (Provincia)Enum.Parse(typeof(Provincia), cmbProvincia.SelectedValue.ToString());
            p1.Genero = (Genero)Enum.Parse(typeof(Genero), cmbGenero.SelectedValue.ToString());
            lista1.AgregarPersonaALista(p1);
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtCedula.Text = "";
            cmbGenero.SelectedIndex = 2;
            cmbProvincia.SelectedIndex = 0;
            List<Persona> bindList = new List<Persona>();
            /*Obtiene los valores del diccionario de personas y
            los agrega a una lista generica. Esto porque el datagridview
            solamente puede hacer binding con una lista*/
            foreach (Persona item in lista1.ListaP.Values)
            {
                bindList.Add(item);
            }
            dgvListaPersonas.DataSource = null;
            dgvListaPersonas.DataSource = bindList;
            dgvListaPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            btnAlmacenarEnBD.Enabled = true;
        }

        private void CapturaPersonas_Load(object sender, EventArgs e)
        {
            cmbGenero.DataSource = Enum.GetNames(typeof(Genero));
            cmbGenero.SelectedIndex = 2;
            cmbProvincia.DataSource = Enum.GetNames(typeof(Provincia));
            cmbProvincia.SelectedIndex = 0;
            btnAlmacenarEnBD.Enabled = false;
        }

        private void btnAlmacenarEnBD_Click(object sender, EventArgs e)
        {
            try
            {
                cnBD.GuardarListaenBD(lista1);
                lista1 = new ListaPersonas();
                dgvListaPersonas.DataSource = null;
                MessageBox.Show("Almacenamiento Exitoso", "Informacion Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            VisualizarPersonas vp = new VisualizarPersonas();
            this.Enabled = false;
            
            if (vp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.Enabled = true;
            else
                this.Enabled = false;
        }

        private void btnVerPersona_Click(object sender, EventArgs e)
        {
            CargarInfoPersona ci = new CargarInfoPersona();
            this.Enabled = false;

            if (ci.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.Enabled = true;
            else
                this.Enabled = false;
        }
    }
}
