
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btningresar = new System.Windows.Forms.Button();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioadministrador = new System.Windows.Forms.RadioButton();
            this.radiotrabajador = new System.Windows.Forms.RadioButton();
            this.btncrear = new System.Windows.Forms.Button();
            this.checkver = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbolvido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btningresar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btningresar.ForeColor = System.Drawing.Color.Black;
            this.btningresar.Location = new System.Drawing.Point(243, 269);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(107, 47);
            this.btningresar.TabIndex = 9;
            this.btningresar.Text = "INICIAR";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.button1_Click);
            this.btningresar.MouseLeave += new System.EventHandler(this.btningresar_MouseLeave);
            this.btningresar.MouseHover += new System.EventHandler(this.btningresar_MouseHover);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcontraseña.Location = new System.Drawing.Point(143, 166);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(208, 21);
            this.txtcontraseña.TabIndex = 8;
            this.txtcontraseña.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtusuario.Location = new System.Drawing.Point(143, 125);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(208, 21);
            this.txtusuario.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // radioadministrador
            // 
            this.radioadministrador.AutoSize = true;
            this.radioadministrador.BackColor = System.Drawing.Color.Transparent;
            this.radioadministrador.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioadministrador.Location = new System.Drawing.Point(143, 224);
            this.radioadministrador.Name = "radioadministrador";
            this.radioadministrador.Size = new System.Drawing.Size(111, 19);
            this.radioadministrador.TabIndex = 10;
            this.radioadministrador.TabStop = true;
            this.radioadministrador.Text = "Administrador";
            this.radioadministrador.UseVisualStyleBackColor = false;
            // 
            // radiotrabajador
            // 
            this.radiotrabajador.AutoSize = true;
            this.radiotrabajador.BackColor = System.Drawing.Color.Transparent;
            this.radiotrabajador.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radiotrabajador.Location = new System.Drawing.Point(270, 224);
            this.radiotrabajador.Name = "radiotrabajador";
            this.radiotrabajador.Size = new System.Drawing.Size(90, 19);
            this.radiotrabajador.TabIndex = 11;
            this.radiotrabajador.TabStop = true;
            this.radiotrabajador.Text = "Trabajador";
            this.radiotrabajador.UseVisualStyleBackColor = false;
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btncrear.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncrear.ForeColor = System.Drawing.Color.Black;
            this.btncrear.Location = new System.Drawing.Point(9, 328);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(88, 44);
            this.btncrear.TabIndex = 12;
            this.btncrear.Text = "Crear usuario";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            this.btncrear.MouseLeave += new System.EventHandler(this.btncrear_MouseLeave);
            this.btncrear.MouseHover += new System.EventHandler(this.btncrear_MouseHover);
            // 
            // checkver
            // 
            this.checkver.AutoSize = true;
            this.checkver.BackColor = System.Drawing.Color.Transparent;
            this.checkver.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkver.Location = new System.Drawing.Point(353, 171);
            this.checkver.Name = "checkver";
            this.checkver.Size = new System.Drawing.Size(46, 19);
            this.checkver.TabIndex = 13;
            this.checkver.Text = "ver";
            this.checkver.UseVisualStyleBackColor = false;
            this.checkver.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LaboratorioClinico.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(199, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lbolvido
            // 
            this.lbolvido.AutoSize = true;
            this.lbolvido.BackColor = System.Drawing.Color.Transparent;
            this.lbolvido.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbolvido.Location = new System.Drawing.Point(307, 347);
            this.lbolvido.Name = "lbolvido";
            this.lbolvido.Size = new System.Drawing.Size(171, 15);
            this.lbolvido.TabIndex = 15;
            this.lbolvido.Text = "¿Has olvidado la contraseña?";
            this.lbolvido.Click += new System.EventHandler(this.lbolvido_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(492, 385);
            this.Controls.Add(this.lbolvido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkver);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.radiotrabajador);
            this.Controls.Add(this.radioadministrador);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Dosis", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.CheckBox checkver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbolvido;
    }
}