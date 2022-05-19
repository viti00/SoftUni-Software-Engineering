
namespace Jail.report_forms
{
    partial class frmCellsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCellsReport));
            this.jailDataSet = new Jail.JailDataSet();
            this.cellsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cellsTableAdapter = new Jail.JailDataSetTableAdapters.CellsTableAdapter();
            this.tableAdapterManager = new Jail.JailDataSetTableAdapters.TableAdapterManager();
            this.cellsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cellsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sectorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.oneParam = new System.Windows.Forms.Button();
            this.moreParam = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.ExcelExport = new System.Windows.Forms.Button();
            this.oneParamLabel = new System.Windows.Forms.Label();
            this.oneParamTextBox = new System.Windows.Forms.TextBox();
            this.cellNumberTextBox = new System.Windows.Forms.TextBox();
            this.cellNumberLabel = new System.Windows.Forms.Label();
            this.sectorIdLabel = new System.Windows.Forms.Label();
            this.SectorIdComboBox = new System.Windows.Forms.ComboBox();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectorsTableAdapter = new Jail.JailDataSetTableAdapters.SectorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingNavigator)).BeginInit();
            this.cellsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cellsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jailDataSet
            // 
            this.jailDataSet.DataSetName = "JailDataSet";
            this.jailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cellsBindingSource
            // 
            this.cellsBindingSource.DataMember = "Cells";
            this.cellsBindingSource.DataSource = this.jailDataSet;
            // 
            // cellsTableAdapter
            // 
            this.cellsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CellsTableAdapter = this.cellsTableAdapter;
            this.tableAdapterManager.IsolatorTableAdapter = null;
            this.tableAdapterManager.MailsTableAdapter = null;
            this.tableAdapterManager.OfficersTableAdapter = null;
            this.tableAdapterManager.PrisonersTableAdapter = null;
            this.tableAdapterManager.SectorsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Jail.JailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cellsBindingNavigator
            // 
            this.cellsBindingNavigator.AddNewItem = null;
            this.cellsBindingNavigator.BindingSource = this.cellsBindingSource;
            this.cellsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cellsBindingNavigator.DeleteItem = null;
            this.cellsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cellsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.cellsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cellsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cellsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cellsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cellsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cellsBindingNavigator.Name = "cellsBindingNavigator";
            this.cellsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cellsBindingNavigator.Size = new System.Drawing.Size(1334, 27);
            this.cellsBindingNavigator.TabIndex = 0;
            this.cellsBindingNavigator.Text = "bindingNavigator1";
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
            // cellsDataGridView
            // 
            this.cellsDataGridView.AutoGenerateColumns = false;
            this.cellsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cellsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Delete});
            this.cellsDataGridView.DataSource = this.cellsBindingSource;
            this.cellsDataGridView.Location = new System.Drawing.Point(0, 232);
            this.cellsDataGridView.Name = "cellsDataGridView";
            this.cellsDataGridView.RowHeadersWidth = 51;
            this.cellsDataGridView.RowTemplate.Height = 24;
            this.cellsDataGridView.Size = new System.Drawing.Size(1334, 308);
            this.cellsDataGridView.TabIndex = 1;
            this.cellsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellsDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CellNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "CellNumber";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SectorId";
            this.dataGridViewTextBoxColumn3.DataSource = this.sectorsBindingSource1;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "SectorId";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            this.dataGridViewTextBoxColumn3.Width = 125;
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
            // oneParam
            // 
            this.oneParam.Location = new System.Drawing.Point(371, 71);
            this.oneParam.Name = "oneParam";
            this.oneParam.Size = new System.Drawing.Size(109, 52);
            this.oneParam.TabIndex = 2;
            this.oneParam.Text = "Search by one param";
            this.oneParam.UseVisualStyleBackColor = true;
            this.oneParam.Click += new System.EventHandler(this.OneParam_Click);
            // 
            // moreParam
            // 
            this.moreParam.Location = new System.Drawing.Point(371, 151);
            this.moreParam.Name = "moreParam";
            this.moreParam.Size = new System.Drawing.Size(109, 52);
            this.moreParam.TabIndex = 3;
            this.moreParam.Text = "Search by more params";
            this.moreParam.UseVisualStyleBackColor = true;
            this.moreParam.Click += new System.EventHandler(this.MoreParams_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(371, 70);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(109, 52);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.Visible = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(371, 151);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 52);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(517, 71);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(109, 52);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ExcelExport
            // 
            this.ExcelExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExcelExport.BackgroundImage")));
            this.ExcelExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExcelExport.Location = new System.Drawing.Point(546, 155);
            this.ExcelExport.Name = "ExcelExport";
            this.ExcelExport.Size = new System.Drawing.Size(49, 45);
            this.ExcelExport.TabIndex = 7;
            this.ExcelExport.UseVisualStyleBackColor = true;
            this.ExcelExport.Click += new System.EventHandler(this.ExcelExport_Click);
            // 
            // oneParamLabel
            // 
            this.oneParamLabel.AutoSize = true;
            this.oneParamLabel.Location = new System.Drawing.Point(12, 69);
            this.oneParamLabel.Name = "oneParamLabel";
            this.oneParamLabel.Size = new System.Drawing.Size(84, 17);
            this.oneParamLabel.TabIndex = 9;
            this.oneParamLabel.Text = "Enter value:";
            this.oneParamLabel.Visible = false;
            // 
            // oneParamTextBox
            // 
            this.oneParamTextBox.Location = new System.Drawing.Point(102, 69);
            this.oneParamTextBox.Name = "oneParamTextBox";
            this.oneParamTextBox.Size = new System.Drawing.Size(195, 22);
            this.oneParamTextBox.TabIndex = 10;
            this.oneParamTextBox.Visible = false;
            // 
            // cellNumberTextBox
            // 
            this.cellNumberTextBox.Location = new System.Drawing.Point(102, 69);
            this.cellNumberTextBox.Name = "cellNumberTextBox";
            this.cellNumberTextBox.Size = new System.Drawing.Size(195, 22);
            this.cellNumberTextBox.TabIndex = 11;
            this.cellNumberTextBox.Visible = false;
            // 
            // cellNumberLabel
            // 
            this.cellNumberLabel.AutoSize = true;
            this.cellNumberLabel.Location = new System.Drawing.Point(12, 69);
            this.cellNumberLabel.Name = "cellNumberLabel";
            this.cellNumberLabel.Size = new System.Drawing.Size(85, 17);
            this.cellNumberLabel.TabIndex = 13;
            this.cellNumberLabel.Text = "CellNumber:";
            this.cellNumberLabel.Visible = false;
            // 
            // sectorIdLabel
            // 
            this.sectorIdLabel.AutoSize = true;
            this.sectorIdLabel.Location = new System.Drawing.Point(12, 103);
            this.sectorIdLabel.Name = "sectorIdLabel";
            this.sectorIdLabel.Size = new System.Drawing.Size(64, 17);
            this.sectorIdLabel.TabIndex = 14;
            this.sectorIdLabel.Text = "SectorId:";
            this.sectorIdLabel.Visible = false;
            // 
            // SectorIdComboBox
            // 
            this.SectorIdComboBox.DataSource = this.sectorsBindingSource;
            this.SectorIdComboBox.DisplayMember = "Id";
            this.SectorIdComboBox.FormattingEnabled = true;
            this.SectorIdComboBox.Location = new System.Drawing.Point(102, 103);
            this.SectorIdComboBox.Name = "SectorIdComboBox";
            this.SectorIdComboBox.Size = new System.Drawing.Size(195, 24);
            this.SectorIdComboBox.TabIndex = 15;
            this.SectorIdComboBox.ValueMember = "Id";
            this.SectorIdComboBox.Visible = false;
            // 
            // sectorsBindingSource
            // 
            this.sectorsBindingSource.DataMember = "Sectors";
            this.sectorsBindingSource.DataSource = this.jailDataSet;
            // 
            // sectorsTableAdapter
            // 
            this.sectorsTableAdapter.ClearBeforeFill = true;
            // 
            // frmCellsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.SectorIdComboBox);
            this.Controls.Add(this.sectorIdLabel);
            this.Controls.Add(this.cellNumberLabel);
            this.Controls.Add(this.cellNumberTextBox);
            this.Controls.Add(this.oneParamTextBox);
            this.Controls.Add(this.oneParamLabel);
            this.Controls.Add(this.ExcelExport);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.moreParam);
            this.Controls.Add(this.oneParam);
            this.Controls.Add(this.cellsDataGridView);
            this.Controls.Add(this.cellsBindingNavigator);
            this.Name = "frmCellsReport";
            this.Text = "frmCellsReport";
            this.Load += new System.EventHandler(this.frmCellsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingNavigator)).EndInit();
            this.cellsBindingNavigator.ResumeLayout(false);
            this.cellsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cellsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JailDataSet jailDataSet;
        private System.Windows.Forms.BindingSource cellsBindingSource;
        private JailDataSetTableAdapters.CellsTableAdapter cellsTableAdapter;
        private JailDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cellsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView cellsDataGridView;
        private System.Windows.Forms.Button oneParam;
        private System.Windows.Forms.Button moreParam;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button ExcelExport;
        private System.Windows.Forms.Label oneParamLabel;
        private System.Windows.Forms.TextBox oneParamTextBox;
        private System.Windows.Forms.TextBox cellNumberTextBox;
        private System.Windows.Forms.Label cellNumberLabel;
        private System.Windows.Forms.Label sectorIdLabel;
        private System.Windows.Forms.ComboBox SectorIdComboBox;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private JailDataSetTableAdapters.SectorsTableAdapter sectorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource sectorsBindingSource1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}