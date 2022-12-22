using PersonalFinances.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonalFinances.Common.GlobalConstants;
using static PersonalFinances.Common.GlobalVariables;

namespace PersonalFinances.Common
{
    public static class GlobalMethods
    {
        public static Form GetForm(string formName)
            => Application.OpenForms.Cast<Form>().Where(f => f.Name == formName).FirstOrDefault();

        public static Control GetControl(Form form, string controlName)
            => form.Controls.Find(controlName, true).FirstOrDefault();

        public static TabControl GetTabControl(Form form)
            => form.Controls.OfType<TabControl>().FirstOrDefault();

        public static PersonalFinancesDataSet1.INCOME_EXPNECERow GetTransaction(Data.PersonalFinancesDataSet1TableAdapters.INCOME_EXPNECETableAdapter adapter, string name, string type)
            => adapter.GetData()
                .FirstOrDefault(x => x.INCEXP_NAME == name
                                && x.INCEXP_TYPE == (type == "Приход" ? "I" : "C"));

        public static void CreateTransaction(Data.PersonalFinancesDataSet1TableAdapters.INCOME_EXPNECETableAdapter adapter, string name, string type)
        {
            adapter.Insert(name, (type == "Приход" ? "I" : "C"));
        }

        public static bool IsValueNull(string value)
        {
            if (value == string.Empty
                || value.ToString() == "Няма"
                || !Regex.IsMatch(value, valuePattern))
            {
                return true;
            }

            return false;
        }

        public static void FillTransactionsNameComboBox(Data.PersonalFinancesDataSet1TableAdapters.INCOME_EXPNECETableAdapter adapter, ComboBox comboBox)
        {
            var transactions = adapter.GetData().ToList();

            if (!string.IsNullOrEmpty(comboBox.Text))
            {
                transactions = adapter.GetData().Where(t => t.INCEXP_NAME.ToLower().Contains(comboBox.Text.ToLower())).ToList();
                comboBox.Items.Clear();
                if(transactions.Count == 0)
                {
                    comboBox.Items.Add(comboBox.Text);
                }
            }

            foreach (var transaction in transactions)
            {
                comboBox.Items.Add(transaction.INCEXP_NAME);
            }
        }

        public static void FillTransactionNo(Data.PersonalFinancesDataSet1TableAdapters.DOSSIER_DETAILSTableAdapter adapter, ComboBox comboBox)
        {
            var dossiers = adapter.GetDataBy1(Decimal.Parse(dossierId)).ToList();

            if (!string.IsNullOrEmpty(comboBox.Text) && comboBox.Text.All(char.IsDigit))
            {
                dossiers = adapter.GetData().Where(t =>t.DOSSIER_NO == Decimal.Parse(dossierId) && t.DD_ID.ToString().ToLower().Contains(comboBox.Text.ToLower())).ToList();
                comboBox.Items.Clear();
                if(dossiers.Count == 0)
                {
                    comboBox.Items.Add(comboBox.Text);
                }
            }
            foreach (var dossier in dossiers)
            {
                comboBox.Items.Add(dossier.DD_ID);
            }
        }

        public static void SearchForm(string formName, List<Form> forms)
        {
            foreach (Form f in forms)
            {
                if (f.Name.Equals(formName))
                {
                    f.Refresh();
                    f.Show();
                    break;
                }
            }
        }

        public static void SetFormLocation(Form form)
        {
            form.Location = new Point(0, 90);
        }

        public static void DefaultBackColor(Button button)
        {
            button.BackColor = Control.DefaultBackColor;
        }
    }
}
