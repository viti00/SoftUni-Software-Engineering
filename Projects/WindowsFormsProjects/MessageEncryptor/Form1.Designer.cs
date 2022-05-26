
namespace MessageEncryptor
{
    partial class Form1
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
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.EncryptedMessageTextBox = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(25, 35);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(500, 150);
            this.messageTextBox.TabIndex = 0;
            // 
            // EncryptedMessageTextBox
            // 
            this.EncryptedMessageTextBox.Location = new System.Drawing.Point(25, 258);
            this.EncryptedMessageTextBox.Multiline = true;
            this.EncryptedMessageTextBox.Name = "EncryptedMessageTextBox";
            this.EncryptedMessageTextBox.ReadOnly = true;
            this.EncryptedMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EncryptedMessageTextBox.Size = new System.Drawing.Size(500, 150);
            this.EncryptedMessageTextBox.TabIndex = 1;
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Encrypt.Location = new System.Drawing.Point(602, 135);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(75, 50);
            this.Encrypt.TabIndex = 2;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = false;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Copy.Location = new System.Drawing.Point(602, 258);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(75, 50);
            this.Copy.TabIndex = 3;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(602, 195);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 50);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.EncryptedMessageTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Name = "Form1";
            this.Text = "Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox EncryptedMessageTextBox;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Clear;
    }
}

