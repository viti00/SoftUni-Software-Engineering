
namespace Jail
{
    partial class frmPrisonersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrisonersList));
            this.jailDataSet = new Jail.JailDataSet();
            this.prisonersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prisonersTableAdapter = new Jail.JailDataSetTableAdapters.PrisonersTableAdapter();
            this.tableAdapterManager = new Jail.JailDataSetTableAdapters.TableAdapterManager();
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
            this.cellsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.savePrisoners = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.cellsTableAdapter = new Jail.JailDataSetTableAdapters.CellsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingNavigator)).BeginInit();
            this.prisonersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.prisonersBindingNavigator.Size = new System.Drawing.Size(1334, 31);
            this.prisonersBindingNavigator.TabIndex = 0;
            this.prisonersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
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
            this.prisonersDataGridView.Location = new System.Drawing.Point(0, 30);
            this.prisonersDataGridView.Name = "prisonersDataGridView";
            this.prisonersDataGridView.RowHeadersWidth = 51;
            this.prisonersDataGridView.RowTemplate.Height = 24;
            this.prisonersDataGridView.Size = new System.Drawing.Size(1334, 308);
            this.prisonersDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn6.DataSource = this.cellsBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "CellId";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "Id";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // cellsBindingSource
            // 
            this.cellsBindingSource.DataMember = "Cells";
            this.cellsBindingSource.DataSource = this.jailDataSet;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // savePrisoners
            // 
            this.savePrisoners.Location = new System.Drawing.Point(564, 379);
            this.savePrisoners.Name = "savePrisoners";
            this.savePrisoners.Size = new System.Drawing.Size(109, 45);
            this.savePrisoners.TabIndex = 2;
            this.savePrisoners.Text = "Save";
            this.savePrisoners.UseVisualStyleBackColor = true;
            this.savePrisoners.Click += new System.EventHandler(this.savePrisoners_Click);
            // 
            // Export
            // 
            this.Export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Export.BackgroundImage")));
            this.Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Export.Location = new System.Drawing.Point(716, 379);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(49, 45);
            this.Export.TabIndex = 4;
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // cellsTableAdapter
            // 
            this.cellsTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrisonersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.savePrisoners);
            this.Controls.Add(this.prisonersDataGridView);
            this.Controls.Add(this.prisonersBindingNavigator);
            this.Name = "frmPrisonersList";
            this.Text = "frmPrisonersList";
            this.Load += new System.EventHandler(this.frmPrisonersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingNavigator)).EndInit();
            this.prisonersBindingNavigator.ResumeLayout(false);
            this.prisonersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button savePrisoners;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.BindingSource cellsBindingSource;
        private JailDataSetTableAdapters.CellsTableAdapter cellsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}