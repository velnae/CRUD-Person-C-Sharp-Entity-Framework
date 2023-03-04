namespace appdeskperson.PresentationLayer
{
    partial class FrmPerson
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonNatural = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddressN = new System.Windows.Forms.TextBox();
            this.txtIdPerson = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.idPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dateBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPersonJuridica = new System.Windows.Forms.TabPage();
            this.txtAddressJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdPersonJ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPersonJ = new System.Windows.Forms.DataGridView();
            this.btnInsertJ = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idPersonJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPersonNatural.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.tabPersonJuridica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonJ)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonNatural);
            this.tabControl1.Controls.Add(this.tabPersonJuridica);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 402);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPersonNatural
            // 
            this.tabPersonNatural.Controls.Add(this.label8);
            this.tabPersonNatural.Controls.Add(this.txtAddressN);
            this.tabPersonNatural.Controls.Add(this.txtIdPerson);
            this.tabPersonNatural.Controls.Add(this.btnDelete);
            this.tabPersonNatural.Controls.Add(this.dgvPerson);
            this.tabPersonNatural.Controls.Add(this.btnInsert);
            this.tabPersonNatural.Controls.Add(this.dateBirthDate);
            this.tabPersonNatural.Controls.Add(this.label4);
            this.tabPersonNatural.Controls.Add(this.txtSurName);
            this.tabPersonNatural.Controls.Add(this.label3);
            this.tabPersonNatural.Controls.Add(this.txtFirstName);
            this.tabPersonNatural.Controls.Add(this.label2);
            this.tabPersonNatural.Controls.Add(this.txtDni);
            this.tabPersonNatural.Controls.Add(this.label1);
            this.tabPersonNatural.Location = new System.Drawing.Point(4, 22);
            this.tabPersonNatural.Name = "tabPersonNatural";
            this.tabPersonNatural.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonNatural.Size = new System.Drawing.Size(709, 376);
            this.tabPersonNatural.TabIndex = 0;
            this.tabPersonNatural.Text = "Person Natural";
            this.tabPersonNatural.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Dirección";
            // 
            // txtAddressN
            // 
            this.txtAddressN.Location = new System.Drawing.Point(131, 60);
            this.txtAddressN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAddressN.MaxLength = 140;
            this.txtAddressN.Name = "txtAddressN";
            this.txtAddressN.Size = new System.Drawing.Size(300, 20);
            this.txtAddressN.TabIndex = 25;
            // 
            // txtIdPerson
            // 
            this.txtIdPerson.Location = new System.Drawing.Point(45, 8);
            this.txtIdPerson.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIdPerson.MaxLength = 50;
            this.txtIdPerson.Name = "txtIdPerson";
            this.txtIdPerson.Size = new System.Drawing.Size(23, 20);
            this.txtIdPerson.TabIndex = 24;
            this.txtIdPerson.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(544, 338);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 27);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Eliminar registro selec.";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.AllowUserToResizeColumns = false;
            this.dgvPerson.AllowUserToResizeRows = false;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPerson,
            this.dni,
            this.firstName,
            this.surName,
            this.yearOld,
            this.birthDate});
            this.dgvPerson.Location = new System.Drawing.Point(17, 90);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvPerson.MultiSelect = false;
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.RowHeadersWidth = 51;
            this.dgvPerson.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPerson.RowTemplate.Height = 24;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(681, 243);
            this.dgvPerson.TabIndex = 22;
            this.dgvPerson.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellContentDoubleClick);
            // 
            // idPerson
            // 
            this.idPerson.HeaderText = "Id";
            this.idPerson.MinimumWidth = 8;
            this.idPerson.Name = "idPerson";
            this.idPerson.ReadOnly = true;
            this.idPerson.Visible = false;
            this.idPerson.Width = 150;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.MinimumWidth = 6;
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 125;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Nombre";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Width = 125;
            // 
            // surName
            // 
            this.surName.HeaderText = "Apellido";
            this.surName.MinimumWidth = 6;
            this.surName.Name = "surName";
            this.surName.ReadOnly = true;
            this.surName.Width = 125;
            // 
            // yearOld
            // 
            this.yearOld.HeaderText = "Edad";
            this.yearOld.MinimumWidth = 6;
            this.yearOld.Name = "yearOld";
            this.yearOld.ReadOnly = true;
            this.yearOld.Width = 125;
            // 
            // birthDate
            // 
            this.birthDate.HeaderText = "Fecha nacimiento";
            this.birthDate.MinimumWidth = 6;
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;
            this.birthDate.Width = 125;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(455, 57);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(235, 27);
            this.btnInsert.TabIndex = 21;
            this.btnInsert.Text = "Registrar datos";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dateBirthDate
            // 
            this.dateBirthDate.Location = new System.Drawing.Point(455, 34);
            this.dateBirthDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateBirthDate.Name = "dateBirthDate";
            this.dateBirthDate.Size = new System.Drawing.Size(237, 20);
            this.dateBirthDate.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(268, 35);
            this.txtSurName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSurName.MaxLength = 140;
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(163, 20);
            this.txtSurName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Apellido";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(131, 34);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFirstName.MaxLength = 70;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(120, 20);
            this.txtFirstName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(17, 34);
            this.txtDni.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(97, 20);
            this.txtDni.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "DNI";
            // 
            // tabPersonJuridica
            // 
            this.tabPersonJuridica.Controls.Add(this.txtAddressJ);
            this.tabPersonJuridica.Controls.Add(this.label7);
            this.tabPersonJuridica.Controls.Add(this.txtIdPersonJ);
            this.tabPersonJuridica.Controls.Add(this.button1);
            this.tabPersonJuridica.Controls.Add(this.dgvPersonJ);
            this.tabPersonJuridica.Controls.Add(this.btnInsertJ);
            this.tabPersonJuridica.Controls.Add(this.txtRazonSocial);
            this.tabPersonJuridica.Controls.Add(this.label5);
            this.tabPersonJuridica.Controls.Add(this.txtRuc);
            this.tabPersonJuridica.Controls.Add(this.label6);
            this.tabPersonJuridica.Location = new System.Drawing.Point(4, 22);
            this.tabPersonJuridica.Name = "tabPersonJuridica";
            this.tabPersonJuridica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonJuridica.Size = new System.Drawing.Size(709, 376);
            this.tabPersonJuridica.TabIndex = 1;
            this.tabPersonJuridica.Text = "Person Juridica";
            this.tabPersonJuridica.UseVisualStyleBackColor = true;
            // 
            // txtAddressJ
            // 
            this.txtAddressJ.Location = new System.Drawing.Point(279, 32);
            this.txtAddressJ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAddressJ.MaxLength = 70;
            this.txtAddressJ.Name = "txtAddressJ";
            this.txtAddressJ.Size = new System.Drawing.Size(414, 20);
            this.txtAddressJ.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Dirección";
            // 
            // txtIdPersonJ
            // 
            this.txtIdPersonJ.Location = new System.Drawing.Point(21, 55);
            this.txtIdPersonJ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIdPersonJ.MaxLength = 50;
            this.txtIdPersonJ.Name = "txtIdPersonJ";
            this.txtIdPersonJ.Size = new System.Drawing.Size(27, 20);
            this.txtIdPersonJ.TabIndex = 32;
            this.txtIdPersonJ.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 27);
            this.button1.TabIndex = 31;
            this.button1.Text = "Eliminar registro selec.";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvPersonJ
            // 
            this.dgvPersonJ.AllowUserToAddRows = false;
            this.dgvPersonJ.AllowUserToDeleteRows = false;
            this.dgvPersonJ.AllowUserToResizeColumns = false;
            this.dgvPersonJ.AllowUserToResizeRows = false;
            this.dgvPersonJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonJ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonJ,
            this.ruc,
            this.razonSocial,
            this.addressJ});
            this.dgvPersonJ.Location = new System.Drawing.Point(20, 88);
            this.dgvPersonJ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvPersonJ.MultiSelect = false;
            this.dgvPersonJ.Name = "dgvPersonJ";
            this.dgvPersonJ.ReadOnly = true;
            this.dgvPersonJ.RowHeadersWidth = 51;
            this.dgvPersonJ.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPersonJ.RowTemplate.Height = 24;
            this.dgvPersonJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonJ.Size = new System.Drawing.Size(681, 243);
            this.dgvPersonJ.TabIndex = 30;
            this.dgvPersonJ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvPersonJ.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonJ_CellContentDoubleClick);
            // 
            // btnInsertJ
            // 
            this.btnInsertJ.Location = new System.Drawing.Point(458, 55);
            this.btnInsertJ.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInsertJ.Name = "btnInsertJ";
            this.btnInsertJ.Size = new System.Drawing.Size(235, 27);
            this.btnInsertJ.TabIndex = 29;
            this.btnInsertJ.Text = "Registrar datos";
            this.btnInsertJ.UseVisualStyleBackColor = true;
            this.btnInsertJ.Click += new System.EventHandler(this.btnInsertJ_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(134, 32);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRazonSocial.MaxLength = 70;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(120, 20);
            this.txtRazonSocial.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Razon Social";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(20, 32);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRuc.MaxLength = 11;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(97, 20);
            this.txtRuc.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "RUC";
            // 
            // idPersonJ
            // 
            this.idPersonJ.HeaderText = "Id";
            this.idPersonJ.MinimumWidth = 8;
            this.idPersonJ.Name = "idPersonJ";
            this.idPersonJ.ReadOnly = true;
            this.idPersonJ.Visible = false;
            this.idPersonJ.Width = 150;
            // 
            // ruc
            // 
            this.ruc.HeaderText = "RUC";
            this.ruc.MinimumWidth = 6;
            this.ruc.Name = "ruc";
            this.ruc.ReadOnly = true;
            this.ruc.Width = 125;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.MinimumWidth = 6;
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 125;
            // 
            // addressJ
            // 
            this.addressJ.HeaderText = "Direccion";
            this.addressJ.MinimumWidth = 6;
            this.addressJ.Name = "addressJ";
            this.addressJ.ReadOnly = true;
            this.addressJ.Width = 125;
            // 
            // FrmPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 416);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "FrmPerson";
            this.Text = "FrmPerson";
            this.Load += new System.EventHandler(this.FrmPerson_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPersonNatural.ResumeLayout(false);
            this.tabPersonNatural.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.tabPersonJuridica.ResumeLayout(false);
            this.tabPersonJuridica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonNatural;
        private System.Windows.Forms.TextBox txtIdPerson;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn surName;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOld;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dateBirthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPersonJuridica;
        private System.Windows.Forms.TextBox txtIdPersonJ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPersonJ;
        private System.Windows.Forms.Button btnInsertJ;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddressJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAddressN;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressJ;
    }
}