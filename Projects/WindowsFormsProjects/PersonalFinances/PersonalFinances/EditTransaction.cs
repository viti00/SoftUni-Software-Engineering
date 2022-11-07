using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonalFinances.GlobalVariables;
using static PersonalFinances.GlobalMethods;
using static PersonalFinances.GlobalConstants;

namespace PersonalFinances
{
    public partial class EditTransaction : Form
    {
        private static string currentTransactionNo;

        public EditTransaction()
        {
            InitializeComponent();
            SetFormLocation(this);
        }

        private void EditIncExpForm_Load(object sender, EventArgs e)
        {
            var dossierDetails = dOSSIER_DETAILSTableAdapter.GetDataBy1(Decimal.Parse(dossierId)).ToList();

            foreach (var dd in dossierDetails)
            {
                dossierDetailsIdComboBox.Items.Add(dd.DD_ID.ToString());
            }
        }

        private void dossierDetailsIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var transactionNo = dossierDetailsIdComboBox.Text;

            currentTransactionNo = transactionNo;

            var dossierDetail = dOSSIER_DETAILSTableAdapter.GetData().FirstOrDefault(x => x.DD_ID.ToString() == transactionNo);

            elementsGroupBox.Visible = true;

            var incExp = iNCOME_EXPNECETableAdapter.GetData().FirstOrDefault(x => x.INCEXP_ID == dossierDetail.INCEXP_ID);

            dateDateTimePicker.Value = dossierDetail.DD_DATE;
            valueTextBox.Text = dossierDetail.DD_VALUE.ToString();
            docTextBox.Text = dossierDetail.DD_DOC;

            FillTransactionsNameComboBox(iNCOME_EXPNECETableAdapter, nameComboBox);

            nameComboBox.SelectedItem = incExp.INCEXP_NAME;

            typeTextBox.Text = incExp.INCEXP_TYPE == "I" ? "Приход" : "Разход";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (IsTransactionValid())
            {
                var incomeExpence = GetTransaction(iNCOME_EXPNECETableAdapter, nameComboBox.Text, typeTextBox.Text);

                if (incomeExpence == null)
                {
                    CreateTransaction(iNCOME_EXPNECETableAdapter, nameComboBox.Text, typeTextBox.Text);

                    incomeExpence = GetTransaction(iNCOME_EXPNECETableAdapter, nameComboBox.Text, typeTextBox.Text);
                }
                dOSSIER_DETAILSTableAdapter.UpdateQuery(incomeExpence.INCEXP_ID,
                                                        dateDateTimePicker.Value.ToString(),
                                                        Decimal.Parse(valueTextBox.Text),
                                                        docTextBox.Text,
                                                        Decimal.Parse(currentTransactionNo));

                this.Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да изтриете транзакцията", "Изтриване", buttons);

            if(result == DialogResult.Yes)
            {
                dOSSIER_DETAILSTableAdapter.DeleteQuery(Decimal.Parse(currentTransactionNo));
                this.Close();
            }
        }

        private bool IsTransactionValid()
        {
            var isValid = true;
            if (nameComboBox.Text == string.Empty)
            {
                errorProvider.SetError(nameComboBox, "Полето е задължително");
                isValid = false;
            }
            if (IsValueNull(valueTextBox.Text))
            {
                errorProvider.SetError(valueTextBox, "Полето е задължително");
                isValid = false;
            }
            if (Decimal.Parse(valueTextBox.Text) < 0)
            {
                errorProvider.SetError(valueTextBox, "Стойността трябва да бъде по-голяма от 0");
                isValid = false;
            }

            return isValid;
        }

        private void EditIncExpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SearchForm(clientDetailsFormName, hiddenForms);
        }
    }
}
