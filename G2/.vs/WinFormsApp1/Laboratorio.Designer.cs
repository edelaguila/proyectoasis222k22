namespace LaboratorioClinico
{
    partial class Laboratorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laboratorio));
            this.table6 = new System.Windows.Forms.DataGridView();
            this.ID_Examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table6
            // 
            this.table6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Examen,
            this.ID_Paciente,
            this.Nombre,
            this.Tipo,
            this.Precio});
            this.table6.Location = new System.Drawing.Point(68, 313);
            this.table6.Name = "table6";
            this.table6.RowTemplate.Height = 25;
            this.table6.Size = new System.Drawing.Size(466, 160);
            this.table6.TabIndex = 22;
            // 
            // ID_Examen
            // 
            this.ID_Examen.HeaderText = "ID_Laboratorio";
            this.ID_Examen.Name = "ID_Examen";
            // 
            // ID_Paciente
            // 
            this.ID_Paciente.HeaderText = "ID_Medico";
            this.ID_Paciente.Name = "ID_Paciente";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Ubicación";
            this.Tipo.Name = "Tipo";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Teléfono";
            this.Precio.Name = "Precio";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.Location = new System.Drawing.Point(428, 250);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 36);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBorrar.Location = new System.Drawing.Point(492, 76);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(89, 36);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(152, 263);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(260, 23);
            this.txtBuscar.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(68, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Buscar";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdate.Location = new System.Drawing.Point(492, 134);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 36);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClean.Location = new System.Drawing.Point(492, 190);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(89, 36);
            this.btnClean.TabIndex = 16;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnInsertar.Location = new System.Drawing.Point(492, 23);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(89, 36);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtMedico);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(63, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 235);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Examen";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(89, 186);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(173, 23);
            this.txtTel.TabIndex = 8;
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(89, 70);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(173, 23);
            this.txtMedico.TabIndex = 7;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(89, 143);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(173, 23);
            this.txtAdress.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 23);
            this.txtName.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 23);
            this.txtID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(5, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(5, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ubicación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(5, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID_Medico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Laboratorio";
            // 
            // Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 541);
            this.Controls.Add(this.table6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Dosis", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Laboratorio";
            this.Text = "Laboratorio";
            ((System.ComponentModel.ISupportInitialize)(this.table6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Examen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}