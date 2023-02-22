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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.idPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtIdPerson = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(17, 35);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(144, 26);
            this.txtDni.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(187, 35);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.MaxLength = 70;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 26);
            this.txtFirstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(393, 37);
            this.txtSurName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSurName.MaxLength = 140;
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(243, 26);
            this.txtSurName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // dateBirthDate
            // 
            this.dateBirthDate.Location = new System.Drawing.Point(673, 35);
            this.dateBirthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateBirthDate.Name = "dateBirthDate";
            this.dateBirthDate.Size = new System.Drawing.Size(353, 26);
            this.dateBirthDate.TabIndex = 8;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(673, 70);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(353, 41);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Registrar datos";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.dgvPerson.Location = new System.Drawing.Point(17, 121);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPerson.MultiSelect = false;
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.RowHeadersWidth = 51;
            this.dgvPerson.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPerson.RowTemplate.Height = 24;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(1021, 374);
            this.dgvPerson.TabIndex = 10;
            this.dgvPerson.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellContentDoubleClick);
            this.dgvPerson.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPerson_MouseDoubleClick);
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(807, 503);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(219, 41);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Eliminar registro selec.";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtIdPerson
            // 
            this.txtIdPerson.Location = new System.Drawing.Point(18, 70);
            this.txtIdPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdPerson.MaxLength = 50;
            this.txtIdPerson.Name = "txtIdPerson";
            this.txtIdPerson.Size = new System.Drawing.Size(144, 26);
            this.txtIdPerson.TabIndex = 12;
            this.txtIdPerson.Visible = false;
            // 
            // FrmPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 560);
            this.Controls.Add(this.txtIdPerson);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dateBirthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSurName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPerson";
            this.Text = "FrmPerson";
            this.Load += new System.EventHandler(this.FrmPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateBirthDate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn surName;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOld;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtIdPerson;
    }
}