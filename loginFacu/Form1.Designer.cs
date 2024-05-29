namespace loginFacu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmdIngresar = new Button();
            cmdCancelar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(90, 52);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(90, 102);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 54);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 104);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 3;
            label2.Text = "Pass";
            // 
            // cmdIngresar
            // 
            cmdIngresar.Location = new Point(47, 147);
            cmdIngresar.Name = "cmdIngresar";
            cmdIngresar.Size = new Size(75, 23);
            cmdIngresar.TabIndex = 4;
            cmdIngresar.Text = "Ingresar";
            cmdIngresar.UseVisualStyleBackColor = true;
            cmdIngresar.Click += cmdIngresar_Click;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(147, 147);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(75, 23);
            cmdCancelar.TabIndex = 5;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 9);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 6;
            label3.Text = "INICIO  SESION";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 214);
            Controls.Add(label3);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdIngresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtPass;
        private Label label1;
        private Label label2;
        private Button cmdIngresar;
        private Button cmdCancelar;
        private Label label3;
    }
}
