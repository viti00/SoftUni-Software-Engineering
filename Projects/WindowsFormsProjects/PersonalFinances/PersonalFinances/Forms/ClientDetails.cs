using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PersonalFinances.Common;
using static PersonalFinances.Common.GlobalVariables;
using static PersonalFinances.Common.GlobalMethods;
using static PersonalFinances.Common.GlobalConstants;
using PersonalFinances.Data;

namespace PersonalFinances.Forms
{
    public partial class ClientDetails : Form
    {
        string currEgn = "";
        string currEmail = "";
        decimal currYear;


        public ClientDetails()
        {
            InitializeComponent();
            dossierDateTimePicker.Format = DateTimePickerFormat.Custom;
            dossierDateTimePicker.CustomFormat = "yyyy";
            dossierDateTimePicker.ShowUpDown = true;
            dossierDateTimePicker.Value = DateTime.Now;
            SetFormLocation(this);
        }

        private void ClientDetails_Load(object sender, EventArgs e)
        {

            this.cLIENTTableAdapter.FillBy(this.personalFinancesDataSet.CLIENT, Decimal.Parse(clientId));

            var client = this.cLIENTTableAdapter.GetData().FirstOrDefault(x => x.CLIENT_ID.ToString() == clientId);

            currEgn = client.CLIENT_EGN;
            currEmail = client.CLIENT_EMAIL;

            var address = this.aDDRESSTableAdapter.GetData().FirstOrDefault(x => x.CLIENT_ID.ToString() == clientId);

            this.aDDRESSTableAdapter.FillBy(this.personalFinancesDataSet.ADDRESS, address.ADDRESS_ID);

            if (address.ADDRESS_TYPE == "P")
            {
                addressTypeComboBox.SelectedIndex = 0;
            }
            else
            {
                addressTypeComboBox.SelectedIndex = 1;
            }

            var dossiers = this.dOSSIERTableAdapter.GetData().Where(x => x.CLIENT_ID.ToString() == clientId).ToList();

            dOSSIERBindingSource.Sort = sortArgsYear;
            dOSSIERTableAdapter.Fill(this.personalFinancesDataSet.DOSSIER);

            ShowSelectedRowInformation(dossierDataGridView, GetIndex(dossierId));

            CheckForOpenDossiers(dossiers);

            currClientLabel.Text =
                $"{client.CLIENT_NAME} {client.CLIENT_SURNAME} {client.CLIENT_LASTNAME} - {client.CLIENT_EGN}";

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editBtn.Visible = false;
            saveBtn.Visible = true;
            cancelBtn.Visible = true;
            ChangeContolsEnabled(clientGroupBox);
            addressTypeComboBox.Enabled = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (IsValid())
            {
                try
                {
                    cLIENTBindingSource.EndEdit();
                    cLIENTTableAdapter.Update(personalFinancesDataSet.CLIENT);
                    aDDRESSBindingSource.EndEdit();
                    aDDRESSTableAdapter.Update(personalFinancesDataSet.ADDRESS);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Промените са запазени усепшно");

                saveBtn.Visible = false;
                cancelBtn.Visible = false;
                editBtn.Visible = true;
                addressTypeComboBox.Enabled = false;

                ChangeContolsEnabled(clientGroupBox);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ChangeContolsEnabled(clientGroupBox);
            addressTypeComboBox.Enabled = false;
            editBtn.Visible = true;
            saveBtn.Visible = false;
            cancelBtn.Visible = false;

            var client = cLIENTTableAdapter.GetData().FirstOrDefault(x=> x.CLIENT_ID == Decimal.Parse(clientId));
            var address = aDDRESSTableAdapter.GetData().FirstOrDefault(x => x.CLIENT_ID == Decimal.Parse(clientId));

            egnTextBox.Text = client.CLIENT_EGN;
            fnameTextBox.Text = client.CLIENT_NAME;
            midnameTextBox.Text = client.CLIENT_SURNAME;
            lnameTextBox.Text = client.CLIENT_LASTNAME;
            phoneTextBox.Text = client.CLIENT_PHONE;
            emailTextBox.Text = client.CLIENT_EMAIL;
            addressTypeComboBox.SelectedIndex = address.ADDRESS_TYPE == "P"? 0:1;
            regionTextBox.Text = address.ADDRESS_REGION;
            municipaltyTextBox.Text = address.ADDRES_MUNICIPALITY;
            placeTextBox.Text = address.ADDRESS_PLACE;
            postcodeTextBox.Text = address.ADDRESS_PCODE;
            addressTextBox.Text = address.ADDRESS_TEXT;

            this.cLIENTTableAdapter.FillBy(this.personalFinancesDataSet.CLIENT, Decimal.Parse(clientId));
            errorProvider.Clear();
        }

        private void ChangeContolsEnabled(GroupBox groupBox)
        {
            var controls = groupBox.Controls.OfType<TextBox>().ToList();
            var maskedBoxes = groupBox.Controls.OfType<MaskedTextBox>().ToList(); 

            foreach (var control in controls)
            {
                if (control.Enabled == false)
                {
                    control.Enabled = true;
                }
                else
                {
                    control.Enabled = false;
                }
            }
            foreach (var control in maskedBoxes)
            {
                if (control.Enabled == false)
                {
                    control.Enabled = true;
                }
                else
                {
                    control.Enabled = false;
                }
            }
        }

        private bool IsValid()
        {
            var isValid = true;

            if (!Regex.IsMatch(egnTextBox.Text, egnPattern))
            {
                errorProvider.SetError(egnTextBox, "ЕГН-то се състои от точно 10 цифри");
                isValid = false;
            }
            if (currEgn != egnTextBox.Text && cLIENTTableAdapter.GetData().Any(x => x.CLIENT_EGN == egnTextBox.Text))
            {
                errorProvider.SetError(egnTextBox, "Вече има клиент с такова ЕГН");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(fnameTextBox.Text))
            {
                errorProvider.SetError(fnameTextBox, "Полето е задължително");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(midnameTextBox.Text))
            {
                errorProvider.SetError(midnameTextBox, "Полето е задължително");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(lnameTextBox.Text))
            {
                errorProvider.SetError(lnameTextBox, "Полето е задължително");
                isValid = false;
            }
            if (!Regex.IsMatch(emailTextBox.Text, emailPattern))
            {
                errorProvider.SetError(emailTextBox, "Въведете валиден имейл адрес");
                isValid = false;
            }
            if (currEmail != emailTextBox.Text && cLIENTTableAdapter.GetData().Any(x => x.CLIENT_EMAIL == emailTextBox.Text))
            {
                errorProvider.SetError(emailTextBox, "Вече има клиент с такъв имейл адрес");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(postcodeTextBox.Text))
            {
                errorProvider.SetError(postcodeTextBox, "Полето е задължително");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(placeTextBox.Text))
            {
                errorProvider.SetError(placeTextBox, "Полето е задължително");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                errorProvider.SetError(addressTextBox, "Полето е задължително");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(addressTypeComboBox.Text))
            {
                errorProvider.SetError(addressTypeComboBox, "Полето е задължително");
                isValid = false;
            }
            return isValid;
        }

        private void ClientDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(previousForm != null)
            {
                if (previousForm.Name == "Dossiers")
                {
                    Dossiers clients = new Dossiers();
                    clients.MdiParent = this.MdiParent;
                    clients.Show();
                }
                else
                {
                    Clients clients = new Clients();
                    clients.MdiParent = this.MdiParent;
                    clients.Show();
                }
            }
            
        }

        private void ShowSelectedRowInformation(DataGridView gridView, int rowIndex)
        {
            richDossiersTextBox.Text = "";
            if (gridView.Rows[rowIndex].Cells[1].Value.ToString() != "Приключено"
                && gridView.Rows[rowIndex].Cells[1].Value.ToString() != "C")
            {
                CheckForTransactions(gridView.Rows[rowIndex].Cells[0].Value.ToString());
                newTransact.Visible = true;
                changeStatusBtn.Visible = true;
                editDossierBtn.Visible = true;
            }
            else
            {
                btnEdit.Visible = false;
                newTransact.Visible = false;
                changeStatusBtn.Visible = false;
                editDossierBtn.Visible = false;
            }

            var dossierNo = gridView.Rows[rowIndex].Cells[0].Value.ToString();

            dossierId = dossierNo;

            var dossier = dOSSIERTableAdapter.GetData().FirstOrDefault(x => x.DOSSIER_NO.ToString() == dossierNo);

            DateTime date;
            DateTime.TryParseExact(dossier.DOSSIER_YEAR.ToString(), "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            dossierDateTimePicker.Value = date;
            currYear = date.Year;

            minBalanceTextBox.Text =
               IsValueNull(dossier.DOSSIER_MIN_BALANCE.ToString()) ? "Няма" : dossier.DOSSIER_MIN_BALANCE.ToString();

            currentBalanceTextBox.Text = dossier.DOSSIER_CURRENT_BALANCE.ToString() == null ? "" : dossier.DOSSIER_CURRENT_BALANCE.ToString();

            var dossierDetails = dOSSIER_DETAILSTableAdapter
                .GetData()
                .Where(x => x.DOSSIER_NO.ToString() == dossierNo)
                .OrderByDescending(x=> x.DD_DATE)
                .ThenByDescending(x=> x.DD_ID)
                .ToList();

            foreach (var dd in dossierDetails)
            {
                var incexp = iNCOME_EXPNECETableAdapter.GetData().FirstOrDefault(x => x.INCEXP_ID == dd.INCEXP_ID);

                var type = incexp.INCEXP_TYPE == "I" ? "Приход" : "Разход";

                Transaction incomeOrExpence = new Transaction(dd.DD_ID.ToString(),
                                                                      incexp.INCEXP_NAME,
                                                                      type,
                                                                      dd.DD_DATE.ToString("MM/dd/yyyy"),
                                                                      dd.DD_VALUE.ToString(),
                                                                      dd.DD_DOC);

                richDossiersTextBox.Text += FormatDetails(incomeOrExpence);
            }

        }

        private void dossierDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CancelEdit();
            ShowSelectedRowInformation(dossierDataGridView, dossierDataGridView.CurrentRow.Index);
        }

        private string FormatDetails(Transaction incomeOrExpence)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(transactDelimiter);
            sb.AppendLine($"Номер на транзакция: {incomeOrExpence.Id}");
            sb.AppendLine($"Тип: {incomeOrExpence.Type}");
            sb.AppendLine($"Вид: {incomeOrExpence.Name}");
            sb.AppendLine($"Дата: {incomeOrExpence.Date} г.");
            sb.AppendLine($"Сума: {incomeOrExpence.Value} лв.");
            sb.AppendLine($"Документ: {incomeOrExpence.Description}");
            sb.AppendLine(transactDelimiter);


            return sb.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CancelEdit();
            hiddenForms = new List<Form>();
            EditTransaction frm = new EditTransaction();
            frm.MdiParent = this.MdiParent;
            hiddenForms.Add(this);
            this.Hide();
            frm.Show();
        }

