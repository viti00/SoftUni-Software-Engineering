namespace PersonalFinances
{
    partial class Dossiers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dossiers));
            this.personalFinancesDataSet1 = new PersonalFinances.PersonalFinancesDataSet1();
            this.dOSSIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOSSIERTableAdapter = new PersonalFinances.PersonalFinancesDataSet1TableAdapters.DOSSIERTableAdapter();
            this.tableAdapterManager = new PersonalFinances.PersonalFinancesDataSet1TableAdapters.TableAdapterManager();
            this.cLIENTTableAdapter = new PersonalFinances.PersonalFinancesDataSet1TableAdapters.CLIENTTableAdapter();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOSSIERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalFinancesDataSet1
            // 
            this.personalFinancesDataSet1.DataSetName = "PersonalFinancesDataSet1";
            this.personalFinancesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOSSIERBindingSource
            // 
            this.dOSSIERBindingSource.DataMember = "DOSSIER";
            this.dOSSIERBindingSource.DataSource = this.personalFinancesDataSet1;
            // 
            // dOSSIERTableAdapter
            // 
            this.dOSSIERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = this.cLIENTTableAdapter;
            this.tableAdapterManager.DOSSIER_DETAILSTableAdapter = null;
            this.tableAdapterManager.DOSSIERTableAdapter = this.dOSSIERTableAdapter;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.INCOME_EXPNECETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PersonalFinances.PersonalFinancesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.personalFinancesDataSet1;
            // 
            // dOSSIERBindingSource1
            // 
            this.dOSSIERBindingSource1.DataMember = "FK_DOSSIER_REFERENCE_CLIENT";
            this.dOSSIERBindingSource1.DataSource = this.cLIENTBindingSource;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View});
            this.dataGridView.Location = new System.Drawing.Point(12, 153);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1172, 416);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // View
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Преглед";
            this.View.DefaultCellStyle = dataGridViewCellStyle1;
            this.View.HeaderText = "Преглед";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Text = "Преглед";
            this.View.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.searchTextBox);
            this.groupBox1.Controls.Add(this.searchComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1172, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Търсене";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Location = new System.Drawing.Point(780, 40);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(138, 33);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Търсене";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(343, 40);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(397, 33);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchComboBox
            // 
            this.searchComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Име",
            "ЕГН",
            "Досие №",
            "Досие статус",
            "Отчетна година"});
            this.searchComboBox.Location = new System.Drawing.Point(99, 40);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(199, 33);
            this.searchComboBox.TabIndex = 0;
            // 
            // Dossiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dossiers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Досиета";
            this.Load += new System.EventHandler(this.Dossiers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonalFinancesDataSet1 personalFinancesDataSet1;
        private System.Windows.Forms.BindingSource dOSSIERBindingSource;
        private PersonalFinancesDataSet1TableAdapters.DOSSIERTableAdapter dOSSIERTableAdapter;
        private PersonalFinancesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private PersonalFinancesDataSet1TableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private System.Windows.Forms.BindingSource dOSSIERBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.DataGridViewButtonColumn View;
    }
}