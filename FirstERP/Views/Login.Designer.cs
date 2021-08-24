
namespace FirstERP.Views
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
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.b_Login = new System.Windows.Forms.Button();
            this.l_Teste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(56, 25);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(187, 20);
            this.tb_Login.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(56, 64);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(187, 20);
            this.tb_password.TabIndex = 1;
            // 
            // b_Login
            // 
            this.b_Login.Location = new System.Drawing.Point(56, 103);
            this.b_Login.Name = "b_Login";
            this.b_Login.Size = new System.Drawing.Size(75, 23);
            this.b_Login.TabIndex = 2;
            this.b_Login.Text = "Login";
            this.b_Login.UseVisualStyleBackColor = true;
            this.b_Login.Click += new System.EventHandler(this.b_Login_Click);
            // 
            // l_Teste
            // 
            this.l_Teste.AutoSize = true;
            this.l_Teste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Teste.Location = new System.Drawing.Point(172, 103);
            this.l_Teste.Name = "l_Teste";
            this.l_Teste.Size = new System.Drawing.Size(60, 24);
            this.l_Teste.TabIndex = 3;
            this.l_Teste.Text = "label1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 148);
            this.Controls.Add(this.l_Teste);
            this.Controls.Add(this.b_Login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_Login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button b_Login;
        private System.Windows.Forms.Label l_Teste;
    }
}