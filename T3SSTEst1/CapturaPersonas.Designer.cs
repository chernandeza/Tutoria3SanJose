namespace T3SSTEst1
{
    partial class CapturaPersonas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGuardarPersona = new System.Windows.Forms.Button();
            this.btnAlmacenarEnBD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.dgvListaPersonas = new System.Windows.Forms.DataGridView();
            this.btnVerLista = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVerLista);
            this.panel1.Controls.Add(this.cmbGenero);
            this.panel1.Controls.Add(this.cmbProvincia);
            this.panel1.Controls.Add(this.txtApellido2);
            this.panel1.Controls.Add(this.txtApellido1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuardarPersona);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 296);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvListaPersonas);
            this.panel2.Controls.Add(this.btnAlmacenarEnBD);
            this.panel2.Location = new System.Drawing.Point(327, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 296);
            this.panel2.TabIndex = 1;
            // 
            // btnGuardarPersona
            // 
            this.btnGuardarPersona.Location = new System.Drawing.Point(3, 213);
            this.btnGuardarPersona.Name = "btnGuardarPersona";
            this.btnGuardarPersona.Size = new System.Drawing.Size(301, 37);
            this.btnGuardarPersona.TabIndex = 6;
            this.btnGuardarPersona.Text = "Guardar Persona en Lista";
            this.btnGuardarPersona.UseVisualStyleBackColor = true;
            this.btnGuardarPersona.Click += new System.EventHandler(this.btnGuardarPersona_Click);
            // 
            // btnAlmacenarEnBD
            // 
            this.btnAlmacenarEnBD.Location = new System.Drawing.Point(3, 256);
            this.btnAlmacenarEnBD.Name = "btnAlmacenarEnBD";
            this.btnAlmacenarEnBD.Size = new System.Drawing.Size(258, 37);
            this.btnAlmacenarEnBD.TabIndex = 8;
            this.btnAlmacenarEnBD.Text = "Almacenar Lista en BD";
            this.btnAlmacenarEnBD.UseVisualStyleBackColor = true;
            this.btnAlmacenarEnBD.Click += new System.EventHandler(this.btnAlmacenarEnBD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primer Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Segundo Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cedula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Provincia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Genero";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(162, 26);
            this.txtCedula.Mask = "00-0000-0000";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(142, 20);
            this.txtCedula.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(162, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(162, 82);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(142, 20);
            this.txtApellido1.TabIndex = 2;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(162, 110);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(142, 20);
            this.txtApellido2.TabIndex = 3;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(162, 138);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(142, 21);
            this.cmbProvincia.TabIndex = 4;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(162, 166);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(142, 21);
            this.cmbGenero.TabIndex = 5;
            // 
            // dgvListaPersonas
            // 
            this.dgvListaPersonas.AllowUserToAddRows = false;
            this.dgvListaPersonas.AllowUserToDeleteRows = false;
            this.dgvListaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPersonas.Location = new System.Drawing.Point(4, 4);
            this.dgvListaPersonas.Name = "dgvListaPersonas";
            this.dgvListaPersonas.ReadOnly = true;
            this.dgvListaPersonas.Size = new System.Drawing.Size(257, 246);
            this.dgvListaPersonas.TabIndex = 1;
            // 
            // btnVerLista
            // 
            this.btnVerLista.Location = new System.Drawing.Point(3, 256);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(301, 37);
            this.btnVerLista.TabIndex = 7;
            this.btnVerLista.Text = "Ver Lista de Personas";
            this.btnVerLista.UseVisualStyleBackColor = true;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // CapturaPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CapturaPersonas";
            this.Text = "Informacion de Personas";
            this.Load += new System.EventHandler(this.CapturaPersonas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarPersona;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAlmacenarEnBD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.DataGridView dgvListaPersonas;
        private System.Windows.Forms.Button btnVerLista;
    }
}

