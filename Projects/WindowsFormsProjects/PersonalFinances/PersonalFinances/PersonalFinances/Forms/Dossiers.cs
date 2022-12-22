using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonalFinances.Common.GlobalMethods;
using static PersonalFinances.Common.GlobalVariables;
using static PersonalFinances.Common.GlobalConstants;

namespace PersonalFinances.Forms
{
    public partial class Dossiers : Form
    {
        DataTable dt = new DataTable();
        BindingSource bs;
        SqlDataAdapter da;

        public Dossiers()
        {
            InitializeComponent();
            SetFormLocation(this);

        }
        private void Dossiers_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT d.DOSSIER_NO AS [Досие №],d.DOSSIER_YEAR AS[Отчетна година],IIF(d.DOSSIER_STATUS = 'O','Отворено', 'Приключено') AS[Статус],CONCAT(c.CLIENT_NAME, ' ', c.CLIENT_SURNAME, ' ', c.CLIENT_LASTNAME) AS[Три имена],c.CLIENT_EGN AS[ЕГН] FROM DOSSIER AS d JOIN CLIENT AS c ON c.CLIENT_ID = d.CLIENT_ID";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();

            da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            bs = new BindingSource();
            bs.DataSource = dt;

            dataGridView.DataSource = dt;
            dataGridView.Columns["View"].DisplayIndex = dataGridView.Columns.Count - 1;
            dataGridView.Columns[4].MinimumWidth = 250;
            con.Close();
        }

        private string SearchTerm()
        {
            StringBuilder sb = new StringBuilder();

            if (searchComboBox.Text == "Име")
            {
                sb.AppendFormat("[Три имена] like '%{0}%'", searchTextBox.Text.ToLower()); ;
            }
            else if (searchComboBox.Text == "ЕГН")
            {
                sb.AppendFormat("[ЕГН] like '%{0}%'", searchTextBox.Text);
            }
            else if (searchComboBox.Text == "Досие №")
            {
                if(searchTextBox.Text != string.Empty && Regex.IsMatch(searchTextBox.Text, numberPattern))
                {
                    sb.AppendFormat("[Досие №] = {0}", Decimal.Parse(searchTextBox.Text));
                }
                else
                {
                    sb.AppendFormat("[Досие №] <> {0}",-1);
                }
            }
            else if (searchComboBox.Text == "Досие статус")
            {
                sb.AppendFormat("[Статус] like '%{0}%'", searchTextBox.Text.ToLower());
            }
            else if (searchComboBox.Text == "Отчетна година")
            {
                if(searchTextBox.Text != string.Empty && Regex.IsMatch(searchTextBox.Text, numberPattern))
                {
                    sb.AppendFormat("[Отчетна година] = {0}", Decimal.Parse(searchTextBox.Text));
                }
                else
                {
                    sb.AppendFormat("[Отчетна година] <> {0}", -1);
                }
            }

            return sb.ToString();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["View"].Index && e.RowIndex >= 0)
            {
                dossierId = dataGridView.CurrentRow.Cells["Досие №"].Value.ToString();

                clientId = cLIENTTableAdapter
                    .GetData()
                    .FirstOrDefault(x => x.CLIENT_EGN == dataGridView.CurrentRow.Cells["ЕГН"].Value.ToString()).CLIENT_ID.ToString();

                ClientDetails frm = new ClientDetails();
                frm.MdiParent = this.MdiParent;
                previousForm = this;
                this.Close();
                TabControl tabPage = GetTabControl(frm);
                tabPage.SelectedIndex = 1;
                frm.Show();
                
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = SearchTerm();
            dataGridView.DataSource = dt;
        }
    }
}
