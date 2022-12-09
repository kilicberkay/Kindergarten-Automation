namespace OkulOtomasyonu
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
            this.ogretmenRadioButton = new System.Windows.Forms.RadioButton();
            this.ogrenciRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ogretmenRadioButton
            // 
            this.ogretmenRadioButton.AutoSize = true;
            this.ogretmenRadioButton.Location = new System.Drawing.Point(228, 41);
            this.ogretmenRadioButton.Name = "ogretmenRadioButton";
            this.ogretmenRadioButton.Size = new System.Drawing.Size(81, 17);
            this.ogretmenRadioButton.TabIndex = 15;
            this.ogretmenRadioButton.Text = "Öğretmenim";
            this.ogretmenRadioButton.UseVisualStyleBackColor = true;
            // 
            // ogrenciRadioButton
            // 
            this.ogrenciRadioButton.AutoSize = true;
            this.ogrenciRadioButton.Checked = true;
            this.ogrenciRadioButton.Location = new System.Drawing.Point(116, 41);
            this.ogrenciRadioButton.Name = "ogrenciRadioButton";
            this.ogrenciRadioButton.Size = new System.Drawing.Size(77, 17);
            this.ogrenciRadioButton.TabIndex = 14;
            this.ogrenciRadioButton.TabStop = true;
            this.ogrenciRadioButton.Text = "Ögrenciyim";
            this.ogrenciRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(118, 143);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(215, 20);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(118, 96);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(215, 20);
            this.userNameTextBox.TabIndex = 10;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(258, 178);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Çıkış";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(118, 178);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Giriş";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 243);
            this.Controls.Add(this.ogretmenRadioButton);
            this.Controls.Add(this.ogrenciRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ogretmenRadioButton;
        private System.Windows.Forms.RadioButton ogrenciRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loginButton;
    }
}