        private void newTransact_Click(object sender, EventArgs e)
        {
            CancelEdit();
            hiddenForms = new List<Form>();
            AddTransaction frm = new AddTransaction();
            frm.MdiParent = this.MdiParent;
            hiddenForms.Add(this);
            this.Hide();
            frm.Show();
        }

        private void changeStatusBtn_Click(object sender, EventArgs e)
        {
            string message = "Сигруни ли сте, че искате да приключите досието?";
            string title = "Приключване на досие";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                dOSSIERTableAdapter.UpdateStatus("C", Decimal.Parse(dossierId));

                dossierDataGridView.CurrentRow.Cells[1].Value = "Приключено";

                btnEdit.Visible = false;
                newTransact.Visible = false;
                changeStatusBtn.Visible = false;
                editDossierBtn.Visible = false;

                CheckForOpenDossiers(dOSSIERTableAdapter
                                    .GetData().Where(x => x.CLIENT_ID == decimal.Parse(clientId)).ToList());
            }
            
        }

        private void editDossierBtn_Click(object sender, EventArgs e)
        {
            dossierDateTimePicker.Enabled = true;
            minBalanceTextBox.Enabled = true;

            changeStatusBtn.Visible = false;
            editDossierBtn.Visible = false;
            saveDossierBtn.Visible = true;
            cancelEditDossierBtn.Visible = true;
        }

