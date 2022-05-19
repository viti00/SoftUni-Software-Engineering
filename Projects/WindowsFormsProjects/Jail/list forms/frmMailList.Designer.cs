
namespace Jail
{
    partial class frmMailList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMailList));
            this.jailDataSet = new Jail.JailDataSet();
            this.mailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mailsTableAdapter = new Jail.JailDataSetTableAdapters.MailsTableAdapter();
            this.tableAdapterManager = new Jail.JailDataSetTableAdapters.TableAdapterManager();
            this.mailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.prisonersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.saveMail = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.prisonersTableAdapter = new Jail.JailDataSetTableAdapters.PrisonersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingNavigator)).BeginInit();
            this.mailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // jailDataSet
            // 
            this.jailDataSet.DataSetName = "JailDataSet";
            this.jailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mailsBindingSource
            // 
            this.mailsBindingSource.DataMember = "Mails";
            this.mailsBindingSource.DataSource = this.jailDataSet;
            // 
            // mailsTableAdapter
            // 
            this.mailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CellsTableAdapter = null;
            this.tableAdapterManager.IsolatorTableAdapter = null;
            this.tableAdapterManager.MailsTableAdapter = this.mailsTableAdapter;
            this.tableAdapterManager.OfficersTableAdapter = null;
            this.tableAdapterManager.PrisonersTableAdapter = null;
            this.tableAdapterManager.SectorsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Jail.JailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mailsBindingNavigator
            // 
            this.mailsBindingNavigator.AddNewItem = null;
            this.mailsBindingNavigator.BindingSource = this.mailsBindingSource;
            this.mailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mailsBindingNavigator.DeleteItem = null;
            this.mailsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.mailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mailsBindingNavigator.Name = "mailsBindingNavigator";
            this.mailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mailsBindingNavigator.Size = new System.Drawing.Size(1334, 31);
            this.mailsBindingNavigator.TabIndex = 0;
            this.mailsBindingNavigator.Text = "bindingNavigator1";
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
            // mailsDataGridView
            // 
            this.mailsDataGridView.AutoGenerateColumns = false;
            this.mailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Delete});
            this.mailsDataGridView.DataSource = this.mailsBindingSource;
            this.mailsDataGridView.Location = new System.Drawing.Point(0, 30);
            this.mailsDataGridView.Name = "mailsDataGridView";
            this.mailsDataGridView.RowHeadersWidth = 51;
            this.mailsDataGridView.RowTemplate.Height = 24;
            this.mailsDataGridView.Size = new System.Drawing.Size(1334, 308);
            this.mailsDataGridView.TabIndex = 1;
            this.mailsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mailsDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sender";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sender";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrisonerId";
            this.dataGridViewTextBoxColumn4.DataSource = this.prisonersBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "PrisonerId";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Id";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // prisonersBindingSource
            // 
            this.prisonersBindingSource.DataMember = "Prisoners";
            this.prisonersBindingSource.DataSource = this.jailDataSet;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // saveMail
            // 
            this.saveMail.Location = new System.Drawing.Point(538, 378);
            this.saveMail.Name = "saveMail";
            this.saveMail.Size = new System.Drawing.Size(109, 45);
            this.saveMail.TabIndex = 2;
            this.saveMail.Text = "Save";
            this.saveMail.UseVisualStyleBackColor = true;
            this.saveMail.Click += new System.EventHandler(this.saveMail_Click);
            // 
            // Export
            // 
            this.Export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Export.BackgroundImage")));
            this.Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Export.Location = new System.Drawing.Point(691, 378);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(49, 45);
            this.Export.TabIndex = 5;
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // prisonersTableAdapter
            // 
            this.prisonersTableAdapter.ClearBeforeFill = true;
            // 
            // frmMailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.saveMail);
            this.Controls.Add(this.mailsDataGridView);
            this.Controls.Add(this.mailsBindingNavigator);
            this.Name = "frmMailList";
            this.Text = "frmMailList";
            this.Load += new System.EventHandler(this.frmMailList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingNavigator)).EndInit();
            this.mailsBindingNavigator.ResumeLayout(false);
            this.mailsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JailDataSet jailDataSet;
        private System.Windows.Forms.BindingSource mailsBindingSource;
        private JailDataSetTableAdapters.MailsTableAdapter mailsTableAdapter;
        private JailDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mailsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView mailsDataGridView;
        private System.Windows.Forms.Button saveMail;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.BindingSource prisonersBindingSource;
        private JailDataSetTableAdapters.PrisonersTableAdapter prisonersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}