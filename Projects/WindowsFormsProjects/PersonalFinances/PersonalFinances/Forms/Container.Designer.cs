namespace PersonalFinances.Forms
{
    partial class Container
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.logoutPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infoPictureBox = new System.Windows.Forms.PictureBox();
            this.employeesPictureBox = new System.Windows.Forms.PictureBox();
            this.dossierPictureBox = new System.Windows.Forms.PictureBox();
            this.addClientPictureBox = new System.Windows.Forms.PictureBox();
            this.clientsPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClientPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutPictureBox
            // 
            this.logoutPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.logoutPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoutPictureBox.Image")));
            this.logoutPictureBox.Location = new System.Drawing.Point(1134, -1);
            this.logoutPictureBox.Name = "logoutPictureBox";
            this.logoutPictureBox.Size = new System.Drawing.Size(100, 110);
            this.logoutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutPictureBox.TabIndex = 0;
            this.logoutPictureBox.TabStop = false;
            this.logoutPictureBox.Tag = "";
            this.toolTip1.SetToolTip(this.logoutPictureBox, "Излез");
            this.logoutPictureBox.Click += new System.EventHandler(this.logoutPictureBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.infoPictureBox);
            this.groupBox1.Controls.Add(this.employeesPictureBox);
            this.groupBox1.Controls.Add(this.dossierPictureBox);
            this.groupBox1.Controls.Add(this.addClientPictureBox);
            this.groupBox1.Controls.Add(this.clientsPictureBox);
            this.groupBox1.Controls.Add(this.logoutPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1279, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoPictureBox.BackgroundImage")));
            this.infoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoPictureBox.Location = new System.Drawing.Point(962, 0);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.Size = new System.Drawing.Size(100, 110);
            this.infoPictureBox.TabIndex = 4;
            this.infoPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.infoPictureBox, "Помощ");
            this.infoPictureBox.Click += new System.EventHandler(this.infoPictureBox_Click_1);
            // 
            // employeesPictureBox
            // 
            this.employeesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("employeesPictureBox.Image")));
            this.employeesPictureBox.Location = new System.Drawing.Point(11, -1);
            this.employeesPictureBox.Name = "employeesPictureBox";
            this.employeesPictureBox.Size = new System.Drawing.Size(100, 110);
            this.employeesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employeesPictureBox.TabIndex = 4;
            this.employeesPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.employeesPictureBox, "Служители");
            this.employeesPictureBox.Visible = false;
            this.employeesPictureBox.Click += new System.EventHandler(this.employeesPictureBox_Click);
            // 
            // dossierPictureBox
            // 
            this.dossierPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dossierPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dossierPictureBox.Image")));
            this.dossierPictureBox.Location = new System.Drawing.Point(311, -1);
            this.dossierPictureBox.Name = "dossierPictureBox";
            this.dossierPictureBox.Size = new System.Drawing.Size(100, 110);
            this.dossierPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dossierPictureBox.TabIndex = 5;
            this.dossierPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.dossierPictureBox, "Досиета");
            this.dossierPictureBox.Click += new System.EventHandler(this.dossierPictureBox_Click);
            // 
            // addClientPictureBox
            // 
            this.addClientPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClientPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addClientPictureBox.Image")));
            this.addClientPictureBox.Location = new System.Drawing.Point(157, 0);
            this.addClientPictureBox.Name = "addClientPictureBox";
            this.addClientPictureBox.Size = new System.Drawing.Size(100, 110);
            this.addClientPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addClientPictureBox.TabIndex = 2;
            this.addClientPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.addClientPictureBox, "Добави Клиент");
            this.addClientPictureBox.Click += new System.EventHandler(this.addClientPictureBox_Click);
            // 
            // clientsPictureBox
            // 
            this.clientsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("clientsPictureBox.Image")));
            this.clientsPictureBox.Location = new System.Drawing.Point(11, -1);
            this.clientsPictureBox.Name = "clientsPictureBox";
            this.clientsPictureBox.Size = new System.Drawing.Size(100, 110);
            this.clientsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clientsPictureBox.TabIndex = 1;
            this.clientsPictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.clientsPictureBox, "Клиенти");
            this.clientsPictureBox.Click += new System.EventHandler(this.clientsPictureBox_Click);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1282, 803);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Kings Of Finances";
            this.VisibleChanged += new System.EventHandler(this.Container_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dossierPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addClientPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoutPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox clientsPictureBox;
        private System.Windows.Forms.PictureBox addClientPictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox dossierPictureBox;
        private System.Windows.Forms.PictureBox employeesPictureBox;
        private System.Windows.Forms.PictureBox infoPictureBox;
    }
}

