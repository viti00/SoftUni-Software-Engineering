
namespace Jail.report_forms
{
    partial class frmOfficersReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOfficersReport));
            this.jailDataSet = new Jail.JailDataSet();
            this.officersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officersTableAdapter = new Jail.JailDataSetTableAdapters.OfficersTableAdapter();
            this.tableAdapterManager = new Jail.JailDataSetTableAdapters.TableAdapterManager();
            this.sectorsTableAdapter = new Jail.JailDataSetTableAdapters.SectorsTableAdapter();
            this.officersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.officersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sectorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ExcelExport = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.moreParam = new System.Windows.Forms.Button();
            this.oneParam = new System.Windows.Forms.Button();
            this.oneParamTextBox = new System.Windows.Forms.TextBox();
            this.oneParamLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.Weapon = new System.Windows.Forms.Label();
            this.SectorId = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.weaponTextBox = new System.Windows.Forms.TextBox();
            this.sectorIdComboBox = new System.Windows.Forms.ComboBox();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingNavigator)).BeginInit();
            this.officersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jailDataSet
            // 
            this.jailDataSet.DataSetName = "JailDataSet";
            this.jailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // officersBindingSource
            // 
            this.officersBindingSource.DataMember = "Officers";
            this.officersBindingSource.DataSource = this.jailDataSet;
            // 
            // officersTableAdapter
            // 
            this.officersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CellsTableAdapter = null;
            this.tableAdapterManager.IsolatorTableAdapter = null;
            this.tableAdapterManager.MailsTableAdapter = null;
            this.tableAdapterManager.OfficersTableAdapter = this.officersTableAdapter;
            this.tableAdapterManager.PrisonersTableAdapter = null;
            this.tableAdapterManager.SectorsTableAdapter = this.sectorsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Jail.JailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sectorsTableAdapter
            // 
            this.sectorsTableAdapter.ClearBeforeFill = true;
            // 
            // officersBindingNavigator
            // 
            this.officersBindingNavigator.AddNewItem = null;
            this.officersBindingNavigator.BindingSource = this.officersBindingSource;
            this.officersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.officersBindingNavigator.DeleteItem = null;
            this.officersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.officersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.officersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.officersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.officersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.officersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.officersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.officersBindingNavigator.Name = "officersBindingNavigator";
            this.officersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.officersBindingNavigator.Size = new System.Drawing.Size(1334, 27);
            this.officersBindingNavigator.TabIndex = 0;
            this.officersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // officersDataGridView
            // 
            this.officersDataGridView.AutoGenerateColumns = false;
            this.officersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.officersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Delete});
            this.officersDataGridView.DataSource = this.officersBindingSource;
            this.officersDataGridView.Location = new System.Drawing.Point(0, 238);
            this.officersDataGridView.Name = "officersDataGridView";
            this.officersDataGridView.RowHeadersWidth = 51;
            this.officersDataGridView.RowTemplate.Height = 24;
            this.officersDataGridView.Size = new System.Drawing.Size(1334, 308);
            this.officersDataGridView.TabIndex = 1;
            this.officersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.officersDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn3.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Weapon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Weapon";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SectorId";
            this.dataGridViewTextBoxColumn5.DataSource = this.sectorsBindingSource1;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "SectorId";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "Id";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // sectorsBindingSource1
            // 
            this.sectorsBindingSource1.DataMember = "Sectors";
            this.sectorsBindingSource1.DataSource = this.jailDataSet;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // ExcelExport
            // 
            this.ExcelExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExcelExport.BackgroundImage")));
            this.ExcelExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExcelExport.Location = new System.Drawing.Point(520, 137);
            this.ExcelExport.Name = "ExcelExport";
            this.ExcelExport.Size = new System.Drawing.Size(49, 45);
            this.ExcelExport.TabIndex = 19;
            this.ExcelExport.UseVisualStyleBackColor = true;
            this.ExcelExport.Click += new System.EventHandler(this.ExcelExport_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(491, 57);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(109, 52);
            this.Save.TabIndex = 18;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(345, 137);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 52);
            this.Cancel.TabIndex = 17;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(345, 57);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(109, 52);
            this.Search.TabIndex = 20;
            this.Search.Text = "Search";
            this.Search.Visible = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // moreParam
            // 
            this.moreParam.Location = new System.Drawing.Point(345, 137);
            this.moreParam.Name = "moreParam";
            this.moreParam.Size = new System.Drawing.Size(109, 52);
            this.moreParam.TabIndex = 16;
            this.moreParam.Text = "Search by more params";
            this.moreParam.UseVisualStyleBackColor = true;
            this.moreParam.Click += new System.EventHandler(this.moreParam_Click);
            // 
            // oneParam
            // 
            this.oneParam.Location = new System.Drawing.Point(345, 57);
            this.oneParam.Name = "oneParam";
            this.oneParam.Size = new System.Drawing.Size(109, 52);
            this.oneParam.TabIndex = 15;
            this.oneParam.Text = "Search by one param";
            this.oneParam.UseVisualStyleBackColor = true;
            this.oneParam.Click += new System.EventHandler(this.oneParam_Click);
            // 
            // oneParamTextBox
            // 
            this.oneParamTextBox.Location = new System.Drawing.Point(114, 57);
            this.oneParamTextBox.Name = "oneParamTextBox";
            this.oneParamTextBox.Size = new System.Drawing.Size(195, 22);
            this.oneParamTextBox.TabIndex = 22;
            this.oneParamTextBox.Visible = false;
            // 
            // oneParamLabel
            // 
            this.oneParamLabel.AutoSize = true;
            this.oneParamLabel.Location = new System.Drawing.Point(12, 57);
            this.oneParamLabel.Name = "oneParamLabel";
            this.oneParamLabel.Size = new System.Drawing.Size(84, 17);
            this.oneParamLabel.TabIndex = 21;
            this.oneParamLabel.Text = "Enter value:";
            this.oneParamLabel.Visible = false;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(12, 57);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(71, 17);
            this.fullNameLabel.TabIndex = 23;
            this.fullNameLabel.Text = "FullName:";
            this.fullNameLabel.Visible = false;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(114, 57);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(195, 22);
            this.fullNameTextBox.TabIndex = 25;
            this.fullNameTextBox.Visible = false;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(12, 92);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(52, 17);
            this.Salary.TabIndex = 26;
            this.Salary.Text = "Salary:";
            this.Salary.Visible = false;
            // 
            // Weapon
            // 
            this.Weapon.AutoSize = true;
            this.Weapon.Location = new System.Drawing.Point(12, 128);
            this.Weapon.Name = "Weapon";
            this.Weapon.Size = new System.Drawing.Size(65, 17);
            this.Weapon.TabIndex = 27;
            this.Weapon.Text = "Weapon:";
            this.Weapon.Visible = false;
            // 
            // SectorId
            // 
            this.SectorId.AutoSize = true;
            this.SectorId.Location = new System.Drawing.Point(12, 172);
            this.SectorId.Name = "SectorId";
            this.SectorId.Size = new System.Drawing.Size(64, 17);
            this.SectorId.TabIndex = 28;
            this.SectorId.Text = "SectorId:";
            this.SectorId.Visible = false;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(114, 92);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(195, 22);
            this.salaryTextBox.TabIndex = 29;
            this.salaryTextBox.Visible = false;
            // 
            // weaponTextBox
            // 
            this.weaponTextBox.Location = new System.Drawing.Point(114, 128);
            this.weaponTextBox.Name = "weaponTextBox";
            this.weaponTextBox.Size = new System.Drawing.Size(195, 22);
            this.weaponTextBox.TabIndex = 30;
            this.weaponTextBox.Visible = false;
            // 
            // sectorIdComboBox
            // 
            this.sectorIdComboBox.DataSource = this.sectorsBindingSource;
            this.sectorIdComboBox.DisplayMember = "Id";
            this.sectorIdComboBox.FormattingEnabled = true;
            this.sectorIdComboBox.Location = new System.Drawing.Point(114, 172);
            this.sectorIdComboBox.Name = "sectorIdComboBox";
            this.sectorIdComboBox.Size = new System.Drawing.Size(195, 24);
            this.sectorIdComboBox.TabIndex = 31;
            this.sectorIdComboBox.ValueMember = "Id";
            this.sectorIdComboBox.Visible = false;
            // 
            // sectorsBindingSource
            // 
            this.sectorsBindingSource.DataMember = "Sectors";
            this.sectorsBindingSource.DataSource = this.jailDataSet;
            // 
            // frmOfficersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.sectorIdComboBox);
            this.Controls.Add(this.weaponTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.SectorId);
            this.Controls.Add(this.Weapon);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.oneParamTextBox);
            this.Controls.Add(this.oneParamLabel);
            this.Controls.Add(this.ExcelExport);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.moreParam);
            this.Controls.Add(this.oneParam);
            this.Controls.Add(this.officersDataGridView);
            this.Controls.Add(this.officersBindingNavigator);
            this.Name = "frmOfficersReport";
            this.Text = "frmOfficersReport";
            this.Load += new System.EventHandler(this.frmOfficersReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingNavigator)).EndInit();
            this.officersBindingNavigator.ResumeLayout(false);
            this.officersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JailDataSet jailDataSet;
        private System.Windows.Forms.BindingSource officersBindingSource;
        private JailDataSetTableAdapters.OfficersTableAdapter officersTableAdapter;
        private JailDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator officersBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView officersDataGridView;
        private System.Windows.Forms.Button ExcelExport;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button moreParam;
        private System.Windows.Forms.Button oneParam;
        private System.Windows.Forms.TextBox oneParamTextBox;
        private System.Windows.Forms.Label oneParamLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private JailDataSetTableAdapters.SectorsTableAdapter sectorsTableAdapter;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label Weapon;
        private System.Windows.Forms.Label SectorId;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox weaponTextBox;
        private System.Windows.Forms.ComboBox sectorIdComboBox;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource sectorsBindingSource1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}