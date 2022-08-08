
namespace LaboratorioClinico
{
    partial class Cita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cita));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHora = new System.Windows.Forms.DateTimePicker();
            this.txtFin = new System.Windows.Forms.DateTimePicker();
            this.txtInicio = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Laboratorio = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar2 = new System.Windows.Forms.Button();
            this.txtbuscar2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.tabla2 = new System.Windows.Forms.DataGridView();
            this.Id_Cita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.txtFin);
            this.groupBox1.Controls.Add(this.txtInicio);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Precio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Telefono);
            this.groupBox1.Controls.Add(this.txt_Correo);
            this.groupBox1.Controls.Add(this.txt_Laboratorio);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del paciente";
            // 
            // txtHora
            // 
            this.txtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHora.Location = new System.Drawing.Point(378, 60);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(172, 23);
            this.txtHora.TabIndex = 28;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(381, 139);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(199, 23);
            this.txtFin.TabIndex = 27;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(378, 105);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(202, 23);
            this.txtInicio.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Hora Inicio";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(77, 211);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(102, 23);
            this.txt_Precio.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Precio Q";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha Fin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fecha Inicio";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(383, 31);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(102, 23);
            this.txt_Telefono.TabIndex = 13;
            this.txt_Telefono.TextChanged += new System.EventHandler(this.txt_Telefono_TextChanged);
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(95, 135);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(186, 23);
            this.txt_Correo.TabIndex = 11;
            // 
            // txt_Laboratorio
            // 
            this.txt_Laboratorio.Location = new System.Drawing.Point(69, 101);
            this.txt_Laboratorio.Name = "txt_Laboratorio";
            this.txt_Laboratorio.Size = new System.Drawing.Size(189, 23);
            this.txt_Laboratorio.TabIndex = 9;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(109, 65);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(189, 23);
            this.txt_Nombre.TabIndex = 8;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(45, 28);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(49, 23);
            this.txt_id.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo Electrónico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Laboratorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de paciente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID cita";
            // 
            // btnbuscar2
            // 
            this.btnbuscar2.BackColor = System.Drawing.Color.DarkGray;
            this.btnbuscar2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnbuscar2.Location = new System.Drawing.Point(476, 267);
            this.btnbuscar2.Name = "btnbuscar2";
            this.btnbuscar2.Size = new System.Drawing.Size(84, 29);
            this.btnbuscar2.TabIndex = 27;
            this.btnbuscar2.Text = "Buscar";
            this.btnbuscar2.UseVisualStyleBackColor = false;
            this.btnbuscar2.Click += new System.EventHandler(this.btnbuscar2_Click);
            // 
            // txtbuscar2
            // 
            this.txtbuscar2.Location = new System.Drawing.Point(55, 270);
            this.txtbuscar2.Name = "txtbuscar2";
            this.txtbuscar2.Size = new System.Drawing.Size(385, 23);
            this.txtbuscar2.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(14, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Buscar";
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.DarkGray;
            this.btnactualizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnactualizar.Location = new System.Drawing.Point(663, 173);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(101, 39);
            this.btnactualizar.TabIndex = 32;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.DarkGray;
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnborrar.Location = new System.Drawing.Point(663, 97);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(101, 39);
            this.btnborrar.TabIndex = 31;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btncancelar.Location = new System.Drawing.Point(663, 261);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(101, 39);
            this.btncancelar.TabIndex = 30;
            this.btncancelar.Text = "Limpiar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.DarkGray;
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnagregar.Location = new System.Drawing.Point(663, 20);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(101, 39);
            this.btnagregar.TabIndex = 29;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // tabla2
            // 
            this.tabla2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tabla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cita,
            this.Paciente,
            this.Laboratorio,
            this.FechaInicio,
            this.Hora_Inicio,
            this.FechaFin,
            this.Precio});
            this.tabla2.Location = new System.Drawing.Point(28, 302);
            this.tabla2.Name = "tabla2";
            this.tabla2.RowTemplate.Height = 25;
            this.tabla2.Size = new System.Drawing.Size(579, 212);
            this.tabla2.TabIndex = 33;
            this.tabla2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla2_CellContentClick);
            // 
            // Id_Cita
            // 
            this.Id_Cita.HeaderText = "Id_Cita";
            this.Id_Cita.Name = "Id_Cita";
            this.Id_Cita.Width = 65;
            // 
            // Paciente
            // 
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.Width = 75;
            // 
            // Laboratorio
            // 
            this.Laboratorio.HeaderText = "Laboratorio";
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.Width = 89;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "FechaInicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Width = 87;
            // 
            // Hora_Inicio
            // 
            this.Hora_Inicio.HeaderText = "HoraInicio";
            this.Hora_Inicio.Name = "Hora_Inicio";
            this.Hora_Inicio.Width = 81;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "FechaFin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Width = 76;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 63;
            // 
            // Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 555);
            this.ControlBox = false;
            this.Controls.Add(this.tabla2);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnbuscar2);
            this.Controls.Add(this.txtbuscar2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Dosis", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Cita";
            this.Text = "Cita";
            this.Load += new System.EventHandler(this.Cita_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Laboratorio;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbuscar2;
        private System.Windows.Forms.TextBox txtbuscar2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView tabla2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txtInicio;
        private System.Windows.Forms.DateTimePicker txtFin;
        private System.Windows.Forms.DateTimePicker txtHora;
    }
}