using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3SSTEst1
{
    public partial class VisualizarPersonas : Form
    {
        public VisualizarPersonas()
        {
            InitializeComponent();
        }

        private void VisualizarPersonas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't3SJTest1DataSet.Persona' table. You can move, or remove it, as needed.
            this.personaTableAdapter.Fill(this.t3SJTest1DataSet.Persona);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.personaBindingSource.EndEdit();
                this.personaTableAdapter.Update(this.t3SJTest1DataSet.Persona);
                MessageBox.Show("Update successful!", "Informacion Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed\n" + ex.Message, "The Rockin' Sandwich Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VisualizarPersonas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
