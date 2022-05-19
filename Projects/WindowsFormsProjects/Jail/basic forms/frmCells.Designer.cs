
namespace Jail
{
    partial class frmCells
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
            System.Windows.Forms.Label cellNumberLabel;
            System.Windows.Forms.Label sectorIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCells));
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
            this.cellNumberTextBox = new System.Windows.Forms.TextBox();
            this.sectorIdTextBox = new System.Windows.Forms.TextBox();
            this.addCell = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.sectorIdComboBox = new System.Windows.Forms.ComboBox();
            this.sectorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectorsTableAdapter = new Jail.JailDataSetTableAdapters.SectorsTableAdapter();
            cellNumberLabel = new System.Windows.Forms.Label();
            sectorIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingNavigator)).BeginInit();
            this.cellsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cellNumberLabel
            // 
            cellNumberLabel.AutoSize = true;
            cellNumberLabel.Location = new System.Drawing.Point(63, 136);
            cellNumberLabel.Name = "cellNumberLabel";
            cellNumberLabel.Size = new System.Drawing.Size(89, 17);
            cellNumberLabel.TabIndex = 1;
            cellNumberLabel.Text = "Cell Number:";
            // 
            // sectorIdLabel
            // 
            sectorIdLabel.AutoSize = true;
            sectorIdLabel.Location = new System.Drawing.Point(63, 174);
            sectorIdLabel.Name = "sectorIdLabel";
            sectorIdLabel.Size = new System.Drawing.Size(68, 17);
            sectorIdLabel.TabIndex = 3;
            sectorIdLabel.Text = "Sector Id:";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // cellNumberTextBox
            // 
            this.cellNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cellsBindingSource, "CellNumber", true));
            this.cellNumberTextBox.Enabled = false;
            this.cellNumberTextBox.Location = new System.Drawing.Point(158, 133);
            this.cellNumberTextBox.Name = "cellNumberTextBox";
            this.cellNumberTextBox.Size = new System.Drawing.Size(195, 22);
            this.cellNumberTextBox.TabIndex = 2;
            // 
            // sectorIdTextBox
            // 
            this.sectorIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cellsBindingSource, "SectorId", true));
            this.sectorIdTextBox.Enabled = false;
            this.sectorIdTextBox.Location = new System.Drawing.Point(158, 171);
            this.sectorIdTextBox.Name = "sectorIdTextBox";
            this.sectorIdTextBox.Size = new System.Drawing.Size(195, 22);
            this.sectorIdTextBox.TabIndex = 4;
            // 
            // addCell
            // 
            this.addCell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCell.BackgroundImage")));
            this.addCell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addCell.Location = new System.Drawing.Point(268, 241);
            this.addCell.Name = "addCell";
            this.addCell.Size = new System.Drawing.Size(86, 47);
            this.addCell.TabIndex = 5;
            this.addCell.UseVisualStyleBackColor = true;
            this.addCell.Visible = false;
            this.addCell.Click += new System.EventHandler(this.addCell_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(158, 241);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(86, 47);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(158, 241);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(86, 47);
            this.Create.TabIndex = 7;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(267, 241);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(86, 47);
            this.Edit.TabIndex = 8;
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
            this.sectorIdComboBox.Location = new System.Drawing.Point(158, 171);
            this.sectorIdComboBox.Name = "sectorIdComboBox";
            this.sectorIdComboBox.Size = new System.Drawing.Size(195, 24);
            this.sectorIdComboBox.TabIndex = 9;
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
            // frmCells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1334, 666);
            this.Controls.Add(this.sectorIdComboBox);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.addCell);
            this.Controls.Add(cellNumberLabel);
            this.Controls.Add(this.cellNumberTextBox);
            this.Controls.Add(sectorIdLabel);
            this.Controls.Add(this.sectorIdTextBox);
            this.Controls.Add(this.cellsBindingNavigator);
            this.DoubleBuffered = true;
            this.Name = "frmCells";
            this.Text = "frmCells";
            this.Load += new System.EventHandler(this.frmCells_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cellsBindingNavigator)).EndInit();
            this.cellsBindingNavigator.ResumeLayout(false);
            this.cellsBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox cellNumberTextBox;
        private System.Windows.Forms.TextBox sectorIdTextBox;
        private System.Windows.Forms.Button addCell;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.ComboBox sectorIdComboBox;
        private System.Windows.Forms.BindingSource sectorsBindingSource;
        private JailDataSetTableAdapters.SectorsTableAdapter sectorsTableAdapter;
    }
}