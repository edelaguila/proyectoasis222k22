
namespace WinFormsApp1
{
    partial class CrearUsuario
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
            this.checkver = new System.Windows.Forms.CheckBox();
            this.radiotrabajador = new System.Windows.Forms.RadioButton();
            this.radioadministrador = new System.Windows.Forms.RadioButton();
            this.btncrear = new System.Windows.Forms.Button();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconfirmar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkver2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkver
            // 
            this.checkver.AutoSize = true;
            this.checkver.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkver.Location = new System.Drawing.Point(411, 104);
            this.checkver.Name = "checkver";
            this.checkver.Size = new System.Drawing.Size(46, 19);
            this.checkver.TabIndex = 22;
            this.checkver.Text = "ver";
            this.checkver.UseVisualStyleBackColor = true;
            this.checkver.CheckedChanged += new System.EventHandler(this.checkver_CheckedChanged);
            // 
            // radiotrabajador
            // 
            this.radiotrabajador.AutoSize = true;
            this.radiotrabajador.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radiotrabajador.Location = new System.Drawing.Point(315, 204);
            this.radiotrabajador.Name = "radiotrabajador";
            this.radiotrabajador.Size = new System.Drawing.Size(90, 19);
            this.radiotrabajador.TabIndex = 20;
            this.radiotrabajador.TabStop = true;
            this.radiotrabajador.Text = "Trabajador";
            this.radiotrabajador.UseVisualStyleBackColor = true;
            // 
            // radioadministrador
            // 
            this.radioadministrador.AutoSize = true;
            this.radioadministrador.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioadministrador.Location = new System.Drawing.Point(163, 204);
            this.radioadministrador.Name = "radioadministrador";
            this.radioadministrador.Size = new System.Drawing.Size(111, 19);
            this.radioadministrador.TabIndex = 19;
            this.radioadministrador.TabStop = true;
            this.radioadministrador.Text = "Administrador";
            this.radioadministrador.UseVisualStyleBackColor = true;
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(244)))));
            this.btncrear.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btncrear.ForeColor = System.Drawing.Color.White;
            this.btncrear.Location = new System.Drawing.Point(194, 264);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(125, 44);
            this.btncrear.TabIndex = 18;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcontraseña.Location = new System.Drawing.Point(163, 99);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(242, 21);
            this.txtcontraseña.TabIndex = 17;
            this.txtcontraseña.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtusuario.Location = new System.Drawing.Point(163, 60);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(242, 21);
            this.txtusuario.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario";
            // 
            // txtconfirmar
            // 
            this.txtconfirmar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtconfirmar.Location = new System.Drawing.Point(163, 137);
            this.txtconfirmar.Name = "txtconfirmar";
            this.txtconfirmar.Size = new System.Drawing.Size(242, 21);
            this.txtconfirmar.TabIndex = 24;
            this.txtconfirmar.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // checkver2
            // 
            this.checkver2.AutoSize = true;
            this.checkver2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkver2.Location = new System.Drawing.Point(411, 141);
            this.checkver2.Name = "checkver2";
            this.checkver2.Size = new System.Drawing.Size(46, 19);
            this.checkver2.TabIndex = 25;
            this.checkver2.Text = "ver";
            this.checkver2.UseVisualStyleBackColor = true;
            this.checkver2.CheckedChanged += new System.EventHandler(this.checkver2_CheckedChanged);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(521, 388);
            this.Controls.Add(this.checkver2);
            this.Controls.Add(this.txtconfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkver);
            this.Controls.Add(this.radiotrabajador);
            this.Controls.Add(this.radioadministrador);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearUsuario";
            this.Text = "CrearUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkver;
        private System.Windows.Forms.RadioButton radiotrabajador;
        private System.Windows.Forms.RadioButton radioadministrador;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkver2;
    }
}