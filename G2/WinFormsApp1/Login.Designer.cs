
namespace LaboratorioClinico
{
    partial class Login
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
            this.btningresar = new System.Windows.Forms.Button();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioadministrador = new System.Windows.Forms.RadioButton();
            this.radiotrabajador = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(164, 173);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(125, 44);
            this.btningresar.TabIndex = 9;
            this.btningresar.Text = "INICIAR";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(124, 76);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(134, 23);
            this.txtcontraseña.TabIndex = 8;
            this.txtcontraseña.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(124, 37);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(134, 23);
            this.txtusuario.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // radioadministrador
            // 
            this.radioadministrador.AutoSize = true;
            this.radioadministrador.Location = new System.Drawing.Point(322, 36);
            this.radioadministrador.Name = "radioadministrador";
            this.radioadministrador.Size = new System.Drawing.Size(101, 19);
            this.radioadministrador.TabIndex = 10;
            this.radioadministrador.TabStop = true;
            this.radioadministrador.Text = "Administrador";
            this.radioadministrador.UseVisualStyleBackColor = true;
            // 
            // radiotrabajador
            // 
            this.radiotrabajador.AutoSize = true;
            this.radiotrabajador.Location = new System.Drawing.Point(322, 61);
            this.radiotrabajador.Name = "radiotrabajador";
            this.radiotrabajador.Size = new System.Drawing.Size(80, 19);
            this.radiotrabajador.TabIndex = 11;
            this.radiotrabajador.TabStop = true;
            this.radiotrabajador.Text = "Trabajador";
            this.radiotrabajador.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 314);
            this.Controls.Add(this.radiotrabajador);
            this.Controls.Add(this.radioadministrador);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioadministrador;
        private System.Windows.Forms.RadioButton radiotrabajador;
    }
}