using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jail.master_details_forms
{
    public partial class frmPrisonersMails : Form
    {
        public frmPrisonersMails()
        {
            InitializeComponent();
        }

        private void prisonersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prisonersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmPrisonersMails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Mails' table. You can move, or remove it, as needed.
            this.mailsTableAdapter.Fill(this.jailDataSet.Mails);
            // TODO: This line of code loads data into the 'jailDataSet.Prisoners' table. You can move, or remove it, as needed.
            this.prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);

        }

        private void Export_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new
           Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add();

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;

            worksheet = workbook.Sheets[ExportConstant.sheetDefaultName];
            worksheet = workbook.ActiveSheet;

            worksheet.Name = "prisonersMails";

            for (int i = 1; i < mailsDataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = mailsDataGridView.Columns[i -
               1].HeaderText;
            }

            for (int i = 0; i < mailsDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < mailsDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] =
                    mailsDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs($"{ExportConstant.path}prisonersMails.xls");
            app.Quit();
        }
    }
}