        private void saveDossierBtn_Click(object sender, EventArgs e)
        {
            errorProviderDossier.Clear();
            if (IsDossierValid())
            {
                decimal? balance = null;

                dOSSIERTableAdapter
                    .UpdateDossier(dossierDateTimePicker.Value.Year,
                                   (IsValueNull(minBalanceTextBox.Text) ? balance : Decimal.Parse(minBalanceTextBox.Text)),
                                   Decimal.Parse(dossierId));

                if (IsValueNull(minBalanceTextBox.Text))
                {
                    minBalanceTextBox.Text = "Няма";
                }

                dossierDateTimePicker.Enabled = false;
                minBalanceTextBox.Enabled = false;

                changeStatusBtn.Visible = true;
                editDossierBtn.Visible = true;
                saveDossierBtn.Visible = false;
                cancelEditDossierBtn.Visible = false;

                var index = dossierDataGridView.CurrentRow.Index;

                RefreshGridView();

                dossierDataGridView.Rows[index].Selected = true;

                AutoClosingMessageBox.Show("Редакцията е успешна", "Редакция на досие", 1000);
            }
        }

        private void cancelEditDossierBtn_Click(object sender, EventArgs e)
        {
            errorProviderDossier.Clear();
            var dossier = dOSSIERTableAdapter
                .GetData().FirstOrDefault(x => x.DOSSIER_NO == Decimal.Parse(dossierId));

            DateTime date;
            DateTime.TryParseExact(dossier.DOSSIER_YEAR.ToString(),
                                   "yyyy",
                                   CultureInfo.InvariantCulture,
                                   DateTimeStyles.None,
                                   out date);
            dossierDateTimePicker.Value = date;
            minBalanceTextBox.Text =
                IsValueNull(dossier.DOSSIER_MIN_BALANCE.ToString()) ? "Няма" : dossier.DOSSIER_MIN_BALANCE.ToString();

            dossierDateTimePicker.Enabled = false;
            minBalanceTextBox.Enabled = false;

            changeStatusBtn.Visible = true;
            editDossierBtn.Visible = true;
            saveDossierBtn.Visible = false;
            cancelEditDossierBtn.Visible = false;
        }

