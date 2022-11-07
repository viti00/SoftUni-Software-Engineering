namespace PersonalFinances
{
    partial class AddTransaction
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
            System.Windows.Forms.Label iNCEXP_NAMELabel;
            System.Windows.Forms.Label iNCEXP_TYPELabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label docLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTransaction));
            this.personalFinancesDataSet1 = new PersonalFinances.PersonalFinancesDataSet1();
            this.iNCOME_EXPNECEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNCOME_EXPNECETableAdapter = new PersonalFinances.PersonalFinancesDataSet1TableAdapters.INCOME_EXPNECETableAdapter();
            this.tableAdapterManager = new PersonalFinances.PersonalFinancesDataSet1TableAdapters.TableAdapterManager();
            this.dOSSIER_DETAILSTableAdapter = new PersonalFinances.PersonalFinancesDataSet1TableAdapters.DOSSIER_DETAILSTableAdapter();
            this.dossierTableAdapter1 = new PersonalFinances.PersonalFinancesDataSet1TableAdapters.DOSSIERTableAdapter();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.dOSSIER_DETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.docTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            iNCEXP_NAMELabel = new System.Windows.Forms.Label();
            iNCEXP_TYPELabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            docLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNCOME_EXPNECEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIER_DETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // iNCEXP_NAMELabel
            // 
            iNCEXP_NAMELabel.AutoSize = true;
            iNCEXP_NAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iNCEXP_NAMELabel.Location = new System.Drawing.Point(27, 36);
            iNCEXP_NAMELabel.Name = "iNCEXP_NAMELabel";
            iNCEXP_NAMELabel.Size = new System.Drawing.Size(139, 20);
            iNCEXP_NAMELabel.TabIndex = 1;
            iNCEXP_NAMELabel.Text = "Наименование:";
            // 
            // iNCEXP_TYPELabel
            // 
            iNCEXP_TYPELabel.AutoSize = true;
            iNCEXP_TYPELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            iNCEXP_TYPELabel.Location = new System.Drawing.Point(27, 108);
            iNCEXP_TYPELabel.Name = "iNCEXP_TYPELabel";
            iNCEXP_TYPELabel.Size = new System.Drawing.Size(44, 20);
            iNCEXP_TYPELabel.TabIndex = 3;
            iNCEXP_TYPELabel.Text = "Тип:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dateLabel.Location = new System.Drawing.Point(27, 173);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(57, 20);
            dateLabel.TabIndex = 6;
            dateLabel.Text = "Дата:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            valueLabel.Location = new System.Drawing.Point(27, 236);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(95, 20);
            valueLabel.TabIndex = 8;
            valueLabel.Text = "Стойност:";
            // 
            // docLabel
            // 
            docLabel.AutoSize = true;
            docLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            docLabel.Location = new System.Drawing.Point(27, 292);
            docLabel.Name = "docLabel";
            docLabel.Size = new System.Drawing.Size(96, 20);
            docLabel.TabIndex = 10;
            docLabel.Text = "Документ:";
            // 
            // personalFinancesDataSet1
            // 
            this.personalFinancesDataSet1.DataSetName = "PersonalFinancesDataSet1";
            this.personalFinancesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNCOME_EXPNECEBindingSource
            // 
            this.iNCOME_EXPNECEBindingSource.DataMember = "INCOME_EXPNECE";
            this.iNCOME_EXPNECEBindingSource.DataSource = this.personalFinancesDataSet1;
            // 
            // iNCOME_EXPNECETableAdapter
            // 
            this.iNCOME_EXPNECETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.DOSSIER_DETAILSTableAdapter = this.dOSSIER_DETAILSTableAdapter;
            this.tableAdapterManager.DOSSIERTableAdapter = this.dossierTableAdapter1;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.INCOME_EXPNECETableAdapter = this.iNCOME_EXPNECETableAdapter;
            this.tableAdapterManager.UpdateOrder = PersonalFinances.PersonalFinancesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dOSSIER_DETAILSTableAdapter
            // 
            this.dOSSIER_DETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // dossierTableAdapter1
            // 
            this.dossierTableAdapter1.ClearBeforeFill = true;
            // 
            // nameComboBox
            // 
            this.nameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(183, 36);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(267, 28);
            this.nameComboBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.nameComboBox, "Полето е задължително");
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Приход",
            "Разход"});
            this.typeComboBox.Location = new System.Drawing.Point(183, 105);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(267, 28);
            this.typeComboBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.typeComboBox, "Полето е задължително");
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addBtn.Location = new System.Drawing.Point(160, 400);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(210, 46);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Добави транзакция";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dOSSIER_DETAILSBindingSource
            // 
            this.dOSSIER_DETAILSBindingSource.DataMember = "DOSSIER_DETAILS";
            this.dOSSIER_DETAILSBindingSource.DataSource = this.personalFinancesDataSet1;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dOSSIER_DETAILSBindingSource, "DD_DATE", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateDateTimePicker.Location = new System.Drawing.Point(183, 168);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(267, 26);
            this.dateDateTimePicker.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dateDateTimePicker, "Полето е задължително");
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOSSIER_DETAILSBindingSource, "DD_VALUE", true));
            this.valueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.valueTextBox.Location = new System.Drawing.Point(183, 230);
            this.valueTextBox.MaxLength = 12;
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(267, 26);
            this.valueTextBox.TabIndex = 9;
            this.valueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.valueTextBox, "Полето е задължително. По-голямо от 0");
            // 
            // docTextBox
            // 
            this.docTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOSSIER_DETAILSBindingSource, "DD_DOC", true));
            this.docTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.docTextBox.Location = new System.Drawing.Point(183, 292);
            this.docTextBox.MaxLength = 100;
            this.docTextBox.Multiline = true;
            this.docTextBox.Name = "docTextBox";
            this.docTextBox.Size = new System.Drawing.Size(267, 75);
            this.docTextBox.TabIndex = 11;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 468);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(valueLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(docLabel);
            this.Controls.Add(this.docTextBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(iNCEXP_NAMELabel);
            this.Controls.Add(iNCEXP_TYPELabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Нова транзакция";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTransaction_FormClosed);
            this.Load += new System.EventHandler(this.AddTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNCOME_EXPNECEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIER_DETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersonalFinancesDataSet1 personalFinancesDataSet1;
        private System.Windows.Forms.BindingSource iNCOME_EXPNECEBindingSource;
        private PersonalFinancesDataSet1TableAdapters.INCOME_EXPNECETableAdapter iNCOME_EXPNECETableAdapter;
        private PersonalFinancesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button addBtn;
        private PersonalFinancesDataSet1TableAdapters.DOSSIER_DETAILSTableAdapter dOSSIER_DETAILSTableAdapter;
        private System.Windows.Forms.BindingSource dOSSIER_DETAILSBindingSource;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox docTextBox;
        private PersonalFinancesDataSet1TableAdapters.DOSSIERTableAdapter dossierTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}