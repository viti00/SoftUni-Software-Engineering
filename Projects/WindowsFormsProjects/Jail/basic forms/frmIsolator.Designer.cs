
namespace Jail
{
    partial class frmIsolator
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
            System.Windows.Forms.Label prisonerIdLabel;
            System.Windows.Forms.Label reasonLabel;
            System.Windows.Forms.Label releaseDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIsolator));
            this.jailDataSet = new Jail.JailDataSet();
            this.isolatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isolatorTableAdapter = new Jail.JailDataSetTableAdapters.IsolatorTableAdapter();
            this.tableAdapterManager = new Jail.JailDataSetTableAdapters.TableAdapterManager();
            this.isolatorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.prisonerIdTextBox = new System.Windows.Forms.TextBox();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.prisonerIdComboBox = new System.Windows.Forms.ComboBox();
            this.prisonersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prisonersTableAdapter = new Jail.JailDataSetTableAdapters.PrisonersTableAdapter();
            prisonerIdLabel = new System.Windows.Forms.Label();
            reasonLabel = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isolatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isolatorBindingNavigator)).BeginInit();
            this.isolatorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prisonerIdLabel
            // 
            prisonerIdLabel.AutoSize = true;
            prisonerIdLabel.Location = new System.Drawing.Point(118, 165);
            prisonerIdLabel.Name = "prisonerIdLabel";
            prisonerIdLabel.Size = new System.Drawing.Size(80, 17);
            prisonerIdLabel.TabIndex = 1;
            prisonerIdLabel.Text = "Prisoner Id:";
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Location = new System.Drawing.Point(118, 206);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new System.Drawing.Size(61, 17);
            reasonLabel.TabIndex = 3;
            reasonLabel.Text = "Reason:";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(118, 294);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(98, 17);
            releaseDateLabel.TabIndex = 5;
            releaseDateLabel.Text = "Release Date:";
            // 
            // jailDataSet
            // 
            this.jailDataSet.DataSetName = "JailDataSet";
            this.jailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // isolatorBindingSource
            // 
            this.isolatorBindingSource.DataMember = "Isolator";
            this.isolatorBindingSource.DataSource = this.jailDataSet;
            // 
            // isolatorTableAdapter
            // 
            this.isolatorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CellsTableAdapter = null;
            this.tableAdapterManager.IsolatorTableAdapter = this.isolatorTableAdapter;
            this.tableAdapterManager.MailsTableAdapter = null;
            this.tableAdapterManager.OfficersTableAdapter = null;
            this.tableAdapterManager.PrisonersTableAdapter = null;
            this.tableAdapterManager.SectorsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Jail.JailDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // isolatorBindingNavigator
            // 
            this.isolatorBindingNavigator.AddNewItem = null;
            this.isolatorBindingNavigator.BindingSource = this.isolatorBindingSource;
            this.isolatorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.isolatorBindingNavigator.DeleteItem = null;
            this.isolatorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.isolatorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.isolatorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.isolatorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.isolatorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.isolatorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.isolatorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.isolatorBindingNavigator.Name = "isolatorBindingNavigator";
            this.isolatorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.isolatorBindingNavigator.Size = new System.Drawing.Size(1334, 27);
            this.isolatorBindingNavigator.TabIndex = 0;
            this.isolatorBindingNavigator.Text = "bindingNavigator1";
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
            // prisonerIdTextBox
            // 
            this.prisonerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.isolatorBindingSource, "PrisonerId", true));
            this.prisonerIdTextBox.Enabled = false;
            this.prisonerIdTextBox.Location = new System.Drawing.Point(222, 162);
            this.prisonerIdTextBox.Name = "prisonerIdTextBox";
            this.prisonerIdTextBox.Size = new System.Drawing.Size(195, 22);
            this.prisonerIdTextBox.TabIndex = 2;
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.isolatorBindingSource, "Reason", true));
            this.reasonTextBox.Enabled = false;
            this.reasonTextBox.Location = new System.Drawing.Point(222, 203);
            this.reasonTextBox.Multiline = true;
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(195, 70);
            this.reasonTextBox.TabIndex = 4;
            // 
            // releaseDateDateTimePicker
            // 
            this.releaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.isolatorBindingSource, "ReleaseDate", true));
            this.releaseDateDateTimePicker.Enabled = false;
            this.releaseDateDateTimePicker.Location = new System.Drawing.Point(222, 290);
            this.releaseDateDateTimePicker.Name = "releaseDateDateTimePicker";
            this.releaseDateDateTimePicker.Size = new System.Drawing.Size(195, 22);
            this.releaseDateDateTimePicker.TabIndex = 6;
            // 
            // Add
            // 
            this.Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add.BackgroundImage")));
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add.Location = new System.Drawing.Point(331, 342);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 47);
            this.Add.TabIndex = 7;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Visible = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(222, 342);
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
            this.Create.Location = new System.Drawing.Point(222, 342);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(86, 47);
            this.Create.TabIndex = 9;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(331, 342);
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
            this.prisonerIdComboBox.Location = new System.Drawing.Point(222, 162);
            this.prisonerIdComboBox.Name = "prisonerIdComboBox";
            this.prisonerIdComboBox.Size = new System.Drawing.Size(195, 24);
            this.prisonerIdComboBox.TabIndex = 12;
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
            // frmIsolator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.prisonerIdComboBox);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(prisonerIdLabel);
            this.Controls.Add(this.prisonerIdTextBox);
            this.Controls.Add(reasonLabel);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(this.releaseDateDateTimePicker);
            this.Controls.Add(this.isolatorBindingNavigator);
            this.Name = "frmIsolator";
            this.Text = "frmIsolator";
            this.Load += new System.EventHandler(this.frmIsolator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isolatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isolatorBindingNavigator)).EndInit();
            this.isolatorBindingNavigator.ResumeLayout(false);
            this.isolatorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prisonersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JailDataSet jailDataSet;
        private System.Windows.Forms.BindingSource isolatorBindingSource;
        private JailDataSetTableAdapters.IsolatorTableAdapter isolatorTableAdapter;
        private JailDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator isolatorBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox prisonerIdTextBox;
        private System.Windows.Forms.TextBox reasonTextBox;
        private System.Windows.Forms.DateTimePicker releaseDateDateTimePicker;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ComboBox prisonerIdComboBox;
        private System.Windows.Forms.BindingSource prisonersBindingSource;
        private JailDataSetTableAdapters.PrisonersTableAdapter prisonersTableAdapter;
    }
}