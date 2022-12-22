namespace PersonalFinances.Forms
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
            this.LoginIcon = new System.Windows.Forms.PictureBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.EMPLOYEETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LoginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginIcon
            // 
            this.LoginIcon.Image = ((System.Drawing.Image)(resources.GetObject("LoginIcon.Image")));
            this.LoginIcon.Location = new System.Drawing.Point(227, 12);
            this.LoginIcon.Name = "LoginIcon";
            this.LoginIcon.Size = new System.Drawing.Size(146, 134);
            this.LoginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginIcon.TabIndex = 0;
            this.LoginIcon.TabStop = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(175, 301);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(250, 22);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(175, 371);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(250, 22);
            this.passwordTextBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernameLabel.Location = new System.Drawing.Point(180, 272);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(177, 20);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Потребителско име";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordLabel.Location = new System.Drawing.Point(180, 342);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(72, 20);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Парола";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(225, 177);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(142, 57);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Login";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginBtn.Location = new System.Drawing.Point(176, 426);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(250, 44);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(172, 403);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(264, 16);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.Text = "Грешно потребителско име или парола";
            this.errorLabel.Visible = false;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.LoginIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Влизане";
            ((System.ComponentModel.ISupportInitialize)(this.LoginIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginIcon;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label errorLabel;
        private Data.PersonalFinancesDataSet1TableAdapters.EMPLOYEETableAdapter employeeTableAdapter;
    }
}