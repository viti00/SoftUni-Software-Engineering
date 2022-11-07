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
    public partial class AddTransaction : Form
    {
        public AddTransaction()
        {
            InitializeComponent();
            SetFormLocation(this);
        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {
            FillTransactionsNameComboBox(iNCOME_EXPNECETableAdapter, nameComboBox);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (IsTransactionValid())
            {
                var dossierTableAdapter = tableAdapterManager.DOSSIERTableAdapter;
                var transaction = GetTransaction(iNCOME_EXPNECETableAdapter, nameComboBox.Text, typeComboBox.Text);

                if (transaction == null)
                {
                    CreateTransaction(iNCOME_EXPNECETableAdapter, nameComboBox.Text, typeComboBox.Text);

                    transaction = GetTransaction(iNCOME_EXPNECETableAdapter, nameComboBox.Text, typeComboBox.Text);
                }

                var dossier = dossierTableAdapter.GetData().FirstOrDefault(x => x.DOSSIER_NO.ToString() == dossierId);

                if (transaction.INCEXP_TYPE == "I")
                {
                    dossierTableAdapter
                        .UpdateCurrentBalance(dossier.DOSSIER_CURRENT_BALANCE + Decimal.Parse(valueTextBox.Text), Decimal.Parse(dossierId));
                }
                else
                {
                    if (dossier.DOSSIER_MIN_BALANCE != null)
                    {
                        if (dossier.DOSSIER_CURRENT_BALANCE - Decimal.Parse(valueTextBox.Text) > dossier.DOSSIER_MIN_BALANCE)
                        {
                            dossierTableAdapter
                                .UpdateCurrentBalance(dossier.DOSSIER_CURRENT_BALANCE - Decimal.Parse(valueTextBox.Text), Decimal.Parse(dossierId));
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
                                .UpdateCurrentBalance(dossier.DOSSIER_CURRENT_BALANCE - Decimal.Parse(valueTextBox.Text), Decimal.Parse(dossierId));
                    }
                }

                dOSSIER_DETAILSTableAdapter
                    .Insert(Decimal.Parse(dossierId),
                            transaction.INCEXP_ID, dateDateTimePicker.Value,
                            Decimal.Parse(valueTextBox.Text),
                            docTextBox.Text);

                this.Close();
            }
        }

        private bool IsTransactionValid()
        {
            var isValid = true;
            if(nameComboBox.Text == string.Empty)
            {
                errorProvider.SetError(nameComboBox, "Полето е задължително");
                isValid = false;
            }
            if(typeComboBox.Text == string.Empty)
            {
                errorProvider.SetError(typeComboBox, "Полето е задължително");
                isValid=false;
            }
            if(IsValueNull(valueTextBox.Text))
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

        private void AddTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            SearchForm(clientDetailsFormName, hiddenForms);
        }
    }
}
