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
    public partial class frmMailsReport : Form
    {
        public frmMailsReport()
        {
            InitializeComponent();
        }

        private void mailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmMailsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Prisoners' table. You can move, or remove it, as needed.
            this.prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);
            // TODO: This line of code loads data into the 'jailDataSet.Mails' table. You can move, or remove it, as needed.
            this.mailsTableAdapter.Fill(this.jailDataSet.Mails);

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
            else if (Description.Visible == true)
            {
                seacrhMoreParams();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.mailsBindingSource.CancelEdit();
            changeButtonsVisible();
            makeOneSearchInvisible();
            makeMoreSearchInvisible();
            makeSearchToReloadAllInformation();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mailsBindingSource.EndEdit();
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

            worksheet.Name = "Mails";

            for (int i = 1; i < mailsDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = mailsDataGridView.Columns[i -
               1].HeaderText;
            }

            for (int i = 0; i < mailsDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < mailsDataGridView.Columns.Count - 1; j++)
                {
                    worksheet.Cells[i + 2, j + 1] =
                   mailsDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs($"{ExportConstant.path}mailsReports.xls");
            app.Quit();
        }

        private void mailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == mailsDataGridView.Columns["Delete"].Index)
            {
                const string message = "Are you sure you want to delete the item?";
                const string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.mailsTableAdapter.DeleteQuery(Convert.ToInt32(mailsDataGridView.Rows[e.RowIndex].Cells[0].Value));
                    this.mailsTableAdapter.Fill(this.jailDataSet.Mails);
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
            Description.Visible = true;
            DescrtiptionTextBox.Visible = true;
            Sender.Visible = true;
            SenderTextBox.Visible = true;
            PrisonerId.Visible = true;
            prisonerIdComboBox.Visible = true;

        }
        private void makeMoreSearchInvisible()
        {
            Description.Visible = false;
            DescrtiptionTextBox.Visible = false;
            Sender.Visible = false;
            SenderTextBox.Visible = false;
            PrisonerId.Visible = false;
            prisonerIdComboBox.Visible = false;
        }

        private void makeSearchToReloadAllInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Description like '%{0}%'", "");
            mailsBindingSource.Filter = sb.ToString();
            mailsTableAdapter.Fill(this.jailDataSet.Mails);
        }

        private void searchOneParam()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Description like '%{0}%'", oneParamTextBox.Text);
            sb.AppendFormat(" or Sender like '%{0}%'", oneParamTextBox.Text);

            if (decimal.TryParse(oneParamTextBox.Text, out decimal value))
            {
                sb.AppendFormat(" or PrisonerId={0}", value);
            }

            mailsBindingSource.Filter = sb.ToString();
            mailsTableAdapter.Fill(this.jailDataSet.Mails);
        }
        private void seacrhMoreParams()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Description like '%{0}%'", DescrtiptionTextBox.Text);


            if (sb.Length > 0)
            {
                sb.Append(" AND ");
            }
            sb.AppendFormat("Sender like '%{0}%'", SenderTextBox.Text);

            if (prisonerIdComboBox.SelectedIndex > -1)
            {
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("PrisonerId = {0}", prisonerIdComboBox.SelectedValue);
            }

            mailsBindingSource.Filter = sb.ToString();
            mailsTableAdapter.Fill(this.jailDataSet.Mails);
        }
    }
}
