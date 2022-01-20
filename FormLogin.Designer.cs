
namespace Sistema_PDV
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SelectUser = new System.Windows.Forms.ComboBox();
            this.UsuarioBox = new System.Windows.Forms.TextBox();
            this.SenhaBox = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.BtnLimparCampos = new System.Windows.Forms.Label();
            this.BtnAcessar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Label();
            this.LogoTelaLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(169, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(155, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "APPLICATION";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.Red;
            this.lblLogin.Location = new System.Drawing.Point(655, 89);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(69, 23);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "LOGIN";
            // 
            // SelectUser
            // 
            this.SelectUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SelectUser.FormattingEnabled = true;
            this.SelectUser.Items.AddRange(new object[] {
            "ADMIN",
            "FUNC"});
            this.SelectUser.Location = new System.Drawing.Point(599, 135);
            this.SelectUser.Name = "SelectUser";
            this.SelectUser.Size = new System.Drawing.Size(195, 24);
            this.SelectUser.TabIndex = 4;
            this.SelectUser.Text = "Selecione o tipo de usuário";
            // 
            // UsuarioBox
            // 
            this.UsuarioBox.Location = new System.Drawing.Point(599, 199);
            this.UsuarioBox.Name = "UsuarioBox";
            this.UsuarioBox.Size = new System.Drawing.Size(195, 23);
            this.UsuarioBox.TabIndex = 5;
            // 
            // SenhaBox
            // 
            this.SenhaBox.Location = new System.Drawing.Point(599, 264);
            this.SenhaBox.Name = "SenhaBox";
            this.SenhaBox.Size = new System.Drawing.Size(195, 23);
            this.SenhaBox.TabIndex = 6;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Usuario.ForeColor = System.Drawing.Color.Red;
            this.Usuario.Location = new System.Drawing.Point(520, 199);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(73, 18);
            this.Usuario.TabIndex = 7;
            this.Usuario.Text = "USUÁRIO";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Senha.ForeColor = System.Drawing.Color.Red;
            this.Senha.Location = new System.Drawing.Point(537, 264);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(56, 18);
            this.Senha.TabIndex = 8;
            this.Senha.Text = "SENHA";
            // 
            // BtnLimparCampos
            // 
            this.BtnLimparCampos.AutoSize = true;
            this.BtnLimparCampos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BtnLimparCampos.ForeColor = System.Drawing.Color.Red;
            this.BtnLimparCampos.Location = new System.Drawing.Point(640, 381);
            this.BtnLimparCampos.Name = "BtnLimparCampos";
            this.BtnLimparCampos.Size = new System.Drawing.Size(102, 16);
            this.BtnLimparCampos.TabIndex = 9;
            this.BtnLimparCampos.Text = "Limpar campos";
            // 
            // BtnAcessar
            // 
            this.BtnAcessar.BackColor = System.Drawing.Color.Black;
            this.BtnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAcessar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAcessar.ForeColor = System.Drawing.Color.Red;
            this.BtnAcessar.Location = new System.Drawing.Point(628, 336);
            this.BtnAcessar.Name = "BtnAcessar";
            this.BtnAcessar.Size = new System.Drawing.Size(125, 30);
            this.BtnAcessar.TabIndex = 10;
            this.BtnAcessar.Text = "ACESSAR";
            this.BtnAcessar.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(825, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 19);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "x";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LogoTelaLogin
            // 
            this.LogoTelaLogin.BackgroundImage = global::Sistema_PDV.Properties.Resources.drink_house;
            this.LogoTelaLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoTelaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoTelaLogin.Location = new System.Drawing.Point(12, 12);
            this.LogoTelaLogin.Name = "LogoTelaLogin";
            this.LogoTelaLogin.Size = new System.Drawing.Size(419, 426);
            this.LogoTelaLogin.TabIndex = 0;
            this.LogoTelaLogin.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnAcessar);
            this.Controls.Add(this.BtnLimparCampos);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.SenhaBox);
            this.Controls.Add(this.UsuarioBox);
            this.Controls.Add(this.SelectUser);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoTelaLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ComboBox SelectUser;
        private System.Windows.Forms.TextBox UsuarioBox;
        private System.Windows.Forms.TextBox SenhaBox;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Label BtnLimparCampos;
        private System.Windows.Forms.Button BtnAcessar;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Button LogoTelaLogin;
    }
}

