
namespace Jail.report_forms
{
    partial class frmSectorsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSectorsReport));
            this.sectorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jailDataSet = new Jail.JailDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sectorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.oneParam = new System.Windows.Forms.Button();
            this.moreParam = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.oneParamLabel = new System.Windows.Forms.Label();
            this.oneValueTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.sectorsTableAdapter = new Jail.JailDataSetTableAdapters.SectorsTableAdapter();
            this.tableAdapterManager = new Jail.JailDataSetTableAdapters.TableAdapterManager();
            this.ExcelExport = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingNavigator)).BeginInit();
            this.sectorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sectorsBindingNavigator
            // 
            this.sectorsBindingNavigator.AddNewItem = null;
            this.sectorsBindingNavigator.BindingSource = this.sectorsBindingSource;
            this.sectorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sectorsBindingNavigator.DeleteItem = null;
            this.sectorsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sectorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.sectorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sectorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sectorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sectorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sectorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sectorsBindingNavigator.Name = "sectorsBindingNavigator";
            this.sectorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sectorsBindingNavigator.Size = new System.Drawing.Size(1334, 27);
            this.sectorsBindingNavigator.TabIndex = 0;
            this.sectorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // sectorsBindingSource
            // 
            this.sectorsBindingSource.DataMember = "Sectors";
            this.sectorsBindingSource.DataSource = this.jailDataSet;
            // 
            // jailDataSet
            // 
            this.jailDataSet.DataSetName = "JailDataSet";
            this.jailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sectorsDataGridView
            // 
            this.sectorsDataGridView.AutoGenerateColumns = false;
            this.sectorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Delete});
            this.sectorsDataGridView.DataSource = this.sectorsBindingSource;
            this.sectorsDataGridView.Location = new System.Drawing.Point(0, 216);
            this.sectorsDataGridView.Name = "sectorsDataGridView";
            this.sectorsDataGridView.RowHeadersWidth = 51;
            this.sectorsDataGridView.RowTemplate.Height = 24;
            this.sectorsDataGridView.Size = new System.Drawing.Size(1334, 308);
            this.sectorsDataGridView.TabIndex = 1;
            this.sectorsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sectorsDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
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
            this.oneParam.Location = new System.Drawing.Point(367, 67);
            this.oneParam.Name = "oneParam";
            this.oneParam.Size = new System.Drawing.Size(109, 52);
            this.oneParam.TabIndex = 2;
            this.oneParam.Text = "Search by one param";
            this.oneParam.UseVisualStyleBackColor = true;
            this.oneParam.Click += new System.EventHandler(this.oneParam_Click);
            // 
            // moreParam
            // 
            this.moreParam.Location = new System.Drawing.Point(368, 135);
            this.moreParam.Name = "moreParam";
            this.moreParam.Size = new System.Drawing.Size(109, 52);
            this.moreParam.TabIndex = 3;
            this.moreParam.Text = "Search by more params";
            this.moreParam.UseVisualStyleBackColor = true;
            this.moreParam.Click += new System.EventHandler(this.moreParam_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(368, 67);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(109, 52);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Visible = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(368, 135);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 52);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // oneParamLabel
            // 
            this.oneParamLabel.AutoSize = true;
            this.oneParamLabel.Location = new System.Drawing.Point(19, 69);
            this.oneParamLabel.Name = "oneParamLabel";
            this.oneParamLabel.Size = new System.Drawing.Size(84, 17);
            this.oneParamLabel.TabIndex = 6;
            this.oneParamLabel.Text = "Enter value:";
            this.oneParamLabel.Visible = false;
            // 
            // oneValueTextBox
            // 
            this.oneValueTextBox.Location = new System.Drawing.Point(109, 69);
            this.oneValueTextBox.Name = "oneValueTextBox";
            this.oneValueTextBox.Size = new System.Drawing.Size(195, 22);
            this.oneValueTextBox.TabIndex = 7;
            this.oneValueTextBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(19, 69);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Visible = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(19, 108);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 9;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(109, 69);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(195, 22);
            this.nameTextBox.TabIndex = 10;
            this.nameTextBox.Visible = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(109, 105);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(195, 49);
            this.descriptionTextBox.TabIndex = 11;
            this.descriptionTextBox.Visible = false;
            // 
            // sectorsTableAdapter
            // 
            this.sectorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CellsTableAdapter = null;
            this.tableAdapterManager.IsolatorTableAdapter = null;
            this.tableAdapterManager.MailsTableAdapter = null;
            this.tableAdapterManager.OfficersTableAdapter = null;
            this.tableAdapterManager.PrisonersTableAdapter = null;
            this.tableAdapterManager.SectorsTableAdapter = this.sectorsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Jail.JailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ExcelExport
            // 
            this.ExcelExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExcelExport.BackgroundImage")));
            this.ExcelExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExcelExport.Location = new System.Drawing.Point(533, 135);
            this.ExcelExport.Name = "ExcelExport";
            this.ExcelExport.Size = new System.Drawing.Size(49, 45);
            this.ExcelExport.TabIndex = 13;
            this.ExcelExport.UseVisualStyleBackColor = true;
            this.ExcelExport.Click += new System.EventHandler(this.ExcelExport_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(504, 67);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(109, 52);
            this.Save.TabIndex = 14;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // frmSectorsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ExcelExport);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.oneValueTextBox);
            this.Controls.Add(this.oneParamLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.moreParam);
            this.Controls.Add(this.oneParam);
            this.Controls.Add(this.sectorsDataGridView);
            this.Controls.Add(this.sectorsBindingNavigator);
            this.Name = "frmSectorsReport";
            this.Text = "frmSectorsReport";
            this.Load += new System.EventHandler(this.frmSectorsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingNavigator)).EndInit();
            this.sectorsBindingNavigator.ResumeLayout(false);
            this.sectorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JailDataSet jailDataSet;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private JailDataSetTableAdapters.SectorsTableAdapter sectorsTableAdapter;
        private JailDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sectorsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView sectorsDataGridView;
        private System.Windows.Forms.Button oneParam;
        private System.Windows.Forms.Button moreParam;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label oneParamLabel;
        private System.Windows.Forms.TextBox oneValueTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button ExcelExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button Save;
    }
}