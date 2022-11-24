using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonalFinances.Common.GlobalVariables;
using static PersonalFinances.Common.GlobalMethods;
using static PersonalFinances.Common.GlobalConstants;
using PersonalFinances.Common;

namespace PersonalFinances.Forms
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
            FillTransactionNo(dOSSIER_DETAILSTableAdapter, dossierDetailsIdComboBox);
        }

        private void dossierDetailsIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var transactionNo = dossierDetailsIdComboBox.Text;

            currentTransactionNo = transactionNo;

            var dossierDetail = dOSSIER_DETAILSTableAdapter.GetData().FirstOrDefault(x => x.DD_ID.ToString() == transactionNo);

            if(dossierDetail != null)
            {
                elementsGroupBox.Visible = true;

                var incExp = iNCOME_EXPNECETableAdapter.GetData().FirstOrDefault(x => x.INCEXP_ID == dossierDetail.INCEXP_ID);

                dateDateTimePicker.Value = dossierDetail.DD_DATE;
                valueTextBox.Text = dossierDetail.DD_VALUE.ToString();
                docTextBox.Text = dossierDetail.DD_DOC;

                FillTransactionsNameComboBox(iNCOME_EXPNECETableAdapter, nameComboBox);

                nameComboBox.SelectedItem = incExp.INCEXP_NAME;

                typeTextBox.Text = incExp.INCEXP_TYPE == "I" ? "Приход" : "Разход";

                elementsGroupBox.Text = $"Досие № {dossierId} - Транзакция №{dossierDetail.DD_ID}";
            }
            else
            {
                elementsGroupBox.Visible = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            var dossier = dossierTableAdapter.GetData().FirstOrDefault(x => x.DOSSIER_NO.ToString() == dossierId);
            var transaction = dOSSIER_DETAILSTableAdapter.GetData().FirstOrDefault(x => x.DD_ID == Decimal.Parse(currentTransactionNo));

            if (IsTransactionValid())
            {
                var incomeExpence = GetTransaction(iNCOME_EXPNECETableAdapter, nameComboBox.Text, typeTextBox.Text);

                if (incomeExpence == null)
                {
                    CreateTransaction(iNCOME_EXPNECETableAdapter, nameComboBox.Text, typeTextBox.Text);

                    incomeExpence = GetTransaction(iNCOME_EXPNECETableAdapter, nameComboBox.Text, typeTextBox.Text);
                }
                if (incomeExpence.INCEXP_TYPE == "I")
                {
                    dossierTableAdapter
                        .UpdateCurrentBalance(dossier.DOSSIER_CURRENT_BALANCE - transaction.DD_VALUE + Decimal.Parse(valueTextBox.Text), Decimal.Parse(dossierId));
                }
                else
                {
                    if (dossier.DOSSIER_MIN_BALANCE != null)
                    {
                        if (dossier.DOSSIER_CURRENT_BALANCE - Decimal.Parse(valueTextBox.Text) > dossier.DOSSIER_MIN_BALANCE)
                        {
                            dossierTableAdapter
                                .UpdateCurrentBalance(dossier.DOSSIER_CURRENT_BALANCE + transaction.DD_VALUE - Decimal.Parse(valueTextBox.Text), Decimal.Parse(dossierId));
                        }
                        else
                        {
                            MessageBox.Show("Тази транзакция не е възможна, тъй като баланса пада под минималния");
                            return;
                        }
                    }
                    else
                    {
                        dossierTableAdapter
                                .UpdateCurrentBalance(dossier.DOSSIER_CURRENT_BALANCE + transaction.DD_VALUE - Decimal.Parse(valueTextBox.Text), Decimal.Parse(dossierId));
                    }
                }
                dOSSIER_DETAILSTableAdapter.UpdateQuery(incomeExpence.INCEXP_ID,
                                                        dateDateTimePicker.Value.ToString(),
                                                        Decimal.Parse(valueTextBox.Text),
                                                        docTextBox.Text,
                                                        Decimal.Parse(currentTransactionNo));

                AutoClosingMessageBox.Show("Редакцията е успешна", "Редакция на танзакция", 1000);

                this.Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да изтриете транзакцията", "Изтриване", buttons);

            if(result == DialogResult.Yes)
            {
                var transaction = dOSSIER_DETAILSTableAdapter.GetData().FirstOrDefault(x => x.DD_ID == Decimal.Parse(currentTransactionNo));

                dOSSIER_DETAILSTableAdapter.DeleteQuery(Decimal.Parse(currentTransactionNo));

                var dossier = dossierTableAdapter.GetData().FirstOrDefault(x => x.DOSSIER_NO.ToString() == dossierId);
                

                var incomeExpence = GetTransaction(iNCOME_EXPNECETableAdapter, nameComboBox.Text, typeTextBox.Text);

                if(incomeExpence.INCEXP_TYPE == "I")
                {
                    dossierTableAdapter
                                .UpdateCurrentBalance(dossier.DOSSIER_CURRENT_BALANCE - transaction.DD_VALUE, Decimal.Parse(dossierId));
                }
                else
                {
                    dossierTableAdapter
                                .UpdateCurrentBalance(dossier.DOSSIER_CURRENT_BALANCE + transaction.DD_VALUE, Decimal.Parse(dossierId));
                }

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
            if (Decimal.Parse(valueTextBox.Text) <= 0)
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

        private void cancelBtn_MouseHover(object sender, EventArgs e)
        {
            cancelBtn.BackColor = Color.RoyalBlue;
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

        private void deleteBtn_MouseHover(object sender, EventArgs e)
        {
            deleteBtn.BackColor = Color.Red;
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(deleteBtn);
        }

        private void dossierDetailsIdComboBox_TextUpdate(object sender, EventArgs e)
        {
            FillTransactionNo(dOSSIER_DETAILSTableAdapter, dossierDetailsIdComboBox);
            dossierDetailsIdComboBox.SelectionStart = dossierDetailsIdComboBox.Text.Length;
            dossierDetailsIdComboBox_SelectedIndexChanged(sender, e);
        }

        private void nameComboBox_TextUpdate(object sender, EventArgs e)
        {
            FillTransactionsNameComboBox(iNCOME_EXPNECETableAdapter, nameComboBox);
            nameComboBox.SelectionStart = nameComboBox.Text.Length;
        }
    }
}
