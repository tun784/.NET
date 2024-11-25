namespace Bai_2
{
    partial class MainForm
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
            this._userName = new System.Windows.Forms.Label();
            this._email = new System.Windows.Forms.Label();
            this._password = new System.Windows.Forms.Label();
            this._repeatPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _userName
            // 
            this._userName.AutoSize = true;
            this._userName.Location = new System.Drawing.Point(12, 15);
            this._userName.Name = "_userName";
            this._userName.Size = new System.Drawing.Size(84, 13);
            this._userName.TabIndex = 0;
            this._userName.Text = "Tên Đăng Nhập";
            // 
            // _email
            // 
            this._email.AutoSize = true;
            this._email.Location = new System.Drawing.Point(12, 41);
            this._email.Name = "_email";
            this._email.Size = new System.Drawing.Size(69, 13);
            this._email.TabIndex = 1;
            this._email.Text = "Địa Chỉ Email";
            // 
            // _password
            // 
            this._password.AutoSize = true;
            this._password.Location = new System.Drawing.Point(12, 67);
            this._password.Name = "_password";
            this._password.Size = new System.Drawing.Size(53, 13);
            this._password.TabIndex = 2;
            this._password.Text = "Mật Khẩu";
            // 
            // _repeatPassword
            // 
            this._repeatPassword.AutoSize = true;
            this._repeatPassword.Location = new System.Drawing.Point(12, 93);
            this._repeatPassword.Name = "_repeatPassword";
            this._repeatPassword.Size = new System.Drawing.Size(104, 13);
            this._repeatPassword.TabIndex = 3;
            this._repeatPassword.Text = "Xác Nhận Mật Khẩu";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(122, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(226, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(122, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(226, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(122, 90);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(226, 20);
            this.txtRepeatPassword.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSignUp.Location = new System.Drawing.Point(12, 116);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(336, 33);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Đăng Ký";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 162);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this._repeatPassword);
            this.Controls.Add(this._password);
            this.Controls.Add(this._email);
            this.Controls.Add(this._userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký Tài Khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _userName;
        private System.Windows.Forms.Label _email;
        private System.Windows.Forms.Label _password;
        private System.Windows.Forms.Label _repeatPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSignUp;
    }
}

