﻿
namespace Jail.report_forms
{
    partial class frmMailsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMailsReport));
            this.jailDataSet = new Jail.JailDataSet();
            this.mailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mailsTableAdapter = new Jail.JailDataSetTableAdapters.MailsTableAdapter();
            this.tableAdapterManager = new Jail.JailDataSetTableAdapters.TableAdapterManager();
            this.prisonersTableAdapter = new Jail.JailDataSetTableAdapters.PrisonersTableAdapter();
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
            this.prisonersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ExcelExport = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.moreParam = new System.Windows.Forms.Button();
            this.oneParam = new System.Windows.Forms.Button();
            this.oneParamTextBox = new System.Windows.Forms.TextBox();
            this.oneParamLabel = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Sender = new System.Windows.Forms.Label();
            this.PrisonerId = new System.Windows.Forms.Label();
            this.DescrtiptionTextBox = new System.Windows.Forms.TextBox();
            this.SenderTextBox = new System.Windows.Forms.TextBox();
            this.prisonerIdComboBox = new System.Windows.Forms.ComboBox();
            this.prisonersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingNavigator)).BeginInit();
            this.mailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource1)).BeginInit();
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
            this.tableAdapterManager.PrisonersTableAdapter = this.prisonersTableAdapter;
            this.tableAdapterManager.SectorsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Jail.JailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // prisonersTableAdapter
            // 
            this.prisonersTableAdapter.ClearBeforeFill = true;
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
            this.mailsBindingNavigator.Size = new System.Drawing.Size(1334, 27);
            this.mailsBindingNavigator.TabIndex = 0;
            this.mailsBindingNavigator.Text = "bindingNavigator1";
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
            this.mailsDataGridView.Location = new System.Drawing.Point(0, 244);
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
            this.dataGridViewTextBoxColumn4.DataSource = this.prisonersBindingSource1;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "PrisonerId";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Id";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // prisonersBindingSource1
            // 
            this.prisonersBindingSource1.DataMember = "Prisoners";
            this.prisonersBindingSource1.DataSource = this.jailDataSet;
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
            this.ExcelExport.Location = new System.Drawing.Point(576, 141);
            this.ExcelExport.Name = "ExcelExport";
            this.ExcelExport.Size = new System.Drawing.Size(49, 45);
            this.ExcelExport.TabIndex = 19;
            this.ExcelExport.UseVisualStyleBackColor = true;
            this.ExcelExport.Click += new System.EventHandler(this.ExcelExport_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(547, 61);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(109, 52);
            this.Save.TabIndex = 18;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(401, 141);
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
            this.Search.Location = new System.Drawing.Point(401, 61);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(109, 52);
            this.Search.TabIndex = 20;
            this.Search.Text = "Search";
            this.Search.Visible = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // moreParam
            // 
            this.moreParam.Location = new System.Drawing.Point(401, 141);
            this.moreParam.Name = "moreParam";
            this.moreParam.Size = new System.Drawing.Size(109, 52);
            this.moreParam.TabIndex = 16;
            this.moreParam.Text = "Search by more params";
            this.moreParam.UseVisualStyleBackColor = true;
            this.moreParam.Click += new System.EventHandler(this.moreParam_Click);
            // 
            // oneParam
            // 
            this.oneParam.Location = new System.Drawing.Point(401, 61);
            this.oneParam.Name = "oneParam";
            this.oneParam.Size = new System.Drawing.Size(109, 52);
            this.oneParam.TabIndex = 15;
            this.oneParam.Text = "Search by one param";
            this.oneParam.UseVisualStyleBackColor = true;
            this.oneParam.Click += new System.EventHandler(this.oneParam_Click);
            // 
            // oneParamTextBox
            // 
            this.oneParamTextBox.Location = new System.Drawing.Point(130, 58);
            this.oneParamTextBox.Name = "oneParamTextBox";
            this.oneParamTextBox.Size = new System.Drawing.Size(195, 22);
            this.oneParamTextBox.TabIndex = 22;
            this.oneParamTextBox.Visible = false;
            // 
            // oneParamLabel
            // 
            this.oneParamLabel.AutoSize = true;
            this.oneParamLabel.Location = new System.Drawing.Point(11, 58);
            this.oneParamLabel.Name = "oneParamLabel";
            this.oneParamLabel.Size = new System.Drawing.Size(84, 17);
            this.oneParamLabel.TabIndex = 21;
            this.oneParamLabel.Text = "Enter value:";
            this.oneParamLabel.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(12, 61);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(83, 17);
            this.Description.TabIndex = 23;
            this.Description.Text = "Description:";
            this.Description.Visible = false;
            // 
            // Sender
            // 
            this.Sender.AutoSize = true;
            this.Sender.Location = new System.Drawing.Point(12, 138);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(58, 17);
            this.Sender.TabIndex = 24;
            this.Sender.Text = "Sender:";
            this.Sender.Visible = false;
            // 
            // PrisonerId
            // 
            this.PrisonerId.AutoSize = true;
            this.PrisonerId.Location = new System.Drawing.Point(11, 183);
            this.PrisonerId.Name = "PrisonerId";
            this.PrisonerId.Size = new System.Drawing.Size(76, 17);
            this.PrisonerId.TabIndex = 25;
            this.PrisonerId.Text = "PrisonerId:";
            this.PrisonerId.Visible = false;
            // 
            // DescrtiptionTextBox
            // 
            this.DescrtiptionTextBox.Location = new System.Drawing.Point(130, 58);
            this.DescrtiptionTextBox.Multiline = true;
            this.DescrtiptionTextBox.Name = "DescrtiptionTextBox";
            this.DescrtiptionTextBox.Size = new System.Drawing.Size(195, 59);
            this.DescrtiptionTextBox.TabIndex = 26;
            this.DescrtiptionTextBox.Visible = false;
            // 
            // SenderTextBox
            // 
            this.SenderTextBox.Location = new System.Drawing.Point(130, 138);
            this.SenderTextBox.Name = "SenderTextBox";
            this.SenderTextBox.Size = new System.Drawing.Size(195, 22);
            this.SenderTextBox.TabIndex = 27;
            this.SenderTextBox.Visible = false;
            // 
            // prisonerIdComboBox
            // 
            this.prisonerIdComboBox.DataSource = this.prisonersBindingSource;
            this.prisonerIdComboBox.DisplayMember = "Id";
            this.prisonerIdComboBox.FormattingEnabled = true;
            this.prisonerIdComboBox.Location = new System.Drawing.Point(130, 180);
            this.prisonerIdComboBox.Name = "prisonerIdComboBox";
            this.prisonerIdComboBox.Size = new System.Drawing.Size(195, 24);
            this.prisonerIdComboBox.TabIndex = 28;
            this.prisonerIdComboBox.ValueMember = "Id";
            this.prisonerIdComboBox.Visible = false;
            // 
            // prisonersBindingSource
            // 
            this.prisonersBindingSource.DataMember = "Prisoners";
            this.prisonersBindingSource.DataSource = this.jailDataSet;
            // 
            // frmMailsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.prisonerIdComboBox);
            this.Controls.Add(this.SenderTextBox);
            this.Controls.Add(this.DescrtiptionTextBox);
            this.Controls.Add(this.PrisonerId);
            this.Controls.Add(this.Sender);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.oneParamTextBox);
            this.Controls.Add(this.oneParamLabel);
            this.Controls.Add(this.ExcelExport);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.moreParam);
            this.Controls.Add(this.oneParam);
            this.Controls.Add(this.mailsDataGridView);
            this.Controls.Add(this.mailsBindingNavigator);
            this.Name = "frmMailsReport";
            this.Text = "frmMailsReport";
            this.Load += new System.EventHandler(this.frmMailsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingNavigator)).EndInit();
            this.mailsBindingNavigator.ResumeLayout(false);
            this.mailsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource1)).EndInit();
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
        private System.Windows.Forms.Button ExcelExport;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button moreParam;
        private System.Windows.Forms.Button oneParam;
        private System.Windows.Forms.TextBox oneParamTextBox;
        private System.Windows.Forms.Label oneParamLabel;
        private JailDataSetTableAdapters.PrisonersTableAdapter prisonersTableAdapter;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Sender;
        private System.Windows.Forms.Label PrisonerId;
        private System.Windows.Forms.TextBox DescrtiptionTextBox;
        private System.Windows.Forms.TextBox SenderTextBox;
        private System.Windows.Forms.ComboBox prisonerIdComboBox;
        private System.Windows.Forms.BindingSource prisonersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource prisonersBindingSource1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}