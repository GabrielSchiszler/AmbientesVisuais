namespace DataGridView
{
    partial class FormLogin
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lblLoginNome = new System.Windows.Forms.Label();
            this.lblLoginSenha = new System.Windows.Forms.Label();
            this.txtLoginNome = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.btnLoginEntrar = new System.Windows.Forms.Button();
            this.lblErroLogin = new System.Windows.Forms.Label();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.picLogin);
            this.grpLogin.Controls.Add(this.lblErroLogin);
            this.grpLogin.Controls.Add(this.btnLoginEntrar);
            this.grpLogin.Controls.Add(this.txtLoginSenha);
            this.grpLogin.Controls.Add(this.txtLoginNome);
            this.grpLogin.Controls.Add(this.lblLoginSenha);
            this.grpLogin.Controls.Add(this.lblLoginNome);
            this.grpLogin.Location = new System.Drawing.Point(12, 12);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(383, 233);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // lblLoginNome
            // 
            this.lblLoginNome.AutoSize = true;
            this.lblLoginNome.Location = new System.Drawing.Point(123, 52);
            this.lblLoginNome.Name = "lblLoginNome";
            this.lblLoginNome.Size = new System.Drawing.Size(38, 13);
            this.lblLoginNome.TabIndex = 0;
            this.lblLoginNome.Text = "Nome:";
            // 
            // lblLoginSenha
            // 
            this.lblLoginSenha.AutoSize = true;
            this.lblLoginSenha.Location = new System.Drawing.Point(120, 103);
            this.lblLoginSenha.Name = "lblLoginSenha";
            this.lblLoginSenha.Size = new System.Drawing.Size(41, 13);
            this.lblLoginSenha.TabIndex = 1;
            this.lblLoginSenha.Text = "Senha:";
            // 
            // txtLoginNome
            // 
            this.txtLoginNome.Location = new System.Drawing.Point(167, 49);
            this.txtLoginNome.Name = "txtLoginNome";
            this.txtLoginNome.Size = new System.Drawing.Size(183, 20);
            this.txtLoginNome.TabIndex = 2;
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Location = new System.Drawing.Point(167, 103);
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.PasswordChar = '*';
            this.txtLoginSenha.Size = new System.Drawing.Size(183, 20);
            this.txtLoginSenha.TabIndex = 3;
            // 
            // btnLoginEntrar
            // 
            this.btnLoginEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLoginEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginEntrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoginEntrar.FlatAppearance.BorderSize = 0;
            this.btnLoginEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginEntrar.ForeColor = System.Drawing.Color.White;
            this.btnLoginEntrar.Location = new System.Drawing.Point(291, 196);
            this.btnLoginEntrar.Name = "btnLoginEntrar";
            this.btnLoginEntrar.Size = new System.Drawing.Size(86, 31);
            this.btnLoginEntrar.TabIndex = 4;
            this.btnLoginEntrar.Text = "Entrar";
            this.btnLoginEntrar.UseVisualStyleBackColor = false;
            this.btnLoginEntrar.Click += new System.EventHandler(this.btnLoginEntrar_Click);
            // 
            // lblErroLogin
            // 
            this.lblErroLogin.AutoSize = true;
            this.lblErroLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroLogin.Location = new System.Drawing.Point(163, 145);
            this.lblErroLogin.Name = "lblErroLogin";
            this.lblErroLogin.Size = new System.Drawing.Size(187, 20);
            this.lblErroLogin.TabIndex = 5;
            this.lblErroLogin.Text = "Nome ou senha incorreto";
            // 
            // picLogin
            // 
            this.picLogin.Image = global::DataGridView.Properties.Resources.login;
            this.picLogin.Location = new System.Drawing.Point(6, 26);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(97, 108);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogin.TabIndex = 16;
            this.picLogin.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(416, 271);
            this.Controls.Add(this.grpLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.TextBox txtLoginNome;
        private System.Windows.Forms.Label lblLoginSenha;
        private System.Windows.Forms.Label lblLoginNome;
        private System.Windows.Forms.Button btnLoginEntrar;
        private System.Windows.Forms.Label lblErroLogin;
        private System.Windows.Forms.PictureBox picLogin;
    }
}