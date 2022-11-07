namespace PersonalFinances
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.personalFinancesDataSet1 = new PersonalFinances.PersonalFinancesDataSet1();
            this.eMPLOYEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEETableAdapter = new PersonalFinances.PersonalFinancesDataSet1TableAdapters.EMPLOYEETableAdapter();
            this.tableAdapterManager = new PersonalFinances.PersonalFinancesDataSet1TableAdapters.TableAdapterManager();
            this.eMPLOYEEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // personalFinancesDataSet1
            // 
            this.personalFinancesDataSet1.DataSetName = "PersonalFinancesDataSet1";
            this.personalFinancesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEEBindingSource
            // 
            this.eMPLOYEEBindingSource.DataMember = "EMPLOYEE";
            this.eMPLOYEEBindingSource.DataSource = this.personalFinancesDataSet1;
            // 
            // eMPLOYEETableAdapter
            // 
            this.eMPLOYEETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.DOSSIER_DETAILSTableAdapter = null;
            this.tableAdapterManager.DOSSIERTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = this.eMPLOYEETableAdapter;
            this.tableAdapterManager.INCOME_EXPNECETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PersonalFinances.PersonalFinancesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eMPLOYEEDataGridView
            // 
            this.eMPLOYEEDataGridView.AutoGenerateColumns = false;
            this.eMPLOYEEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eMPLOYEEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.eMPLOYEEDataGridView.DataSource = this.eMPLOYEEBindingSource;
            this.eMPLOYEEDataGridView.Location = new System.Drawing.Point(-1, 2);
            this.eMPLOYEEDataGridView.Name = "eMPLOYEEDataGridView";
            this.eMPLOYEEDataGridView.RowHeadersVisible = false;
            this.eMPLOYEEDataGridView.RowHeadersWidth = 51;
            this.eMPLOYEEDataGridView.RowTemplate.Height = 24;
            this.eMPLOYEEDataGridView.Size = new System.Drawing.Size(489, 323);
            this.eMPLOYEEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EMP_FULLNAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Име";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EMP_USERNAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "Потребителско име";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addEmployeeBtn.Location = new System.Drawing.Point(95, 363);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(132, 48);
            this.addEmployeeBtn.TabIndex = 2;
            this.addEmployeeBtn.Text = "Добави служител";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.addEmployeeBtn);
            this.Controls.Add(this.eMPLOYEEDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Админ панел";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonalFinancesDataSet1 personalFinancesDataSet1;
        private System.Windows.Forms.BindingSource eMPLOYEEBindingSource;
        private PersonalFinancesDataSet1TableAdapters.EMPLOYEETableAdapter eMPLOYEETableAdapter;
        private PersonalFinancesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView eMPLOYEEDataGridView;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}