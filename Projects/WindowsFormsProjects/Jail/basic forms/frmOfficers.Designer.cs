
namespace Jail
{
    partial class frmOfficers
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
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label weaponLabel;
            System.Windows.Forms.Label sectorIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOfficers));
            this.jailDataSet = new Jail.JailDataSet();
            this.officersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officersTableAdapter = new Jail.JailDataSetTableAdapters.OfficersTableAdapter();
            this.tableAdapterManager = new Jail.JailDataSetTableAdapters.TableAdapterManager();
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
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.weaponTextBox = new System.Windows.Forms.TextBox();
            this.sectorIdTextBox = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.sectorIdComboBox = new System.Windows.Forms.ComboBox();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectorsTableAdapter = new Jail.JailDataSetTableAdapters.SectorsTableAdapter();
            fullNameLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            weaponLabel = new System.Windows.Forms.Label();
            sectorIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingNavigator)).BeginInit();
            this.officersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(179, 157);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(75, 17);
            fullNameLabel.TabIndex = 1;
            fullNameLabel.Text = "Full Name:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(179, 196);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(52, 17);
            salaryLabel.TabIndex = 3;
            salaryLabel.Text = "Salary:";
            // 
            // weaponLabel
            // 
            weaponLabel.AutoSize = true;
            weaponLabel.Location = new System.Drawing.Point(179, 234);
            weaponLabel.Name = "weaponLabel";
            weaponLabel.Size = new System.Drawing.Size(65, 17);
            weaponLabel.TabIndex = 5;
            weaponLabel.Text = "Weapon:";
            // 
            // sectorIdLabel
            // 
            sectorIdLabel.AutoSize = true;
            sectorIdLabel.Location = new System.Drawing.Point(179, 274);
            sectorIdLabel.Name = "sectorIdLabel";
            sectorIdLabel.Size = new System.Drawing.Size(68, 17);
            sectorIdLabel.TabIndex = 7;
            sectorIdLabel.Text = "Sector Id:";
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
            this.tableAdapterManager.SectorsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Jail.JailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.officersBindingSource, "FullName", true));
            this.fullNameTextBox.Enabled = false;
            this.fullNameTextBox.Location = new System.Drawing.Point(260, 154);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(195, 22);
            this.fullNameTextBox.TabIndex = 2;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.officersBindingSource, "Salary", true));
            this.salaryTextBox.Enabled = false;
            this.salaryTextBox.Location = new System.Drawing.Point(260, 193);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(195, 22);
            this.salaryTextBox.TabIndex = 4;
            this.salaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // weaponTextBox
            // 
            this.weaponTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.officersBindingSource, "Weapon", true));
            this.weaponTextBox.Enabled = false;
            this.weaponTextBox.Location = new System.Drawing.Point(260, 231);
            this.weaponTextBox.Name = "weaponTextBox";
            this.weaponTextBox.Size = new System.Drawing.Size(195, 22);
            this.weaponTextBox.TabIndex = 6;
            // 
            // sectorIdTextBox
            // 
            this.sectorIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.officersBindingSource, "SectorId", true));
            this.sectorIdTextBox.Enabled = false;
            this.sectorIdTextBox.Location = new System.Drawing.Point(260, 271);
            this.sectorIdTextBox.Name = "sectorIdTextBox";
            this.sectorIdTextBox.Size = new System.Drawing.Size(195, 22);
            this.sectorIdTextBox.TabIndex = 8;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(260, 327);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(86, 47);
            this.Create.TabIndex = 9;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(260, 327);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(86, 47);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add
            // 
            this.Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add.BackgroundImage")));
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add.Location = new System.Drawing.Point(369, 327);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 47);
            this.Add.TabIndex = 11;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Visible = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(369, 327);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(86, 47);
            this.Edit.TabIndex = 12;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // sectorIdComboBox
            // 
            this.sectorIdComboBox.DataSource = this.sectorsBindingSource;
            this.sectorIdComboBox.DisplayMember = "Id";
            this.sectorIdComboBox.Enabled = false;
            this.sectorIdComboBox.FormattingEnabled = true;
            this.sectorIdComboBox.Location = new System.Drawing.Point(260, 269);
            this.sectorIdComboBox.Name = "sectorIdComboBox";
            this.sectorIdComboBox.Size = new System.Drawing.Size(195, 24);
            this.sectorIdComboBox.TabIndex = 13;
            this.sectorIdComboBox.ValueMember = "Id";
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
            // frmOfficers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.sectorIdComboBox);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Create);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(weaponLabel);
            this.Controls.Add(this.weaponTextBox);
            this.Controls.Add(sectorIdLabel);
            this.Controls.Add(this.sectorIdTextBox);
            this.Controls.Add(this.officersBindingNavigator);
            this.DoubleBuffered = true;
            this.Name = "frmOfficers";
            this.Text = "frmOfficers";
            this.Load += new System.EventHandler(this.frmOfficers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersBindingNavigator)).EndInit();
            this.officersBindingNavigator.ResumeLayout(false);
            this.officersBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox weaponTextBox;
        private System.Windows.Forms.TextBox sectorIdTextBox;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ComboBox sectorIdComboBox;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private JailDataSetTableAdapters.SectorsTableAdapter sectorsTableAdapter;
    }
}