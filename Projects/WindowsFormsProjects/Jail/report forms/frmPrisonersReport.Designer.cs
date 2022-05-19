
namespace Jail.report_forms
{
    partial class frmPrisonersReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrisonersReport));
            this.ExcelExport = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.moreParam = new System.Windows.Forms.Button();
            this.oneParam = new System.Windows.Forms.Button();
            this.oneParamTextBox = new System.Windows.Forms.TextBox();
            this.oneParamLabel = new System.Windows.Forms.Label();
            this.jailDataSet = new Jail.JailDataSet();
            this.prisonersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prisonersTableAdapter = new Jail.JailDataSetTableAdapters.PrisonersTableAdapter();
            this.tableAdapterManager = new Jail.JailDataSetTableAdapters.TableAdapterManager();
            this.cellsTableAdapter = new Jail.JailDataSetTableAdapters.CellsTableAdapter();
            this.prisonersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.prisonersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cellsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.prisonerNumber = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.cellId = new System.Windows.Forms.Label();
            this.prisonerNumberTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.cellIdComboBox = new System.Windows.Forms.ComboBox();
            this.cellsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingNavigator)).BeginInit();
            this.prisonersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExcelExport
            // 
            this.ExcelExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExcelExport.BackgroundImage")));
            this.ExcelExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExcelExport.Location = new System.Drawing.Point(554, 131);
            this.ExcelExport.Name = "ExcelExport";
            this.ExcelExport.Size = new System.Drawing.Size(49, 45);
            this.ExcelExport.TabIndex = 13;
            this.ExcelExport.UseVisualStyleBackColor = true;
            this.ExcelExport.Click += new System.EventHandler(this.ExcelExport_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(525, 54);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(109, 52);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(379, 134);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 52);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(379, 54);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(109, 52);
            this.Search.TabIndex = 14;
            this.Search.Text = "Search";
            this.Search.Visible = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // moreParam
            // 
            this.moreParam.Location = new System.Drawing.Point(379, 134);
            this.moreParam.Name = "moreParam";
            this.moreParam.Size = new System.Drawing.Size(109, 52);
            this.moreParam.TabIndex = 10;
            this.moreParam.Text = "Search by more params";
            this.moreParam.UseVisualStyleBackColor = true;
            this.moreParam.Click += new System.EventHandler(this.moreParam_Click);
            // 
            // oneParam
            // 
            this.oneParam.Location = new System.Drawing.Point(379, 54);
            this.oneParam.Name = "oneParam";
            this.oneParam.Size = new System.Drawing.Size(109, 52);
            this.oneParam.TabIndex = 9;
            this.oneParam.Text = "Search by one param";
            this.oneParam.UseVisualStyleBackColor = true;
            this.oneParam.Click += new System.EventHandler(this.oneParam_Click);
            // 
            // oneParamTextBox
            // 
            this.oneParamTextBox.Location = new System.Drawing.Point(131, 54);
            this.oneParamTextBox.Name = "oneParamTextBox";
            this.oneParamTextBox.Size = new System.Drawing.Size(195, 22);
            this.oneParamTextBox.TabIndex = 16;
            this.oneParamTextBox.Visible = false;
            // 
            // oneParamLabel
            // 
            this.oneParamLabel.AutoSize = true;
            this.oneParamLabel.Location = new System.Drawing.Point(12, 54);
            this.oneParamLabel.Name = "oneParamLabel";
            this.oneParamLabel.Size = new System.Drawing.Size(84, 17);
            this.oneParamLabel.TabIndex = 15;
            this.oneParamLabel.Text = "Enter value:";
            this.oneParamLabel.Visible = false;
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
            this.tableAdapterManager.CellsTableAdapter = this.cellsTableAdapter;
            this.tableAdapterManager.IsolatorTableAdapter = null;
            this.tableAdapterManager.MailsTableAdapter = null;
            this.tableAdapterManager.OfficersTableAdapter = null;
            this.tableAdapterManager.PrisonersTableAdapter = this.prisonersTableAdapter;
            this.tableAdapterManager.SectorsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Jail.JailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cellsTableAdapter
            // 
            this.cellsTableAdapter.ClearBeforeFill = true;
            // 
            // prisonersBindingNavigator
            // 
            this.prisonersBindingNavigator.AddNewItem = null;
            this.prisonersBindingNavigator.BindingSource = this.prisonersBindingSource;
            this.prisonersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prisonersBindingNavigator.DeleteItem = null;
            this.prisonersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.prisonersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.prisonersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.prisonersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prisonersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prisonersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prisonersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prisonersBindingNavigator.Name = "prisonersBindingNavigator";
            this.prisonersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prisonersBindingNavigator.Size = new System.Drawing.Size(1334, 27);
            this.prisonersBindingNavigator.TabIndex = 17;
            this.prisonersBindingNavigator.Text = "bindingNavigator1";
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
            this.dataGridViewTextBoxColumn6,
            this.Delete});
            this.prisonersDataGridView.DataSource = this.prisonersBindingSource;
            this.prisonersDataGridView.Location = new System.Drawing.Point(0, 224);
            this.prisonersDataGridView.Name = "prisonersDataGridView";
            this.prisonersDataGridView.RowHeadersWidth = 51;
            this.prisonersDataGridView.RowTemplate.Height = 24;
            this.prisonersDataGridView.Size = new System.Drawing.Size(1334, 308);
            this.prisonersDataGridView.TabIndex = 17;
            this.prisonersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prisonersDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn6.DataSource = this.cellsBindingSource1;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "CellId";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "Id";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // cellsBindingSource1
            // 
            this.cellsBindingSource1.DataMember = "Cells";
            this.cellsBindingSource1.DataSource = this.jailDataSet;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(12, 54);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(71, 17);
            this.fullNameLabel.TabIndex = 18;
            this.fullNameLabel.Text = "FullName:";
            this.fullNameLabel.Visible = false;
            // 
            // prisonerNumber
            // 
            this.prisonerNumber.AutoSize = true;
            this.prisonerNumber.Location = new System.Drawing.Point(12, 89);
            this.prisonerNumber.Name = "prisonerNumber";
            this.prisonerNumber.Size = new System.Drawing.Size(115, 17);
            this.prisonerNumber.TabIndex = 19;
            this.prisonerNumber.Text = "PrisonerNumber:";
            this.prisonerNumber.Visible = false;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(12, 122);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(37, 17);
            this.age.TabIndex = 20;
            this.age.Text = "Age:";
            this.age.Visible = false;
            // 
            // cellId
            // 
            this.cellId.AutoSize = true;
            this.cellId.Location = new System.Drawing.Point(12, 152);
            this.cellId.Name = "cellId";
            this.cellId.Size = new System.Drawing.Size(50, 17);
            this.cellId.TabIndex = 22;
            this.cellId.Text = "Cell Id:";
            this.cellId.Visible = false;
            // 
            // prisonerNumberTextBox
            // 
            this.prisonerNumberTextBox.Location = new System.Drawing.Point(131, 89);
            this.prisonerNumberTextBox.Name = "prisonerNumberTextBox";
            this.prisonerNumberTextBox.Size = new System.Drawing.Size(195, 22);
            this.prisonerNumberTextBox.TabIndex = 23;
            this.prisonerNumberTextBox.Visible = false;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(131, 54);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(195, 22);
            this.fullNameTextBox.TabIndex = 24;
            this.fullNameTextBox.Visible = false;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(129, 119);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(195, 22);
            this.ageTextBox.TabIndex = 25;
            this.ageTextBox.Visible = false;
            // 
            // cellIdComboBox
            // 
            this.cellIdComboBox.DataSource = this.cellsBindingSource;
            this.cellIdComboBox.DisplayMember = "Id";
            this.cellIdComboBox.FormattingEnabled = true;
            this.cellIdComboBox.Location = new System.Drawing.Point(129, 152);
            this.cellIdComboBox.Name = "cellIdComboBox";
            this.cellIdComboBox.Size = new System.Drawing.Size(195, 24);
            this.cellIdComboBox.TabIndex = 29;
            this.cellIdComboBox.ValueMember = "Id";
            this.cellIdComboBox.Visible = false;
            // 
            // cellsBindingSource
            // 
            this.cellsBindingSource.DataMember = "Cells";
            this.cellsBindingSource.DataSource = this.jailDataSet;
            // 
            // frmPrisonersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.cellIdComboBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.prisonerNumberTextBox);
            this.Controls.Add(this.cellId);
            this.Controls.Add(this.age);
            this.Controls.Add(this.prisonerNumber);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.prisonersDataGridView);
            this.Controls.Add(this.prisonersBindingNavigator);
            this.Controls.Add(this.oneParamTextBox);
            this.Controls.Add(this.oneParamLabel);
            this.Controls.Add(this.ExcelExport);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.moreParam);
            this.Controls.Add(this.oneParam);
            this.Name = "frmPrisonersReport";
            this.Text = "frmPrisonersReport";
            this.Load += new System.EventHandler(this.frmPrisonersReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingNavigator)).EndInit();
            this.prisonersBindingNavigator.ResumeLayout(false);
            this.prisonersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExcelExport;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button moreParam;
        private System.Windows.Forms.Button oneParam;
        private System.Windows.Forms.TextBox oneParamTextBox;
        private System.Windows.Forms.Label oneParamLabel;
        private JailDataSet jailDataSet;
        private System.Windows.Forms.BindingSource prisonersBindingSource;
        private JailDataSetTableAdapters.PrisonersTableAdapter prisonersTableAdapter;
        private JailDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prisonersBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView prisonersDataGridView;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label prisonerNumber;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label cellId;
        private System.Windows.Forms.TextBox prisonerNumberTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private JailDataSetTableAdapters.CellsTableAdapter cellsTableAdapter;
        private System.Windows.Forms.ComboBox cellIdComboBox;
        private System.Windows.Forms.BindingSource cellsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource cellsBindingSource1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}