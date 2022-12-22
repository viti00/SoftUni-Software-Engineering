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

namespace PersonalFinances.Forms
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
            SetFormLocation(this);
            searchComboBox.SelectedIndex = 0;
        }

        private void cLIENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personalFinancesDataSet);
        }

        private void cLIENTBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personalFinancesDataSet);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            this.cLIENTTableAdapter.Fill(this.personalFinancesDataSet.CLIENT); 
        }

        private void clientsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clientsDataGridView.Columns["View"].Index && e.RowIndex >= 0)
            {
                clientId = clientsDataGridView.SelectedCells[0].Value.ToString();

                var clientDetails = new ClientDetails();
                clientDetails.MdiParent = this.MdiParent;
                previousForm = this;
                this.Close();
                clientDetails.Show();
            }
        }

        private string SearchTerm()
        {
            StringBuilder sb = new StringBuilder();

            if (searchComboBox.Text == "Име")
            {
                sb.AppendFormat("CLIENT_NAME like '%{0}%'", searchTextBox.Text.ToLower());
            }
            else if (searchComboBox.Text == "Презиме")
            {
                sb.AppendFormat("CLIENT_SURNAME like '%{0}%'", searchTextBox.Text.ToLower());
            }
            else if (searchComboBox.Text == "Фамилия")
            {
                sb.AppendFormat("CLIENT_LASTNAME like '%{0}%'", searchTextBox.Text.ToLower());
            }
            else if (searchComboBox.Text == "ЕГН")
            {
                sb.AppendFormat("CLIENT_EGN like '%{0}%'", searchTextBox.Text.ToLower());
            }
            else if (searchComboBox.Text == "Имейл")
            {
                sb.AppendFormat("CLIENT_EMAIL like '%{0}%'", searchTextBox.Text.ToLower());
            }
            else if (searchComboBox.Text == "Телефон")
            {
                sb.AppendFormat("CLIENT_PHONE like '%{0}%'", searchTextBox.Text.ToLower());
            }
            return sb.ToString();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            cLIENTBindingSource.Filter = SearchTerm();
            cLIENTTableAdapter.Fill(personalFinancesDataSet.CLIENT);
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            AddClient frm = new AddClient();
            frm.MdiParent = this.MdiParent;
            this.Close();
            frm.Show();
        }
    }
}
