
namespace Jail.master_details_forms
{
    partial class frmPrisonersMails
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
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label prisonerNumberLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label releaseDateLabel;
            System.Windows.Forms.Label cellIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrisonersMails));
            this.jailDataSet = new Jail.JailDataSet();
            this.prisonersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prisonersTableAdapter = new Jail.JailDataSetTableAdapters.PrisonersTableAdapter();
            this.tableAdapterManager = new Jail.JailDataSetTableAdapters.TableAdapterManager();
            this.mailsTableAdapter = new Jail.JailDataSetTableAdapters.MailsTableAdapter();
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
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.prisonerNumberTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cellIdTextBox = new System.Windows.Forms.TextBox();
            this.mailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Export = new System.Windows.Forms.Button();
            fullNameLabel = new System.Windows.Forms.Label();
            prisonerNumberLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            cellIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingNavigator)).BeginInit();
            this.prisonersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(82, 58);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(75, 17);
            fullNameLabel.TabIndex = 1;
            fullNameLabel.Text = "Full Name:";
            // 
            // prisonerNumberLabel
            // 
            prisonerNumberLabel.AutoSize = true;
            prisonerNumberLabel.Location = new System.Drawing.Point(82, 95);
            prisonerNumberLabel.Name = "prisonerNumberLabel";
            prisonerNumberLabel.Size = new System.Drawing.Size(119, 17);
            prisonerNumberLabel.TabIndex = 3;
            prisonerNumberLabel.Text = "Prisoner Number:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(82, 134);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(37, 17);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "Age:";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(82, 176);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(98, 17);
            releaseDateLabel.TabIndex = 7;
            releaseDateLabel.Text = "Release Date:";
            // 
            // cellIdLabel
            // 
            cellIdLabel.AutoSize = true;
            cellIdLabel.Location = new System.Drawing.Point(82, 215);
            cellIdLabel.Name = "cellIdLabel";
            cellIdLabel.Size = new System.Drawing.Size(50, 17);
            cellIdLabel.TabIndex = 9;
            cellIdLabel.Text = "Cell Id:";
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
            this.tableAdapterManager.MailsTableAdapter = this.mailsTableAdapter;
            this.tableAdapterManager.OfficersTableAdapter = null;
            this.tableAdapterManager.PrisonersTableAdapter = this.prisonersTableAdapter;
            this.tableAdapterManager.SectorsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Jail.JailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mailsTableAdapter
            // 
            this.mailsTableAdapter.ClearBeforeFill = true;
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
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prisonersBindingSource, "FullName", true));
            this.fullNameTextBox.Enabled = false;
            this.fullNameTextBox.Location = new System.Drawing.Point(207, 53);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(195, 22);
            this.fullNameTextBox.TabIndex = 2;
            // 
            // prisonerNumberTextBox
            // 
            this.prisonerNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prisonersBindingSource, "PrisonerNumber", true));
            this.prisonerNumberTextBox.Enabled = false;
            this.prisonerNumberTextBox.Location = new System.Drawing.Point(207, 92);
            this.prisonerNumberTextBox.Name = "prisonerNumberTextBox";
            this.prisonerNumberTextBox.Size = new System.Drawing.Size(195, 22);
            this.prisonerNumberTextBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prisonersBindingSource, "Age", true));
            this.ageTextBox.Enabled = false;
            this.ageTextBox.Location = new System.Drawing.Point(207, 131);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(195, 22);
            this.ageTextBox.TabIndex = 6;
            // 
            // releaseDateDateTimePicker
            // 
            this.releaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prisonersBindingSource, "ReleaseDate", true));
            this.releaseDateDateTimePicker.Enabled = false;
            this.releaseDateDateTimePicker.Location = new System.Drawing.Point(207, 172);
            this.releaseDateDateTimePicker.Name = "releaseDateDateTimePicker";
            this.releaseDateDateTimePicker.Size = new System.Drawing.Size(195, 22);
            this.releaseDateDateTimePicker.TabIndex = 8;
            // 
            // cellIdTextBox
            // 
            this.cellIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prisonersBindingSource, "CellId", true));
            this.cellIdTextBox.Enabled = false;
            this.cellIdTextBox.Location = new System.Drawing.Point(207, 212);
            this.cellIdTextBox.Name = "cellIdTextBox";
            this.cellIdTextBox.Size = new System.Drawing.Size(195, 22);
            this.cellIdTextBox.TabIndex = 10;
            // 
            // mailsBindingSource
            // 
            this.mailsBindingSource.DataMember = "FK__Mails__PrisonerI__5629CD9C";
            this.mailsBindingSource.DataSource = this.prisonersBindingSource;
            // 
            // mailsDataGridView
            // 
            this.mailsDataGridView.AutoGenerateColumns = false;
            this.mailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.mailsDataGridView.DataSource = this.mailsBindingSource;
            this.mailsDataGridView.Location = new System.Drawing.Point(0, 256);
            this.mailsDataGridView.Name = "mailsDataGridView";
            this.mailsDataGridView.RowHeadersWidth = 51;
            this.mailsDataGridView.RowTemplate.Height = 24;
            this.mailsDataGridView.Size = new System.Drawing.Size(1334, 308);
            this.mailsDataGridView.TabIndex = 11;
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
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sender";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sender";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrisonerId";
            this.dataGridViewTextBoxColumn4.HeaderText = "PrisonerId";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Export
            // 
            this.Export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Export.BackgroundImage")));
            this.Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Export.Location = new System.Drawing.Point(548, 187);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(49, 45);
            this.Export.TabIndex = 12;
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // frmPrisonersMails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.mailsDataGridView);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(prisonerNumberLabel);
            this.Controls.Add(this.prisonerNumberTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(this.releaseDateDateTimePicker);
            this.Controls.Add(cellIdLabel);
            this.Controls.Add(this.cellIdTextBox);
            this.Controls.Add(this.prisonersBindingNavigator);
            this.Name = "frmPrisonersMails";
            this.Text = "frmPrisonersMails";
            this.Load += new System.EventHandler(this.frmPrisonersMails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingNavigator)).EndInit();
            this.prisonersBindingNavigator.ResumeLayout(false);
            this.prisonersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsDataGridView)).EndInit();
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
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox prisonerNumberTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.DateTimePicker releaseDateDateTimePicker;
        private System.Windows.Forms.TextBox cellIdTextBox;
        private JailDataSetTableAdapters.MailsTableAdapter mailsTableAdapter;
        private System.Windows.Forms.BindingSource mailsBindingSource;
        private System.Windows.Forms.DataGridView mailsDataGridView;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}