using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jail.report_forms
{
    public partial class frmOfficersReport : Form
    {
        public frmOfficersReport()
        {
            InitializeComponent();
        }

        private void officersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.officersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmOfficersReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Sectors' table. You can move, or remove it, as needed.
            this.sectorsTableAdapter.Fill(this.jailDataSet.Sectors);
            // TODO: This line of code loads data into the 'jailDataSet.Officers' table. You can move, or remove it, as needed.
            this.officersTableAdapter.Fill(this.jailDataSet.Officers);

        }

        private void oneParam_Click(object sender, EventArgs e)
        {
            changeButtonsVisible();
            makeOneSearchVisible();
        }

        private void moreParam_Click(object sender, EventArgs e)
        {
            changeButtonsVisible();
            makeMoreSearchVisible();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (oneParamLabel.Visible == true)
            {
                searchOneParam();
            }
            else if (fullNameLabel.Visible == true)
            {
                seacrhMoreParams();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.officersBindingSource.CancelEdit();
            changeButtonsVisible();
            makeOneSearchInvisible();
            makeMoreSearchInvisible();
            makeSearchToReloadAllInformation();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.officersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);
        }

        private void ExcelExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new
           Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add();

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;

            worksheet = workbook.Sheets[ExportConstant.sheetDefaultName];
            worksheet = workbook.ActiveSheet;

            worksheet.Name = "Officers";

            for (int i = 1; i < officersDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = officersDataGridView.Columns[i -
               1].HeaderText;
            }

            for (int i = 0; i < officersDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < officersDataGridView.Columns.Count - 1; j++)
                {
                    worksheet.Cells[i + 2, j + 1] =
                   officersDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs($"{ExportConstant.path}officersReports.xls");
            app.Quit();
        }

        private void officersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == officersDataGridView.Columns["Delete"].Index)
            {
                const string message = "Are you sure you want to delete the item?";
                const string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    this.officersTableAdapter.DeleteQuery(Convert.ToInt32(officersDataGridView.Rows[e.RowIndex].Cells[0].Value));
                    this.officersTableAdapter.Fill(this.jailDataSet.Officers);
                }
            }
        }

        private void changeButtonsVisible()
        {
            if (oneParam.Visible == true)
            {
                oneParam.Visible = false;
                moreParam.Visible = false;
                Cancel.Visible = true;
                Search.Visible = true;
            }
            else
            {
                oneParam.Visible = true;
                moreParam.Visible = true;
                Cancel.Visible = false;
                Search.Visible = false;
            }
        }

        private void makeOneSearchVisible()
        {
            oneParamLabel.Visible = true;
            oneParamTextBox.Visible = true;
        }

        private void makeOneSearchInvisible()
        {
            oneParamLabel.Visible = false;
            oneParamTextBox.Visible = false;
        }

        private void makeMoreSearchVisible()
        {
            fullNameLabel.Visible = true;
            fullNameTextBox.Visible = true;
            Salary.Visible = true;
            salaryTextBox.Visible = true;
            Weapon.Visible = true;
            weaponTextBox.Visible = true;
            SectorId.Visible = true;
            sectorIdComboBox.Visible = true;
        }
        private void makeMoreSearchInvisible()
        {
            fullNameLabel.Visible = false;
            fullNameTextBox.Visible = false;
            Salary.Visible = false;
            salaryTextBox.Visible = false;
            Weapon.Visible = false;
            weaponTextBox.Visible = false;
            SectorId.Visible = false;
            sectorIdComboBox.Visible = false;
        }

        private void makeSearchToReloadAllInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("FullName like '%{0}%'", "");
            officersBindingSource.Filter = sb.ToString();
            officersTableAdapter.Fill(this.jailDataSet.Officers);
        }

        private void searchOneParam()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("FullName like '%{0}%'", oneParamTextBox.Text);

            sb.AppendFormat(" or Weapon like '%{0}%'", oneParamTextBox.Text);

            if (decimal.TryParse(oneParamTextBox.Text, out decimal value))
            {
                sb.AppendFormat(" or Salary={0}", value);
                sb.AppendFormat(" or SectorId={0}", value);
            }

            this.officersBindingSource.Filter = sb.ToString();
            this.officersTableAdapter.Fill(this.jailDataSet.Officers);
        }
        private void seacrhMoreParams()
        {
            StringBuilder sb = new StringBuilder();
            if (decimal.TryParse(fullNameTextBox.Text, out decimal fullNameValue))
            {
                sb.AppendFormat("FullName like '%{0}%'", fullNameValue);
            }

            if (decimal.TryParse(salaryTextBox.Text, out decimal salaryValue))
            {
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("Salary ={0}", salaryValue);
            }

            if (sb.Length > 0)
            {
                sb.Append(" AND ");
            }
            sb.AppendFormat("Weapon like '%{0}%'", weaponTextBox.Text);

            if (sectorIdComboBox.SelectedIndex > -1)
            {
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("SectorId = {0}", sectorIdComboBox.SelectedValue);
            }

            officersBindingSource.Filter = sb.ToString();
            officersTableAdapter.Fill(this.jailDataSet.Officers);
        }
    }
}
