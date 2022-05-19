
namespace Jail
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.supToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prisonersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prisonersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.officersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isolatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prisonersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.officersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.isolatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.officersSectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prisonersMailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prisonersIsolatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cellsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.prisonersToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.officersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mailsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.isolatorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jailDataSet = new Jail.JailDataSet();
            this.prisonersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prisonersTableAdapter = new Jail.JailDataSetTableAdapters.PrisonersTableAdapter();
            this.tableAdapterManager = new Jail.JailDataSetTableAdapters.TableAdapterManager();
            this.prisonersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supToolStripMenuItem,
            this.listsToolStripMenuItem,
            this.masterDetailToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1369, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // supToolStripMenuItem
            // 
            this.supToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prisonersToolStripMenuItem,
            this.cellsToolStripMenuItem,
            this.prisonersToolStripMenuItem1,
            this.officersToolStripMenuItem,
            this.mailsToolStripMenuItem,
            this.isolatorToolStripMenuItem});
            this.supToolStripMenuItem.Name = "supToolStripMenuItem";
            this.supToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.supToolStripMenuItem.Text = "Support";
            // 
            // prisonersToolStripMenuItem
            // 
            this.prisonersToolStripMenuItem.Name = "prisonersToolStripMenuItem";
            this.prisonersToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.prisonersToolStripMenuItem.Text = "Sectors";
            this.prisonersToolStripMenuItem.Click += new System.EventHandler(this.prisonersToolStripMenuItem_Click);
            // 
            // cellsToolStripMenuItem
            // 
            this.cellsToolStripMenuItem.Name = "cellsToolStripMenuItem";
            this.cellsToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.cellsToolStripMenuItem.Text = "Cells";
            this.cellsToolStripMenuItem.Click += new System.EventHandler(this.cellsToolStripMenuItem_Click);
            // 
            // prisonersToolStripMenuItem1
            // 
            this.prisonersToolStripMenuItem1.Name = "prisonersToolStripMenuItem1";
            this.prisonersToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.prisonersToolStripMenuItem1.Text = "Prisoners";
            this.prisonersToolStripMenuItem1.Click += new System.EventHandler(this.prisonersToolStripMenuItem1_Click);
            // 
            // officersToolStripMenuItem
            // 
            this.officersToolStripMenuItem.Name = "officersToolStripMenuItem";
            this.officersToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.officersToolStripMenuItem.Text = "Officers";
            this.officersToolStripMenuItem.Click += new System.EventHandler(this.officersToolStripMenuItem_Click);
            // 
            // mailsToolStripMenuItem
            // 
            this.mailsToolStripMenuItem.Name = "mailsToolStripMenuItem";
            this.mailsToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.mailsToolStripMenuItem.Text = "Mails";
            this.mailsToolStripMenuItem.Click += new System.EventHandler(this.mailsToolStripMenuItem_Click);
            // 
            // isolatorToolStripMenuItem
            // 
            this.isolatorToolStripMenuItem.Name = "isolatorToolStripMenuItem";
            this.isolatorToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.isolatorToolStripMenuItem.Text = "Isolator";
            this.isolatorToolStripMenuItem.Click += new System.EventHandler(this.isolatorToolStripMenuItem_Click);
            // 
            // listsToolStripMenuItem
            // 
            this.listsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sectorsToolStripMenuItem,
            this.cellsToolStripMenuItem1,
            this.prisonersToolStripMenuItem2,
            this.officersToolStripMenuItem1,
            this.mailsToolStripMenuItem1,
            this.isolatorToolStripMenuItem1});
            this.listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            this.listsToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.listsToolStripMenuItem.Text = "Lists";
            // 
            // sectorsToolStripMenuItem
            // 
            this.sectorsToolStripMenuItem.Name = "sectorsToolStripMenuItem";
            this.sectorsToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.sectorsToolStripMenuItem.Text = "Sectors";
            this.sectorsToolStripMenuItem.Click += new System.EventHandler(this.sectorsToolStripMenuItem_Click);
            // 
            // cellsToolStripMenuItem1
            // 
            this.cellsToolStripMenuItem1.Name = "cellsToolStripMenuItem1";
            this.cellsToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.cellsToolStripMenuItem1.Text = "Cells";
            this.cellsToolStripMenuItem1.Click += new System.EventHandler(this.cellsToolStripMenuItem1_Click);
            // 
            // prisonersToolStripMenuItem2
            // 
            this.prisonersToolStripMenuItem2.Name = "prisonersToolStripMenuItem2";
            this.prisonersToolStripMenuItem2.Size = new System.Drawing.Size(151, 26);
            this.prisonersToolStripMenuItem2.Text = "Prisoners";
            this.prisonersToolStripMenuItem2.Click += new System.EventHandler(this.prisonersToolStripMenuItem2_Click);
            // 
            // officersToolStripMenuItem1
            // 
            this.officersToolStripMenuItem1.Name = "officersToolStripMenuItem1";
            this.officersToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.officersToolStripMenuItem1.Text = "Officers";
            this.officersToolStripMenuItem1.Click += new System.EventHandler(this.officersToolStripMenuItem1_Click);
            // 
            // mailsToolStripMenuItem1
            // 
            this.mailsToolStripMenuItem1.Name = "mailsToolStripMenuItem1";
            this.mailsToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.mailsToolStripMenuItem1.Text = "Mails";
            this.mailsToolStripMenuItem1.Click += new System.EventHandler(this.mailsToolStripMenuItem1_Click);
            // 
            // isolatorToolStripMenuItem1
            // 
            this.isolatorToolStripMenuItem1.Name = "isolatorToolStripMenuItem1";
            this.isolatorToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.isolatorToolStripMenuItem1.Text = "Isolator";
            this.isolatorToolStripMenuItem1.Click += new System.EventHandler(this.isolatorToolStripMenuItem1_Click);
            // 
            // masterDetailToolStripMenuItem
            // 
            this.masterDetailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.officersSectorsToolStripMenuItem,
            this.prisonersMailsToolStripMenuItem,
            this.prisonersIsolatorToolStripMenuItem});
            this.masterDetailToolStripMenuItem.Name = "masterDetailToolStripMenuItem";
            this.masterDetailToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.masterDetailToolStripMenuItem.Text = "Master detail";
            // 
            // officersSectorsToolStripMenuItem
            // 
            this.officersSectorsToolStripMenuItem.Name = "officersSectorsToolStripMenuItem";
            this.officersSectorsToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.officersSectorsToolStripMenuItem.Text = "OfficersSectors";
            this.officersSectorsToolStripMenuItem.Click += new System.EventHandler(this.officersSectorsToolStripMenuItem_Click);
            // 
            // prisonersMailsToolStripMenuItem
            // 
            this.prisonersMailsToolStripMenuItem.Name = "prisonersMailsToolStripMenuItem";
            this.prisonersMailsToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.prisonersMailsToolStripMenuItem.Text = "PrisonersMails";
            this.prisonersMailsToolStripMenuItem.Click += new System.EventHandler(this.prisonersMailsToolStripMenuItem_Click);
            // 
            // prisonersIsolatorToolStripMenuItem
            // 
            this.prisonersIsolatorToolStripMenuItem.Name = "prisonersIsolatorToolStripMenuItem";
            this.prisonersIsolatorToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.prisonersIsolatorToolStripMenuItem.Text = "PrisonersIsolator";
            this.prisonersIsolatorToolStripMenuItem.Click += new System.EventHandler(this.prisonersIsolatorToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sectorsToolStripMenuItem1,
            this.cellsToolStripMenuItem2,
            this.prisonersToolStripMenuItem3,
            this.officersToolStripMenuItem2,
            this.mailsToolStripMenuItem2,
            this.isolatorToolStripMenuItem2});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // sectorsToolStripMenuItem1
            // 
            this.sectorsToolStripMenuItem1.Name = "sectorsToolStripMenuItem1";
            this.sectorsToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.sectorsToolStripMenuItem1.Text = "Sectors";
            this.sectorsToolStripMenuItem1.Click += new System.EventHandler(this.sectorsToolStripMenuItem1_Click);
            // 
            // cellsToolStripMenuItem2
            // 
            this.cellsToolStripMenuItem2.Name = "cellsToolStripMenuItem2";
            this.cellsToolStripMenuItem2.Size = new System.Drawing.Size(151, 26);
            this.cellsToolStripMenuItem2.Text = "Cells";
            this.cellsToolStripMenuItem2.Click += new System.EventHandler(this.cellsToolStripMenuItem2_Click);
            // 
            // prisonersToolStripMenuItem3
            // 
            this.prisonersToolStripMenuItem3.Name = "prisonersToolStripMenuItem3";
            this.prisonersToolStripMenuItem3.Size = new System.Drawing.Size(151, 26);
            this.prisonersToolStripMenuItem3.Text = "Prisoners";
            this.prisonersToolStripMenuItem3.Click += new System.EventHandler(this.prisonersToolStripMenuItem3_Click);
            // 
            // officersToolStripMenuItem2
            // 
            this.officersToolStripMenuItem2.Name = "officersToolStripMenuItem2";
            this.officersToolStripMenuItem2.Size = new System.Drawing.Size(151, 26);
            this.officersToolStripMenuItem2.Text = "Officers";
            this.officersToolStripMenuItem2.Click += new System.EventHandler(this.officersToolStripMenuItem2_Click);
            // 
            // mailsToolStripMenuItem2
            // 
            this.mailsToolStripMenuItem2.Name = "mailsToolStripMenuItem2";
            this.mailsToolStripMenuItem2.Size = new System.Drawing.Size(151, 26);
            this.mailsToolStripMenuItem2.Text = "Mails";
            this.mailsToolStripMenuItem2.Click += new System.EventHandler(this.mailsToolStripMenuItem2_Click);
            // 
            // isolatorToolStripMenuItem2
            // 
            this.isolatorToolStripMenuItem2.Name = "isolatorToolStripMenuItem2";
            this.isolatorToolStripMenuItem2.Size = new System.Drawing.Size(151, 26);
            this.isolatorToolStripMenuItem2.Text = "Isolator";
            this.isolatorToolStripMenuItem2.Click += new System.EventHandler(this.isolatorToolStripMenuItem2_Click);
            // 
            //
            // 
            // jailDataSet
            // 
            this.jailDataSet.DataSetName = "JailDataSet";
            this.jailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prisonersBindingSource
            // 
            this.prisonersBindingSource.DataMember = "Prisoners";
            this.prisonersBindingSource.DataSource = this.jailDataSet;
            // 
            // prisonersTableAdapter
            // 
            this.prisonersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CellsTableAdapter = null;
            this.tableAdapterManager.IsolatorTableAdapter = null;
            this.tableAdapterManager.MailsTableAdapter = null;
            this.tableAdapterManager.OfficersTableAdapter = null;
            this.tableAdapterManager.PrisonersTableAdapter = this.prisonersTableAdapter;
            this.tableAdapterManager.SectorsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Jail.JailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prisonersDataGridView
            // 
            this.prisonersDataGridView.AutoGenerateColumns = false;
            this.prisonersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prisonersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.prisonersDataGridView.DataSource = this.prisonersBindingSource;
            this.prisonersDataGridView.Location = new System.Drawing.Point(569, 867);
            this.prisonersDataGridView.Name = "prisonersDataGridView";
            this.prisonersDataGridView.RowHeadersWidth = 51;
            this.prisonersDataGridView.RowTemplate.Height = 24;
            this.prisonersDataGridView.Size = new System.Drawing.Size(300, 220);
            this.prisonersDataGridView.TabIndex = 3;
            this.prisonersDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrisonerNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "PrisonerNumber";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn4.HeaderText = "Age";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ReleaseDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "ReleaseDate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CellId";
            this.dataGridViewTextBoxColumn6.HeaderText = "CellId";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1369, 940);
            this.Controls.Add(this.prisonersDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prisonersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prisonersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem officersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isolatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prisonersToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem officersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem isolatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cellsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem prisonersToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem officersToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mailsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem isolatorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem masterDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem officersSectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prisonersMailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prisonersIsolatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private JailDataSet jailDataSet;
        private System.Windows.Forms.BindingSource prisonersBindingSource;
        private JailDataSetTableAdapters.PrisonersTableAdapter prisonersTableAdapter;
        private JailDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView prisonersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

