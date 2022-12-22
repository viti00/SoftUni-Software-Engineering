using PersonalFinances.Data;

namespace PersonalFinances.Forms
{
    partial class AddClient
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
            System.Windows.Forms.Label EgnLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label middlenameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label addressTypeLabel;
            System.Windows.Forms.Label addressRegionLabel;
            System.Windows.Forms.Label addressMunicipaltyLabel;
            System.Windows.Forms.Label addresPlaceLabel;
            System.Windows.Forms.Label addressPostCodeLabel;
            System.Windows.Forms.Label addressTextLabel;
            System.Windows.Forms.Label dossierYearLabel;
            System.Windows.Forms.Label dossierMinBalanceLabel;
            System.Windows.Forms.Label dossierStatusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.aDDRESSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOSSIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataGroupBox = new System.Windows.Forms.GroupBox();
            this.addressTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addressRegionTextBox = new System.Windows.Forms.TextBox();
            this.addressMunicipalityTextBox = new System.Windows.Forms.TextBox();
            this.addressPlaceTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.dossierMinBalanceTextBox = new System.Windows.Forms.TextBox();
            this.yearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dossierDataGroupBox = new System.Windows.Forms.GroupBox();
            this.dossierStatusTextBox = new System.Windows.Forms.TextBox();
            this.addClientButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EGNTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addressPostCodeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalFinancesDataSet = new PersonalFinances.Data.PersonalFinancesDataSet1();
            this.cLIENTTableAdapter = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.CLIENTTableAdapter();
            this.tableAdapterManager = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.TableAdapterManager();
            this.aDDRESSTableAdapter = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.ADDRESSTableAdapter();
            this.dOSSIERTableAdapter = new PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.DOSSIERTableAdapter();
            EgnLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            middlenameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            addressTypeLabel = new System.Windows.Forms.Label();
            addressRegionLabel = new System.Windows.Forms.Label();
            addressMunicipaltyLabel = new System.Windows.Forms.Label();
            addresPlaceLabel = new System.Windows.Forms.Label();
            addressPostCodeLabel = new System.Windows.Forms.Label();
            addressTextLabel = new System.Windows.Forms.Label();
            dossierYearLabel = new System.Windows.Forms.Label();
            dossierMinBalanceLabel = new System.Windows.Forms.Label();
            dossierStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aDDRESSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIERBindingSource)).BeginInit();
            this.clientDataGroupBox.SuspendLayout();
            this.dossierDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // EgnLabel
            // 
            EgnLabel.AutoSize = true;
            EgnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            EgnLabel.Location = new System.Drawing.Point(25, 32);
            EgnLabel.Name = "EgnLabel";
            EgnLabel.Size = new System.Drawing.Size(49, 20);
            EgnLabel.TabIndex = 0;
            EgnLabel.Text = "ЕГН:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            firstnameLabel.Location = new System.Drawing.Point(25, 69);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(47, 20);
            firstnameLabel.TabIndex = 2;
            firstnameLabel.Text = "Име:";
            // 
            // middlenameLabel
            // 
            middlenameLabel.AutoSize = true;
            middlenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            middlenameLabel.Location = new System.Drawing.Point(25, 103);
            middlenameLabel.Name = "middlenameLabel";
            middlenameLabel.Size = new System.Drawing.Size(88, 20);
            middlenameLabel.TabIndex = 4;
            middlenameLabel.Text = "Презиме:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lastnameLabel.Location = new System.Drawing.Point(26, 139);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(92, 20);
            lastnameLabel.TabIndex = 6;
            lastnameLabel.Text = "Фамилия:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            emailLabel.Location = new System.Drawing.Point(25, 172);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(123, 20);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Имейл адрес:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            phoneLabel.Location = new System.Drawing.Point(25, 212);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(90, 20);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "Телефон:";
            // 
            // addressTypeLabel
            // 
            addressTypeLabel.AutoSize = true;
            addressTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            addressTypeLabel.Location = new System.Drawing.Point(26, 445);
            addressTypeLabel.Name = "addressTypeLabel";
            addressTypeLabel.Size = new System.Drawing.Size(100, 20);
            addressTypeLabel.TabIndex = 12;
            addressTypeLabel.Text = "Тип адрес:";
            // 
            // addressRegionLabel
            // 
            addressRegionLabel.AutoSize = true;
            addressRegionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            addressRegionLabel.Location = new System.Drawing.Point(25, 248);
            addressRegionLabel.Name = "addressRegionLabel";
            addressRegionLabel.Size = new System.Drawing.Size(76, 20);
            addressRegionLabel.TabIndex = 14;
            addressRegionLabel.Text = "Област:";
            // 
            // addressMunicipaltyLabel
            // 
            addressMunicipaltyLabel.AutoSize = true;
            addressMunicipaltyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            addressMunicipaltyLabel.Location = new System.Drawing.Point(26, 282);
            addressMunicipaltyLabel.Name = "addressMunicipaltyLabel";
            addressMunicipaltyLabel.Size = new System.Drawing.Size(81, 20);
            addressMunicipaltyLabel.TabIndex = 16;
            addressMunicipaltyLabel.Text = "Община:";
            // 
            // addresPlaceLabel
            // 
            addresPlaceLabel.AutoSize = true;
            addresPlaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            addresPlaceLabel.Location = new System.Drawing.Point(25, 317);
            addresPlaceLabel.Name = "addresPlaceLabel";
            addresPlaceLabel.Size = new System.Drawing.Size(152, 20);
            addresPlaceLabel.TabIndex = 18;
            addresPlaceLabel.Text = "Населено място:";
            // 
            // addressPostCodeLabel
            // 
            addressPostCodeLabel.AutoSize = true;
            addressPostCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            addressPostCodeLabel.Location = new System.Drawing.Point(25, 358);
            addressPostCodeLabel.Name = "addressPostCodeLabel";
            addressPostCodeLabel.Size = new System.Drawing.Size(135, 20);
            addressPostCodeLabel.TabIndex = 20;
            addressPostCodeLabel.Text = "Пощенски код:";
            // 
            // addressTextLabel
            // 
            addressTextLabel.AutoSize = true;
            addressTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            addressTextLabel.Location = new System.Drawing.Point(25, 400);
            addressTextLabel.Name = "addressTextLabel";
            addressTextLabel.Size = new System.Drawing.Size(67, 20);
            addressTextLabel.TabIndex = 22;
            addressTextLabel.Text = "Адрес:";
            // 
            // dossierYearLabel
            // 
            dossierYearLabel.AutoSize = true;
            dossierYearLabel.Location = new System.Drawing.Point(27, 51);
            dossierYearLabel.Name = "dossierYearLabel";
            dossierYearLabel.Size = new System.Drawing.Size(76, 20);
            dossierYearLabel.TabIndex = 24;
            dossierYearLabel.Text = "Година:";
            // 
            // dossierMinBalanceLabel
            // 
            dossierMinBalanceLabel.AutoSize = true;
            dossierMinBalanceLabel.Location = new System.Drawing.Point(27, 96);
            dossierMinBalanceLabel.Name = "dossierMinBalanceLabel";
            dossierMinBalanceLabel.Size = new System.Drawing.Size(174, 20);
            dossierMinBalanceLabel.TabIndex = 28;
            dossierMinBalanceLabel.Text = "Минимален баланс:";
            // 
            // dossierStatusLabel
            // 
            dossierStatusLabel.AutoSize = true;
            dossierStatusLabel.Location = new System.Drawing.Point(28, 145);
            dossierStatusLabel.Name = "dossierStatusLabel";
            dossierStatusLabel.Size = new System.Drawing.Size(73, 20);
            dossierStatusLabel.TabIndex = 32;
            dossierStatusLabel.Text = "Статус:";
            // 
            // aDDRESSBindingSource
            // 
            this.aDDRESSBindingSource.DataMember = "FK_ADDRESS_REFERENCE_CLIENT";
            this.aDDRESSBindingSource.DataSource = this.cLIENTBindingSource;
            // 
            // dOSSIERBindingSource
            // 
            this.dOSSIERBindingSource.DataMember = "FK_DOSSIER_REFERENCE_CLIENT";
            this.dOSSIERBindingSource.DataSource = this.cLIENTBindingSource;
            // 
            // clientDataGroupBox
            // 
            this.clientDataGroupBox.Controls.Add(this.phoneTextBox);
            this.clientDataGroupBox.Controls.Add(this.addressPostCodeTextBox);
            this.clientDataGroupBox.Controls.Add(this.EGNTextBox);
            this.clientDataGroupBox.Controls.Add(this.addressTypeComboBox);
            this.clientDataGroupBox.Controls.Add(addressRegionLabel);
            this.clientDataGroupBox.Controls.Add(addressTypeLabel);
            this.clientDataGroupBox.Controls.Add(this.addressRegionTextBox);
            this.clientDataGroupBox.Controls.Add(addressMunicipaltyLabel);
            this.clientDataGroupBox.Controls.Add(this.addressMunicipalityTextBox);
            this.clientDataGroupBox.Controls.Add(addresPlaceLabel);
            this.clientDataGroupBox.Controls.Add(this.addressPlaceTextBox);
            this.clientDataGroupBox.Controls.Add(addressPostCodeLabel);
            this.clientDataGroupBox.Controls.Add(addressTextLabel);
            this.clientDataGroupBox.Controls.Add(this.addressTextBox);
            this.clientDataGroupBox.Controls.Add(EgnLabel);
            this.clientDataGroupBox.Controls.Add(firstnameLabel);
            this.clientDataGroupBox.Controls.Add(this.nameTextBox);
            this.clientDataGroupBox.Controls.Add(middlenameLabel);
            this.clientDataGroupBox.Controls.Add(this.middleNameTextBox);
            this.clientDataGroupBox.Controls.Add(lastnameLabel);
            this.clientDataGroupBox.Controls.Add(this.lastnameTextBox);
            this.clientDataGroupBox.Controls.Add(emailLabel);
            this.clientDataGroupBox.Controls.Add(this.emailTextBox);
            this.clientDataGroupBox.Controls.Add(phoneLabel);
            this.clientDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clientDataGroupBox.Location = new System.Drawing.Point(11, 5);
            this.clientDataGroupBox.Name = "clientDataGroupBox";
            this.clientDataGroupBox.Size = new System.Drawing.Size(496, 508);
            this.clientDataGroupBox.TabIndex = 26;
            this.clientDataGroupBox.TabStop = false;
            this.clientDataGroupBox.Text = "Данни за клиент";
            // 
            // addressTypeComboBox
            // 
            this.addressTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addressTypeComboBox.FormattingEnabled = true;
            this.addressTypeComboBox.Items.AddRange(new object[] {
            "Постоянен адрес",
            "Адрес за коренспонденция"});
            this.addressTypeComboBox.Location = new System.Drawing.Point(201, 440);
            this.addressTypeComboBox.Name = "addressTypeComboBox";
            this.addressTypeComboBox.Size = new System.Drawing.Size(220, 28);
            this.addressTypeComboBox.TabIndex = 30;
            this.toolTip1.SetToolTip(this.addressTypeComboBox, "Задължително поле");
            // 
            // addressRegionTextBox
            // 
            this.addressRegionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addressRegionTextBox.Location = new System.Drawing.Point(200, 243);
            this.addressRegionTextBox.MaxLength = 100;
            this.addressRegionTextBox.Name = "addressRegionTextBox";
            this.addressRegionTextBox.Size = new System.Drawing.Size(220, 26);
            this.addressRegionTextBox.TabIndex = 15;
            // 
            // addressMunicipalityTextBox
            // 
            this.addressMunicipalityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addressMunicipalityTextBox.Location = new System.Drawing.Point(201, 278);
            this.addressMunicipalityTextBox.MaxLength = 100;
            this.addressMunicipalityTextBox.Name = "addressMunicipalityTextBox";
            this.addressMunicipalityTextBox.Size = new System.Drawing.Size(220, 26);
            this.addressMunicipalityTextBox.TabIndex = 17;
            // 
            // addressPlaceTextBox
            // 
            this.addressPlaceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addressPlaceTextBox.Location = new System.Drawing.Point(200, 315);
            this.addressPlaceTextBox.MaxLength = 100;
            this.addressPlaceTextBox.Name = "addressPlaceTextBox";
            this.addressPlaceTextBox.Size = new System.Drawing.Size(220, 26);
            this.addressPlaceTextBox.TabIndex = 19;
            this.toolTip1.SetToolTip(this.addressPlaceTextBox, "Задължително поле");
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addressTextBox.Location = new System.Drawing.Point(200, 390);
            this.addressTextBox.MaxLength = 100;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(220, 35);
            this.addressTextBox.TabIndex = 23;
            this.toolTip1.SetToolTip(this.addressTextBox, "Задължително поле");
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTextBox.Location = new System.Drawing.Point(200, 66);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(220, 26);
            this.nameTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.nameTextBox, "Задължително поле");
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.middleNameTextBox.Location = new System.Drawing.Point(200, 100);
            this.middleNameTextBox.MaxLength = 50;
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(220, 26);
            this.middleNameTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.middleNameTextBox, "Задължително поле\r\n");
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lastnameTextBox.Location = new System.Drawing.Point(200, 133);
            this.lastnameTextBox.MaxLength = 50;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(220, 26);
            this.lastnameTextBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.lastnameTextBox, "Задължително поле\r\n");
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailTextBox.Location = new System.Drawing.Point(200, 169);
            this.emailTextBox.MaxLength = 100;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(220, 26);
            this.emailTextBox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.emailTextBox, "Задължително поле\r\n");
            // 
            // dossierMinBalanceTextBox
            // 
            this.dossierMinBalanceTextBox.Location = new System.Drawing.Point(217, 93);
            this.dossierMinBalanceTextBox.MaxLength = 14;
            this.dossierMinBalanceTextBox.Name = "dossierMinBalanceTextBox";
            this.dossierMinBalanceTextBox.Size = new System.Drawing.Size(140, 26);
            this.dossierMinBalanceTextBox.TabIndex = 29;
            this.dossierMinBalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.dossierMinBalanceTextBox, "Незадължително поле");
            // 
            // yearDateTimePicker
            // 
            this.yearDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yearDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearDateTimePicker.Location = new System.Drawing.Point(217, 41);
            this.yearDateTimePicker.Name = "yearDateTimePicker";
            this.yearDateTimePicker.Size = new System.Drawing.Size(140, 26);
            this.yearDateTimePicker.TabIndex = 31;
            this.yearDateTimePicker.Value = new System.DateTime(2022, 10, 11, 17, 18, 0, 0);
            // 
            // dossierDataGroupBox
            // 
            this.dossierDataGroupBox.Controls.Add(dossierStatusLabel);
            this.dossierDataGroupBox.Controls.Add(this.dossierStatusTextBox);
            this.dossierDataGroupBox.Controls.Add(dossierYearLabel);
            this.dossierDataGroupBox.Controls.Add(this.yearDateTimePicker);
            this.dossierDataGroupBox.Controls.Add(dossierMinBalanceLabel);
            this.dossierDataGroupBox.Controls.Add(this.dossierMinBalanceTextBox);
            this.dossierDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dossierDataGroupBox.Location = new System.Drawing.Point(565, 5);
            this.dossierDataGroupBox.Name = "dossierDataGroupBox";
            this.dossierDataGroupBox.Size = new System.Drawing.Size(387, 216);
            this.dossierDataGroupBox.TabIndex = 32;
            this.dossierDataGroupBox.TabStop = false;
            this.dossierDataGroupBox.Text = "Данни за досие";
            // 
            // dossierStatusTextBox
            // 
            this.dossierStatusTextBox.Enabled = false;
            this.dossierStatusTextBox.Location = new System.Drawing.Point(217, 142);
            this.dossierStatusTextBox.Name = "dossierStatusTextBox";
            this.dossierStatusTextBox.Size = new System.Drawing.Size(140, 26);
            this.dossierStatusTextBox.TabIndex = 33;
            // 
            // addClientButton
            // 
            this.addClientButton.BackColor = System.Drawing.SystemColors.Control;
            this.addClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addClientButton.Location = new System.Drawing.Point(698, 317);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(141, 63);
            this.addClientButton.TabIndex = 34;
            this.addClientButton.Text = "Регистрация на клиент";
            this.addClientButton.UseVisualStyleBackColor = false;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            this.addClientButton.MouseLeave += new System.EventHandler(this.addClientButton_MouseLeave);
            this.addClientButton.MouseHover += new System.EventHandler(this.addClientButton_MouseHover);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EGNTextBox
            // 
            this.EGNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EGNTextBox.Location = new System.Drawing.Point(200, 25);
            this.EGNTextBox.Mask = "0000000000";
            this.EGNTextBox.Name = "EGNTextBox";
            this.EGNTextBox.PromptChar = '#';
            this.EGNTextBox.Size = new System.Drawing.Size(220, 26);
            this.EGNTextBox.TabIndex = 35;
            this.EGNTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.toolTip1.SetToolTip(this.EGNTextBox, "Задължително поле");
            // 
            // addressPostCodeTextBox
            // 
            this.addressPostCodeTextBox.Location = new System.Drawing.Point(200, 352);
            this.addressPostCodeTextBox.Mask = "0000";
            this.addressPostCodeTextBox.Name = "addressPostCodeTextBox";
            this.addressPostCodeTextBox.PromptChar = '#';
            this.addressPostCodeTextBox.Size = new System.Drawing.Size(220, 26);
            this.addressPostCodeTextBox.TabIndex = 35;
            this.toolTip1.SetToolTip(this.addressPostCodeTextBox, "Полето трябва да съдържа само цифри");
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phoneTextBox.Location = new System.Drawing.Point(200, 206);
            this.phoneTextBox.Mask = "0000-000-000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PromptChar = '#';
            this.phoneTextBox.Size = new System.Drawing.Size(220, 26);
            this.phoneTextBox.TabIndex = 36;
            this.phoneTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.toolTip1.SetToolTip(this.phoneTextBox, "Задължително поле");
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
            this.tableAdapterManager.ADDRESSTableAdapter = this.aDDRESSTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTTableAdapter = this.cLIENTTableAdapter;
            this.tableAdapterManager.DOSSIER_DETAILSTableAdapter = null;
            this.tableAdapterManager.DOSSIERTableAdapter = this.dOSSIERTableAdapter;
            this.tableAdapterManager.EMPLOYEETableAdapter = null;
            this.tableAdapterManager.INCOME_EXPNECETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PersonalFinances.Data.PersonalFinancesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aDDRESSTableAdapter
            // 
            this.aDDRESSTableAdapter.ClearBeforeFill = true;
            // 
            // dOSSIERTableAdapter
            // 
            this.dOSSIERTableAdapter.ClearBeforeFill = true;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 540);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.dossierDataGroupBox);
            this.Controls.Add(this.clientDataGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Регистрация на нов клиент";
            ((System.ComponentModel.ISupportInitialize)(this.aDDRESSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOSSIERBindingSource)).EndInit();
            this.clientDataGroupBox.ResumeLayout(false);
            this.clientDataGroupBox.PerformLayout();
            this.dossierDataGroupBox.ResumeLayout(false);
            this.dossierDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalFinancesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonalFinancesDataSet1 personalFinancesDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private Data.PersonalFinancesDataSet1TableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private Data.PersonalFinancesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Data.PersonalFinancesDataSet1TableAdapters.ADDRESSTableAdapter aDDRESSTableAdapter;
        private System.Windows.Forms.BindingSource aDDRESSBindingSource;
        private Data.PersonalFinancesDataSet1TableAdapters.DOSSIERTableAdapter dOSSIERTableAdapter;
        private System.Windows.Forms.BindingSource dOSSIERBindingSource;
        private System.Windows.Forms.GroupBox clientDataGroupBox;
        private System.Windows.Forms.ComboBox addressTypeComboBox;
        private System.Windows.Forms.TextBox dossierMinBalanceTextBox;
        private System.Windows.Forms.TextBox addressRegionTextBox;
        private System.Windows.Forms.TextBox addressMunicipalityTextBox;
        private System.Windows.Forms.TextBox addressPlaceTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker yearDateTimePicker;
        private System.Windows.Forms.GroupBox dossierDataGroupBox;
        private System.Windows.Forms.TextBox dossierStatusTextBox;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox EGNTextBox;
        private System.Windows.Forms.MaskedTextBox addressPostCodeTextBox;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
    }
}