using PersonalFinances.Data;

namespace PersonalFinances.Forms
{
    partial class Clients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addClient = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalFinancesDataSet = new PersonalFinances.Data.PersonalFinancesDataSet1();
            this.cLIENTTableAdapter = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.CLIENTTableAdapter();
            this.tableAdapterManager = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.searchComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Търсене";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(429, 40);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(397, 33);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchComboBox
            // 
            this.searchComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Име",
            "Презиме",
            "Фамилия",
            "ЕГН",
            "Телефон",
            "Имейл"});
            this.searchComboBox.Location = new System.Drawing.Point(185, 40);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(199, 33);
            this.searchComboBox.TabIndex = 0;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AllowUserToAddRows = false;
            this.clientsDataGridView.AllowUserToDeleteRows = false;
            this.clientsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.View});
            this.clientsDataGridView.DataSource = this.cLIENTBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.clientsDataGridView.Location = new System.Drawing.Point(14, 145);
            this.clientsDataGridView.MultiSelect = false;
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.ReadOnly = true;
            this.clientsDataGridView.RowHeadersVisible = false;
            this.clientsDataGridView.RowHeadersWidth = 51;
            this.clientsDataGridView.RowTemplate.Height = 24;
            this.clientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGridView.Size = new System.Drawing.Size(1172, 416);
            this.clientsDataGridView.TabIndex = 3;
            this.clientsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGridView_CellClick);
            // 
            // View
            // 
            this.View.HeaderText = "";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Text = "Преглед";
            this.View.UseColumnTextForButtonValue = true;
            this.View.Width = 125;
            // 
            // addClient
            // 
            this.addClient.BackColor = System.Drawing.Color.RoyalBlue;
            this.addClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addClient.Location = new System.Drawing.Point(513, 575);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(172, 46);
            this.addClient.TabIndex = 4;
            this.addClient.Text = "Добави клиент";
            this.addClient.UseVisualStyleBackColor = false;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "CLIENT_ID";
            this.Id.HeaderText = "CLIENT_ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CLIENT_NAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "Име";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CLIENT_SURNAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "Презиме";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CLIENT_LASTNAME";
            this.dataGridViewTextBoxColumn5.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CLIENT_EGN";
            this.dataGridViewTextBoxColumn2.HeaderText = "ЕГН";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CLIENT_EMAIL";
            this.dataGridViewTextBoxColumn6.HeaderText = "Имейл";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CLIENT_PHONE";
            this.dataGridViewTextBoxColumn7.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.personalFinancesDataSet;
            // 
            // personalFinancesDataSet
            // 
            this.personalFinancesDataSet.DataSetName = "PersonalFinancesDataSet";
            this.personalFinancesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = this.cLIENTTableAdapter;
            this.tableAdapterManager.DOSSIER_DETAILSTableAdapter = null;
            this.tableAdapterManager.DOSSIERTableAdapter = null;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.INCOME_EXPNECETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 633);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Клиенти";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private PersonalFinancesDataSet1 personalFinancesDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private Data.PersonalFinancesDataSet1TableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private Data.PersonalFinancesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.Button addClient;
    }
}