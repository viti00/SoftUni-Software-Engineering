using PersonalFinances.Data;

namespace PersonalFinances.Forms
{
    partial class EditTransaction
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label docLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTransaction));
            this.dossierDetailsIdComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elementsGroupBox = new System.Windows.Forms.GroupBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.iNCOME_EXPNECEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalFinancesDataSet1 = new PersonalFinances.Data.PersonalFinancesDataSet1();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dOSSIER_DETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.docTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dOSSIER_DETAILSTableAdapter = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.DOSSIER_DETAILSTableAdapter();
            this.tableAdapterManager = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.TableAdapterManager();
            this.iNCOME_EXPNECETableAdapter = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.INCOME_EXPNECETableAdapter();
            this.dossierTableAdapter = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.DOSSIERTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            docLabel = new System.Windows.Forms.Label();
            this.elementsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNCOME_EXPNECEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIER_DETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nameLabel.Location = new System.Drawing.Point(18, 226);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(139, 20);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "Наименование:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            typeLabel.Location = new System.Drawing.Point(18, 269);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(44, 20);
            typeLabel.TabIndex = 21;
            typeLabel.Text = "Тип:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dateLabel.Location = new System.Drawing.Point(18, 41);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(57, 20);
            dateLabel.TabIndex = 14;
            dateLabel.Text = "Дата:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            valueLabel.Location = new System.Drawing.Point(18, 86);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(95, 20);
            valueLabel.TabIndex = 16;
            valueLabel.Text = "Стойност:";
            // 
            // docLabel
            // 
            docLabel.AutoSize = true;
            docLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            docLabel.Location = new System.Drawing.Point(18, 129);
            docLabel.Name = "docLabel";
            docLabel.Size = new System.Drawing.Size(96, 20);
            docLabel.TabIndex = 18;
            docLabel.Text = "Документ:";
            // 
            // dossierDetailsIdComboBox
            // 
            this.dossierDetailsIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dossierDetailsIdComboBox.FormattingEnabled = true;
            this.dossierDetailsIdComboBox.Location = new System.Drawing.Point(236, 44);
            this.dossierDetailsIdComboBox.Name = "dossierDetailsIdComboBox";
            this.dossierDetailsIdComboBox.Size = new System.Drawing.Size(121, 28);
            this.dossierDetailsIdComboBox.TabIndex = 0;
            this.dossierDetailsIdComboBox.SelectedIndexChanged += new System.EventHandler(this.dossierDetailsIdComboBox_SelectedIndexChanged);
            this.dossierDetailsIdComboBox.TextUpdate += new System.EventHandler(this.dossierDetailsIdComboBox_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер на транзакция:";
            // 
            // elementsGroupBox
            // 
            this.elementsGroupBox.Controls.Add(this.typeTextBox);
            this.elementsGroupBox.Controls.Add(this.cancelBtn);
            this.elementsGroupBox.Controls.Add(this.saveBtn);
            this.elementsGroupBox.Controls.Add(this.deleteBtn);
            this.elementsGroupBox.Controls.Add(this.nameComboBox);
            this.elementsGroupBox.Controls.Add(nameLabel);
            this.elementsGroupBox.Controls.Add(typeLabel);
            this.elementsGroupBox.Controls.Add(dateLabel);
            this.elementsGroupBox.Controls.Add(this.dateDateTimePicker);
            this.elementsGroupBox.Controls.Add(valueLabel);
            this.elementsGroupBox.Controls.Add(this.valueTextBox);
            this.elementsGroupBox.Controls.Add(docLabel);
            this.elementsGroupBox.Controls.Add(this.docTextBox);
            this.elementsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.elementsGroupBox.Location = new System.Drawing.Point(12, 92);
            this.elementsGroupBox.Name = "elementsGroupBox";
            this.elementsGroupBox.Size = new System.Drawing.Size(404, 383);
            this.elementsGroupBox.TabIndex = 14;
            this.elementsGroupBox.TabStop = false;
            this.elementsGroupBox.Visible = false;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.typeTextBox.Location = new System.Drawing.Point(180, 269);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.ReadOnly = true;
            this.typeTextBox.Size = new System.Drawing.Size(200, 26);
            this.typeTextBox.TabIndex = 27;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelBtn.Location = new System.Drawing.Point(6, 330);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(88, 39);
            this.cancelBtn.TabIndex = 26;
            this.cancelBtn.Text = "Назад";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            this.cancelBtn.MouseLeave += new System.EventHandler(this.cancelBtn_MouseLeave);
            this.cancelBtn.MouseHover += new System.EventHandler(this.cancelBtn_MouseHover);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveBtn.Location = new System.Drawing.Point(147, 330);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 39);
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Text = "Запази";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            this.saveBtn.MouseHover += new System.EventHandler(this.saveBtn_MouseHover);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.deleteBtn.Location = new System.Drawing.Point(287, 330);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(88, 39);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Изтрий";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            this.deleteBtn.MouseLeave += new System.EventHandler(this.deleteBtn_MouseLeave);
            this.deleteBtn.MouseHover += new System.EventHandler(this.deleteBtn_MouseHover);
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.iNCOME_EXPNECEBindingSource, "INCEXP_NAME", true));
            this.nameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(180, 226);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(200, 28);
            this.nameComboBox.TabIndex = 23;
            this.toolTip1.SetToolTip(this.nameComboBox, "Полето е задължително");
            this.nameComboBox.TextUpdate += new System.EventHandler(this.nameComboBox_TextUpdate);
            // 
            // iNCOME_EXPNECEBindingSource
            // 
            this.iNCOME_EXPNECEBindingSource.DataMember = "INCOME_EXPNECE";
            this.iNCOME_EXPNECEBindingSource.DataSource = this.personalFinancesDataSet1;
            // 
            // personalFinancesDataSet1
            // 
            this.personalFinancesDataSet1.DataSetName = "PersonalFinancesDataSet1";
            this.personalFinancesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dOSSIER_DETAILSBindingSource, "DD_DATE", true));
            this.dateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateDateTimePicker.Location = new System.Drawing.Point(180, 37);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateDateTimePicker.TabIndex = 15;
            this.toolTip1.SetToolTip(this.dateDateTimePicker, "Полето е задължително");
            // 
            // dOSSIER_DETAILSBindingSource
            // 
            this.dOSSIER_DETAILSBindingSource.DataMember = "DOSSIER_DETAILS";
            this.dOSSIER_DETAILSBindingSource.DataSource = this.personalFinancesDataSet1;
            // 
            // valueTextBox
            // 
            this.valueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOSSIER_DETAILSBindingSource, "DD_VALUE", true));
            this.valueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.valueTextBox.Location = new System.Drawing.Point(180, 83);
            this.valueTextBox.MaxLength = 12;
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(200, 26);
            this.valueTextBox.TabIndex = 17;
            this.valueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.valueTextBox, "Полето е задължително. По-голямо от 0");
            // 
            // docTextBox
            // 
            this.docTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOSSIER_DETAILSBindingSource, "DD_DOC", true));
            this.docTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.docTextBox.Location = new System.Drawing.Point(180, 126);
            this.docTextBox.MaxLength = 100;
            this.docTextBox.Multiline = true;
            this.docTextBox.Name = "docTextBox";
            this.docTextBox.Size = new System.Drawing.Size(200, 76);
            this.docTextBox.TabIndex = 19;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dOSSIER_DETAILSTableAdapter
            // 
            this.dOSSIER_DETAILSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.DOSSIER_DETAILSTableAdapter = this.dOSSIER_DETAILSTableAdapter;
            this.tableAdapterManager.DOSSIERTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.INCOME_EXPNECETableAdapter = this.iNCOME_EXPNECETableAdapter;
            this.tableAdapterManager.UpdateOrder = PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iNCOME_EXPNECETableAdapter
            // 
            this.iNCOME_EXPNECETableAdapter.ClearBeforeFill = true;
            // 
            // dossierTableAdapter
            // 
            this.dossierTableAdapter.ClearBeforeFill = true;
            // 
            // EditTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 487);
            this.Controls.Add(this.elementsGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dossierDetailsIdComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Редактиране на транзакция";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditIncExpForm_FormClosed);
            this.Load += new System.EventHandler(this.EditIncExpForm_Load);
            this.elementsGroupBox.ResumeLayout(false);
            this.elementsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNCOME_EXPNECEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIER_DETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dossierDetailsIdComboBox;
        private PersonalFinancesDataSet1 personalFinancesDataSet1;
        private System.Windows.Forms.BindingSource dOSSIER_DETAILSBindingSource;
        private Data.PersonalFinancesDataSet1TableAdapters.DOSSIER_DETAILSTableAdapter dOSSIER_DETAILSTableAdapter;
        private Data.PersonalFinancesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Data.PersonalFinancesDataSet1TableAdapters.INCOME_EXPNECETableAdapter iNCOME_EXPNECETableAdapter;
        private System.Windows.Forms.BindingSource iNCOME_EXPNECEBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox elementsGroupBox;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox docTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
        private Data.PersonalFinancesDataSet1TableAdapters.DOSSIERTableAdapter dossierTableAdapter;
    }
}