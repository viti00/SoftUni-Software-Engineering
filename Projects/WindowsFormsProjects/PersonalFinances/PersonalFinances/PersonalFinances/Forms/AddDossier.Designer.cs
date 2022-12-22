using PersonalFinances.Data;

namespace PersonalFinances.Forms
{
    partial class AddDossier
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
            System.Windows.Forms.Label dOSSIER_YEARLabel;
            System.Windows.Forms.Label dOSSIER_MIN_BALANCELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDossier));
            this.personalFinancesDataSet1 = new PersonalFinances.Data.PersonalFinancesDataSet1();
            this.dOSSIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOSSIERTableAdapter = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.DOSSIERTableAdapter();
            this.tableAdapterManager = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.TableAdapterManager();
            this.minBalanceTextBox = new System.Windows.Forms.TextBox();
            this.dossierDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            dOSSIER_YEARLabel = new System.Windows.Forms.Label();
            dOSSIER_MIN_BALANCELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dOSSIER_YEARLabel
            // 
            dOSSIER_YEARLabel.AutoSize = true;
            dOSSIER_YEARLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dOSSIER_YEARLabel.Location = new System.Drawing.Point(22, 86);
            dOSSIER_YEARLabel.Name = "dOSSIER_YEARLabel";
            dOSSIER_YEARLabel.Size = new System.Drawing.Size(168, 25);
            dOSSIER_YEARLabel.TabIndex = 1;
            dOSSIER_YEARLabel.Text = "Отчетна година:";
            // 
            // dOSSIER_MIN_BALANCELabel
            // 
            dOSSIER_MIN_BALANCELabel.AutoSize = true;
            dOSSIER_MIN_BALANCELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dOSSIER_MIN_BALANCELabel.Location = new System.Drawing.Point(22, 157);
            dOSSIER_MIN_BALANCELabel.Name = "dOSSIER_MIN_BALANCELabel";
            dOSSIER_MIN_BALANCELabel.Size = new System.Drawing.Size(197, 25);
            dOSSIER_MIN_BALANCELabel.TabIndex = 3;
            dOSSIER_MIN_BALANCELabel.Text = "Минимален баланс:";
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
            this.tableAdapterManager.CLIENTTableAdapter = null;
            this.tableAdapterManager.DOSSIER_DETAILSTableAdapter = null;
            this.tableAdapterManager.DOSSIERTableAdapter = this.dOSSIERTableAdapter;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.INCOME_EXPNECETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // minBalanceTextBox
            // 
            this.minBalanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minBalanceTextBox.Location = new System.Drawing.Point(237, 154);
            this.minBalanceTextBox.MaxLength = 12;
            this.minBalanceTextBox.Name = "minBalanceTextBox";
            this.minBalanceTextBox.Size = new System.Drawing.Size(152, 30);
            this.minBalanceTextBox.TabIndex = 4;
            this.minBalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.minBalanceTextBox, "Незадължително поле");
            // 
            // dossierDateTimePicker
            // 
            this.dossierDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dossierDateTimePicker.Location = new System.Drawing.Point(237, 81);
            this.dossierDateTimePicker.Name = "dossierDateTimePicker";
            this.dossierDateTimePicker.Size = new System.Drawing.Size(152, 30);
            this.dossierDateTimePicker.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dossierDateTimePicker, "Полето е задължително");
            // 
            // createBtn
            // 
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.createBtn.Location = new System.Drawing.Point(130, 267);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(174, 43);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Създай досие";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            this.createBtn.MouseLeave += new System.EventHandler(this.createBtn_MouseLeave);
            this.createBtn.MouseHover += new System.EventHandler(this.createBtn_MouseHover);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddDossier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 351);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.dossierDateTimePicker);
            this.Controls.Add(dOSSIER_YEARLabel);
            this.Controls.Add(dOSSIER_MIN_BALANCELabel);
            this.Controls.Add(this.minBalanceTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDossier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Добавяне на ново досие";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddDossier_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersonalFinancesDataSet1 personalFinancesDataSet1;
        private System.Windows.Forms.BindingSource dOSSIERBindingSource;
        private Data.PersonalFinancesDataSet1TableAdapters.DOSSIERTableAdapter dOSSIERTableAdapter;
        private Data.PersonalFinancesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox minBalanceTextBox;
        private System.Windows.Forms.DateTimePicker dossierDateTimePicker;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}