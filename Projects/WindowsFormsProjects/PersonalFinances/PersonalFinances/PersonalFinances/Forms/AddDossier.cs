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
    public partial class AddDossier : Form
    {
        public AddDossier()
        {
            InitializeComponent();
            dossierDateTimePicker.Format = DateTimePickerFormat.Custom;
            dossierDateTimePicker.CustomFormat = "yyyy";
            dossierDateTimePicker.ShowUpDown = true;
            dossierDateTimePicker.Value = DateTime.Now;
            SetFormLocation(this);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (IsDossierValid())
            {
                decimal? balance = null;

                string message = "Сигурни ли сте, че искате да добавите ново досие?";
                string title = "Добавяне на досие";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    dOSSIERTableAdapter
                    .Insert(Decimal.Parse(clientId),
                            dossierDateTimePicker.Value.Year,
                            "O",
                            (IsValueNull(minBalanceTextBox.Text) ? balance : Decimal.Parse(minBalanceTextBox.Text)),
                            0);

                    dOSSIERTableAdapter.Fill(personalFinancesDataSet1.DOSSIER);

                    AutoClosingMessageBox.Show("Добавянето на досие е успешно", "Добавяне досие", 1000);

                    this.Close();
                }
            }
        }

        private void AddDossier_FormClosed(object sender, FormClosedEventArgs e)
        {

            SearchForm(clientDetailsFormName, hiddenForms);
        }

        private bool IsDossierValid()
        {
            var isValid = true;

            if (dOSSIERTableAdapter
                .GetData()
                .Any(x => x.CLIENT_ID == Decimal.Parse(clientId) && x.DOSSIER_YEAR == dossierDateTimePicker.Value.Year))
            {
                errorProvider.SetError(dossierDateTimePicker, "Вече има досие за тази отчетна година");
                isValid = false;
            }

            return isValid;
        }

        private void createBtn_MouseHover(object sender, EventArgs e)
        {
            createBtn.BackColor = Color.LimeGreen;
        }

        private void createBtn_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(createBtn);
        }
    }
}
