using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static PersonalFinances.Common.GlobalVariables;
using static PersonalFinances.Common.GlobalConstants;
using static PersonalFinances.Common.GlobalMethods;
using PersonalFinances.Common;

namespace PersonalFinances.Forms
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
            yearDateTimePicker.Format = DateTimePickerFormat.Custom;
            yearDateTimePicker.CustomFormat = "yyyy";
            yearDateTimePicker.Value = DateTime.Now;
            yearDateTimePicker.ShowUpDown = true;
            dossierStatusTextBox.Text = "Отворено";
            SetFormLocation(this);
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            var isSuccsess = true;
            decimal newClientId = -1m;

            if (IsValid())
            {
                try
                {
                    cLIENTTableAdapter
                    .Insert(EGNTextBox.Text, nameTextBox.Text, middleNameTextBox.Text,
                            lastnameTextBox.Text, emailTextBox.Text, phoneTextBox.Text);

                    var client = cLIENTTableAdapter.GetData().FirstOrDefault(x => x.CLIENT_EGN == EGNTextBox.Text);

                    newClientId = client.CLIENT_ID;

                    aDDRESSTableAdapter
                        .Insert(newClientId, addressTypeComboBox.Text == "Постоянен адрес" ? "P" : "K", addressRegionTextBox.Text, addressMunicipalityTextBox.Text,
                                addressPlaceTextBox.Text, addressPostCodeTextBox.Text, addressTextBox.Text);

                    decimal? minBalance = null;

                    if (dossierMinBalanceTextBox.Text.Length > 0)
                    {
                        minBalance = Decimal.Parse(dossierMinBalanceTextBox.Text);
                    }

                    dOSSIERTableAdapter
                        .Insert(newClientId, yearDateTimePicker.Value.Year,
                        dossierStatusTextBox.Text == "Отворено" ? "O" : "C", minBalance, 0);
                }
                catch (Exception ex)
                {
                    isSuccsess = false;
                    MessageBox.Show(ex.Message);
                    aDDRESSTableAdapter.DeleteAddress(newClientId);
                    cLIENTTableAdapter.DeleteClient(newClientId);
                }

                if (isSuccsess)
                {
                    clientId = newClientId.ToString();

                    AutoClosingMessageBox.Show("Регистрацията на клиент е успешна", "Регистрация на клиент", 1000);

                    ClientDetails frm = new ClientDetails();
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    this.Close();
                }

                
            }
        }

        private bool IsValid()
        {
            var isValid = true;

            if (!Regex.IsMatch(EGNTextBox.Text, egnPattern))
            {
                errorProvider.SetError(EGNTextBox, "ЕГН-то се състои от точно 10 цифри");
                isValid = false;
            }
            if (cLIENTTableAdapter.GetData().Any(x => x.CLIENT_EGN == EGNTextBox.Text))
            {
                errorProvider.SetError(EGNTextBox, "Вече има клиент с такова ЕГН");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                errorProvider.SetError(nameTextBox, "Полето е задължително");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(middleNameTextBox.Text))
            {
                errorProvider.SetError(middleNameTextBox, "Полето е задължително");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(lastnameTextBox.Text))
            {
                errorProvider.SetError(lastnameTextBox, "Полето е задължително");
                isValid = false;
            }
            if (!Regex.IsMatch(emailTextBox.Text, emailPattern))
            {
                errorProvider.SetError(emailTextBox, "Въведете валиден имейл адрес");
                isValid = false;
            }
            if (cLIENTTableAdapter.GetData().Any(x => x.CLIENT_EMAIL == emailTextBox.Text))
            {
                errorProvider.SetError(emailTextBox, "Вече има клиент с такъв имейл адрес");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(addressPostCodeTextBox.Text))
            {
                errorProvider.SetError(addressPostCodeTextBox, "Полето е задължително");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(addressPlaceTextBox.Text))
            {
                errorProvider.SetError(addressPlaceTextBox, "Полето е задължително");
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
            if(!Regex.IsMatch(dossierMinBalanceTextBox.Text, valuePattern))
            {
                errorProvider
                    .SetError(dossierMinBalanceTextBox, "Може да бъде празно или в интервала [-9999999999.99 - 9999999999.99]");
                isValid = false;
            }
            return isValid;
        }

        private void addClientButton_MouseHover(object sender, EventArgs e)
        {
            addClientButton.BackColor = Color.LimeGreen;
        }

        private void addClientButton_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(addClientButton);
        }
    }
}
