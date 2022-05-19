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
    public partial class frmIsolatorReport : Form
    {
        public frmIsolatorReport()
        {
            InitializeComponent();
        }

        private void isolatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.isolatorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmIsolatorReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Prisoners' table. You can move, or remove it, as needed.
            this.prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);
            // TODO: This line of code loads data into the 'jailDataSet.Isolator' table. You can move, or remove it, as needed.
            this.isolatorTableAdapter.Fill(this.jailDataSet.Isolator);

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
            else if (Reason.Visible == true)
            {
                seacrhMoreParams();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.isolatorBindingSource.CancelEdit();
            changeButtonsVisible();
            makeOneSearchInvisible();
            makeMoreSearchInvisible();
            makeSearchToReloadAllInformation();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.isolatorBindingSource.EndEdit();
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

            worksheet.Name = "Isolator";

            for (int i = 1; i < isolatorDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = isolatorDataGridView.Columns[i -
               1].HeaderText;
            }

            for (int i = 0; i < isolatorDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < isolatorDataGridView.Columns.Count - 1; j++)
                {
                    worksheet.Cells[i + 2, j + 1] =
                   isolatorDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs($"{ExportConstant.path}isolatorReports.xls");
            app.Quit();
        }

        private void isolatorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == isolatorDataGridView.Columns["Delete"].Index)
            {
                const string message = "Are you sure you want to delete the item?";
                const string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.isolatorTableAdapter.DeleteQuery(Convert.ToInt32(isolatorDataGridView.Rows[e.RowIndex].Cells[0].Value));
                    this.isolatorTableAdapter.Fill(this.jailDataSet.Isolator);
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
            PrisonerId.Visible = true;
            prisonerIdComboBox.Visible = true;
            Reason.Visible = true;
            reasonTextBox.Visible = true;

        }
        private void makeMoreSearchInvisible()
        {
            PrisonerId.Visible = false;
            prisonerIdComboBox.Visible = false;
            Reason.Visible = false;
            reasonTextBox.Visible = false;
        }

        private void makeSearchToReloadAllInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Reason like '%{0}%'", "");
            isolatorBindingSource.Filter = sb.ToString();
            isolatorTableAdapter.Fill(this.jailDataSet.Isolator);
        }

        private void searchOneParam()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Reason like '%{0}%'", oneParamTextBox.Text);

            if (decimal.TryParse(oneParamTextBox.Text, out decimal value))
            {
                sb.AppendFormat(" or PrisonerId={0}", value);
            }

            isolatorBindingSource.Filter = sb.ToString();
            isolatorTableAdapter.Fill(this.jailDataSet.Isolator);
        }
        private void seacrhMoreParams()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Reason like '%{0}%'", reasonTextBox.Text);

            if (prisonerIdComboBox.SelectedIndex > -1)
            {
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("PrisonerId = {0}", prisonerIdComboBox.SelectedValue);
            }

            isolatorBindingSource.Filter = sb.ToString();
            isolatorTableAdapter.Fill(this.jailDataSet.Isolator);
        }
    }
}
