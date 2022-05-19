
namespace Jail
{
    partial class frmMails
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label senderLabel;
            System.Windows.Forms.Label prisonerIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMails));
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
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.senderTextBox = new System.Windows.Forms.TextBox();
            this.prisonerIdTextBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.prisonerIdComboBox = new System.Windows.Forms.ComboBox();
            this.prisonersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prisonersTableAdapter = new Jail.JailDataSetTableAdapters.PrisonersTableAdapter();
            descriptionLabel = new System.Windows.Forms.Label();
            senderLabel = new System.Windows.Forms.Label();
            prisonerIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingNavigator)).BeginInit();
            this.mailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(112, 142);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // senderLabel
            // 
            senderLabel.AutoSize = true;
            senderLabel.Location = new System.Drawing.Point(112, 230);
            senderLabel.Name = "senderLabel";
            senderLabel.Size = new System.Drawing.Size(58, 17);
            senderLabel.TabIndex = 3;
            senderLabel.Text = "Sender:";
            // 
            // prisonerIdLabel
            // 
            prisonerIdLabel.AutoSize = true;
            prisonerIdLabel.Location = new System.Drawing.Point(112, 270);
            prisonerIdLabel.Name = "prisonerIdLabel";
            prisonerIdLabel.Size = new System.Drawing.Size(80, 17);
            prisonerIdLabel.TabIndex = 5;
            prisonerIdLabel.Text = "Prisoner Id:";
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
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mailsBindingSource, "Description", true));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(201, 139);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(195, 69);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // senderTextBox
            // 
            this.senderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mailsBindingSource, "Sender", true));
            this.senderTextBox.Enabled = false;
            this.senderTextBox.Location = new System.Drawing.Point(201, 227);
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.Size = new System.Drawing.Size(195, 22);
            this.senderTextBox.TabIndex = 4;
            // 
            // prisonerIdTextBox
            // 
            this.prisonerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mailsBindingSource, "PrisonerId", true));
            this.prisonerIdTextBox.Enabled = false;
            this.prisonerIdTextBox.Location = new System.Drawing.Point(201, 267);
            this.prisonerIdTextBox.Name = "prisonerIdTextBox";
            this.prisonerIdTextBox.Size = new System.Drawing.Size(195, 22);
            this.prisonerIdTextBox.TabIndex = 6;
            // 
            // Add
            // 
            this.Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add.BackgroundImage")));
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add.Location = new System.Drawing.Point(310, 317);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 47);
            this.Add.TabIndex = 7;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Visible = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(201, 317);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(86, 47);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(201, 317);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(86, 47);
            this.Create.TabIndex = 9;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(310, 317);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(86, 47);
            this.Edit.TabIndex = 10;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // prisonerIdComboBox
            // 
            this.prisonerIdComboBox.DataSource = this.prisonersBindingSource;
            this.prisonerIdComboBox.DisplayMember = "Id";
            this.prisonerIdComboBox.Enabled = false;
            this.prisonerIdComboBox.FormattingEnabled = true;
            this.prisonerIdComboBox.Location = new System.Drawing.Point(201, 267);
            this.prisonerIdComboBox.Name = "prisonerIdComboBox";
            this.prisonerIdComboBox.Size = new System.Drawing.Size(195, 24);
            this.prisonerIdComboBox.TabIndex = 11;
            this.prisonerIdComboBox.ValueMember = "Id";
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
            // frmMails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.prisonerIdComboBox);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(senderLabel);
            this.Controls.Add(this.senderTextBox);
            this.Controls.Add(prisonerIdLabel);
            this.Controls.Add(this.prisonerIdTextBox);
            this.Controls.Add(this.mailsBindingNavigator);
            this.DoubleBuffered = true;
            this.Name = "frmMails";
            this.Text = "frmMails";
            this.Load += new System.EventHandler(this.frmMails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingNavigator)).EndInit();
            this.mailsBindingNavigator.ResumeLayout(false);
            this.mailsBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox senderTextBox;
        private System.Windows.Forms.TextBox prisonerIdTextBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ComboBox prisonerIdComboBox;
        private System.Windows.Forms.BindingSource prisonersBindingSource;
        private JailDataSetTableAdapters.PrisonersTableAdapter prisonersTableAdapter;
    }
}