        private void addDossier_Click(object sender, EventArgs e)
        {
            hiddenForms = new List<Form>();
            AddDossier frm = new AddDossier();
            frm.MdiParent = this.MdiParent;
            hiddenForms.Add(this);
            this.Hide();
            frm.Show();
        }

        private void CheckForOpenDossiers(List<PersonalFinancesDataSet1.DOSSIERRow> dossiers)
        {
            if (dossiers.Any(x => x.DOSSIER_STATUS == "O"))
            {
                addDossier.Visible = false;
            }
            else
            {
                addDossier.Visible = true;
            }
        }

        private bool IsDossierValid()
        {
            var isValid = true;

            if (currYear != dossierDateTimePicker.Value.Year && dOSSIERTableAdapter
                .GetData()
                .Any(x => x.CLIENT_ID == Decimal.Parse(clientId) && x.DOSSIER_YEAR == dossierDateTimePicker.Value.Year))
            {
                errorProviderDossier.SetError(dossierDateTimePicker, "Вече има досие за тази отчетна година");
                isValid = false;
            }
            if((minBalanceTextBox.Text != string.Empty && minBalanceTextBox.Text != "Няма") && !Regex.IsMatch(minBalanceTextBox.Text, valuePattern))
            {
                errorProviderDossier
                    .SetError(minBalanceTextBox, "Може да бъде празно или в интервала [-9999999999.99 - 9999999999.99]");
                isValid = false;
            }

            return isValid;
        }

