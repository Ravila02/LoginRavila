namespace loginFacu
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
            cmdCancelar = new Button();
            cmdCargarUser = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPassCargar = new TextBox();
            txtUsuarioCargar = new TextBox();
            label3 = new Label();
            txtPerfil = new TextBox();
            SuspendLayout();
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(184, 170);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(75, 23);
            cmdCancelar.TabIndex = 11;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // cmdCargarUser
            // 
            cmdCargarUser.Location = new Point(80, 170);
            cmdCargarUser.Name = "cmdCargarUser";
            cmdCargarUser.Size = new Size(75, 23);
            cmdCargarUser.TabIndex = 10;
            cmdCargarUser.Text = "Ingresar";
            cmdCargarUser.UseVisualStyleBackColor = true;
            cmdCargarUser.Click += cmdCargarUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 86);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 9;
            label2.Text = "Pass";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 43);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 8;
            label1.Text = "Usuario";
            // 
            // txtPassCargar
            // 
            txtPassCargar.Location = new Point(129, 85);
            txtPassCargar.Name = "txtPassCargar";
            txtPassCargar.PasswordChar = '*';
            txtPassCargar.Size = new Size(100, 23);
            txtPassCargar.TabIndex = 7;
            // 
            // txtUsuarioCargar
            // 
            txtUsuarioCargar.Location = new Point(129, 41);
            txtUsuarioCargar.Name = "txtUsuarioCargar";
            txtUsuarioCargar.Size = new Size(100, 23);
            txtUsuarioCargar.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 126);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 12;
            label3.Text = "Perfil";
            // 
            // txtPerfil
            // 
            txtPerfil.Location = new Point(129, 126);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(100, 23);
            txtPerfil.TabIndex = 13;
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 221);
            Controls.Add(txtPerfil);
            Controls.Add(label3);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdCargarUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassCargar);
            Controls.Add(txtUsuarioCargar);
            Name = "CrearUsuario";
            Text = "CrearUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdCancelar;
        private Button cmdCargarUser;
        private Label label2;
        private Label label1;
        private TextBox txtPassCargar;
        private TextBox txtUsuarioCargar;
        private Label label3;
        private TextBox txtPerfil;
    }
}