using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonalFinances.GlobalConstants;
using static PersonalFinances.GlobalVariables;

namespace PersonalFinances
{
    public static class GlobalMethods
    {
        public static Form GetForm(string formName)
            => Application.OpenForms.Cast<Form>().Where(f => f.Name == formName).FirstOrDefault();

        public static Control GetControl(Form form, string controlName)
            => form.Controls.Find(controlName, true).FirstOrDefault();

        public static TabControl GetTabControl(Form form)
            => form.Controls.OfType<TabControl>().FirstOrDefault();

        public static PersonalFinancesDataSet1.INCOME_EXPNECERow GetTransaction(PersonalFinancesDataSet1TableAdapters.INCOME_EXPNECETableAdapter adapter, string name, string type)
            => adapter.GetData()
                .FirstOrDefault(x => x.INCEXP_NAME == name
                                && x.INCEXP_TYPE == (type == "Приход" ? "I" : "C"));

        public static void CreateTransaction(PersonalFinancesDataSet1TableAdapters.INCOME_EXPNECETableAdapter adapter, string name, string type)
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

        public static void FillTransactionsNameComboBox(PersonalFinancesDataSet1TableAdapters.INCOME_EXPNECETableAdapter adapter, ComboBox comboBox)
        {
            var transactions = adapter.GetData().ToList();

            foreach (var transaction in transactions)
            {
                comboBox.Items.Add(transaction.INCEXP_NAME);
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
    }
}