        private void ClientDetails_VisibleChanged(object sender, EventArgs e)
        {
            RefreshGridView();

            foreach (DataGridViewRow row in dossierDataGridView.Rows)
            {
                row.Cells[1].Value =  row.Cells[1].Value.ToString() == "O" ? "Отворено" : "Приключено";
            }

            CheckForOpenDossiers(dOSSIERTableAdapter.GetData().Where(x=> x.CLIENT_ID == Decimal.Parse(clientId)).ToList());

            if (dossierId != null && dossierDataGridView.Rows[0].Cells[0].Value != null)
            {
                for (int i = 0; i < dossierDataGridView.RowCount; i++)
                {
                    if (dossierDataGridView.Rows[i].Cells[0].Value.ToString() == dossierId)
                    {
                        dossierDataGridView.Rows[i].Selected = true;
                        ShowSelectedRowInformation(dossierDataGridView, i);
                        break;
                    }
                }
            }
        }

        private int GetIndex(string searchedDossierNo)
        {
            for (int i = 0; i < dossierDataGridView.RowCount; i++)
            {
                if (dossierDataGridView.Rows[i].Cells[0].Value.ToString() == searchedDossierNo)
                {
                    return i;
                }
            }
            return 0;
        }

        private void RefreshGridView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("DOSSIER_STATUS like '%{0}%'", "");
            dOSSIERBindingSource.Filter = sb.ToString();
            dOSSIERTableAdapter.Fill(this.personalFinancesDataSet.DOSSIER);
        }

        private void CheckForTransactions(string dossierNo)
        {
            if(dOSSIER_DETAILSTableAdapter.GetData().Any(x=> x.DOSSIER_NO.ToString() == dossierNo))
            {
                btnEdit.Visible = true;
            }
            else
            {
                btnEdit.Visible = false;
            }
        }

        private void CancelEdit()
        {
            cancelEditDossierBtn_Click(cancelEditDossierBtn, new EventArgs());
        }

        private void editBtn_MouseHover(object sender, EventArgs e)
        {
            editBtn.BackColor = Color.RoyalBlue;
        }

        private void editBtn_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(editBtn);
        }

        private void cancelBtn_MouseHover(object sender, EventArgs e)
        {
            cancelBtn.BackColor = Color.Red;
        }

        private void cancelBtn_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(cancelBtn);
        }

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = Color.LimeGreen;
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(saveBtn);
        }

        private void saveDossierBtn_MouseHover(object sender, EventArgs e)
        {
            saveDossierBtn.BackColor = Color.LimeGreen;
        }

        private void saveDossierBtn_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(saveDossierBtn);
        }

        private void cancelEditDossierBtn_MouseHover(object sender, EventArgs e)
        {
            cancelEditDossierBtn.BackColor = Color.Red;
        }

        private void cancelEditDossierBtn_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(cancelEditDossierBtn);
        }

        private void editDossierBtn_MouseHover(object sender, EventArgs e)
        {
            editDossierBtn.BackColor = Color.RoyalBlue;
        }

        private void editDossierBtn_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(editDossierBtn);
        }

        private void changeStatusBtn_MouseHover(object sender, EventArgs e)
        {
            changeStatusBtn.BackColor = Color.Red;
        }

        private void changeStatusBtn_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(changeStatusBtn);
        }

        private void newTransact_MouseHover(object sender, EventArgs e)
        {
            newTransact.BackColor = Color.RoyalBlue;
        }

        private void newTransact_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(newTransact);
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.RoyalBlue;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(btnEdit);
        }

        private void addDossier_MouseHover(object sender, EventArgs e)
        {
            addDossier.BackColor = Color.RoyalBlue;
        }

        private void addDossier_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(addDossier);
        }
    }
}
