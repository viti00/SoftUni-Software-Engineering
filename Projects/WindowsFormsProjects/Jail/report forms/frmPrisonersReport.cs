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
    public partial class frmPrisonersReport : Form
    {
        public frmPrisonersReport()
        {
            InitializeComponent();
        }

        private void prisonersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prisonersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmPrisonersReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Cells' table. You can move, or remove it, as needed.
            this.cellsTableAdapter.Fill(this.jailDataSet.Cells);
            // TODO: This line of code loads data into the 'jailDataSet.Prisoners' table. You can move, or remove it, as needed.
            this.prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);

        }

        private void oneParam_Click(object sender, EventArgs e)
        {
            changeButtonsVisible();
            makeOneSearchVisible();
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

        private void moreParam_Click(object sender, EventArgs e)
        {
            changeButtonsVisible();
            makeMoreSearchVisible();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.prisonersBindingSource.CancelEdit();
            changeButtonsVisible();
            makeOneSearchInvisible();
            makeMoreSearchInvisible();
            makeSearchToReloadAllInformation();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.prisonersBindingSource.EndEdit();
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

            worksheet.Name = "Prisoners";

            for (int i = 1; i < prisonersDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = prisonersDataGridView.Columns[i -
               1].HeaderText;
            }

            for (int i = 0; i < prisonersDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < prisonersDataGridView.Columns.Count - 1; j++)
                {
                    worksheet.Cells[i + 2, j + 1] =
                   prisonersDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs($"{ExportConstant.path}prisonersReports.xls");
            app.Quit();
        }

        private void prisonersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == prisonersDataGridView.Columns["Delete"].Index)
            {
                const string message = "Are you sure you want to delete the item?";
                const string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    this.prisonersTableAdapter.DeleteQuery(Convert.ToInt32(prisonersDataGridView.Rows[e.RowIndex].Cells[0].Value));
                    this.prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);
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
            prisonerNumber.Visible = true;
            prisonerNumberTextBox.Visible = true;
            age.Visible = true;
            ageTextBox.Visible = true;
            cellId.Visible = true;
            cellIdComboBox.Visible = true;
        }
        private void makeMoreSearchInvisible()
        {
            fullNameLabel.Visible = false;
            fullNameTextBox.Visible = false;
            prisonerNumber.Visible = false;
            prisonerNumberTextBox.Visible = false;
            age.Visible = false;
            ageTextBox.Visible = false;
            cellId.Visible = false;
            cellIdComboBox.Visible = false;
        }

        private void makeSearchToReloadAllInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("FullName like '%{0}%'", "");
            prisonersBindingSource.Filter = sb.ToString();
            prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);
        }

        private void searchOneParam()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("FullName like '%{0}%'", oneParamTextBox.Text);

            if (decimal.TryParse(oneParamTextBox.Text, out decimal value))
            {
                sb.AppendFormat(" or Age={0}", value);
                sb.AppendFormat(" or PrisonerNumber={0}", value);
                sb.AppendFormat(" or CellId={0}", value);
            }

            this.prisonersBindingSource.Filter = sb.ToString();
            this.prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);
        }
        private void seacrhMoreParams()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("FullName like '%{0}%'", fullNameTextBox.Text);

            if (decimal.TryParse(prisonerNumberTextBox.Text, out decimal prisonerNumberValue))
            {
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("PrisonerNumber ={0}", prisonerNumberValue);
            }

            if (decimal.TryParse(ageTextBox.Text, out decimal ageValue))
            {
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("Age ={0}", ageValue);
            }

            if (cellIdComboBox.SelectedIndex > -1)
            {
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("CellId = {0}", cellIdComboBox.SelectedValue);
            }

            prisonersBindingSource.Filter = sb.ToString();
            prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);
        }
    }
}
