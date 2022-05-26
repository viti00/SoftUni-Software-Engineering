
namespace MessageUncryptor
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
            this.Uncrypt = new System.Windows.Forms.Button();
            this.UncryptedMessageTextBox = new System.Windows.Forms.TextBox();
            this.cryptedMessageTextbox = new System.Windows.Forms.TextBox();
            this.Copy = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Uncrypt
            // 
            this.Uncrypt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Uncrypt.Location = new System.Drawing.Point(626, 136);
            this.Uncrypt.Name = "Uncrypt";
            this.Uncrypt.Size = new System.Drawing.Size(75, 50);
            this.Uncrypt.TabIndex = 5;
            this.Uncrypt.Text = "Uncrypt";
            this.Uncrypt.UseVisualStyleBackColor = false;
            this.Uncrypt.Click += new System.EventHandler(this.Uncrypt_Click);
            // 
            // UncryptedMessageTextBox
            // 
            this.UncryptedMessageTextBox.Location = new System.Drawing.Point(49, 259);
            this.UncryptedMessageTextBox.Multiline = true;
            this.UncryptedMessageTextBox.Name = "UncryptedMessageTextBox";
            this.UncryptedMessageTextBox.ReadOnly = true;
            this.UncryptedMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UncryptedMessageTextBox.Size = new System.Drawing.Size(500, 150);
            this.UncryptedMessageTextBox.TabIndex = 4;
            // 
            // cryptedMessageTextbox
            // 
            this.cryptedMessageTextbox.Location = new System.Drawing.Point(49, 36);
            this.cryptedMessageTextbox.Multiline = true;
            this.cryptedMessageTextbox.Name = "cryptedMessageTextbox";
            this.cryptedMessageTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cryptedMessageTextbox.Size = new System.Drawing.Size(500, 150);
            this.cryptedMessageTextbox.TabIndex = 3;
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Copy.Location = new System.Drawing.Point(626, 259);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(75, 50);
            this.Copy.TabIndex = 6;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(626, 197);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 50);
            this.Clear.TabIndex = 7;
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
            this.Controls.Add(this.Uncrypt);
            this.Controls.Add(this.UncryptedMessageTextBox);
            this.Controls.Add(this.cryptedMessageTextbox);
            this.Name = "Form1";
            this.Text = "Uncryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Uncrypt;
        private System.Windows.Forms.TextBox UncryptedMessageTextBox;
        private System.Windows.Forms.TextBox cryptedMessageTextbox;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Clear;
    }
}

