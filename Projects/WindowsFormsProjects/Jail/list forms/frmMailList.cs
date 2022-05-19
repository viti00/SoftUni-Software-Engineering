using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jail
{
    public partial class frmMailList : Form
    {
        public frmMailList()
        {
            InitializeComponent();
        }

        private void mailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmMailList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Prisoners' table. You can move, or remove it, as needed.
            this.prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);
            // TODO: This line of code loads data into the 'jailDataSet.Mails' table. You can move, or remove it, as needed.
            this.mailsTableAdapter.Fill(this.jailDataSet.Mails);

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

        private void saveMail_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                mailsTableAdapter.Update(this.jailDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!");
            }
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
            workbook.SaveAs($"{ExportConstant.path}mailsListReports.xls");
            app.Quit();
        }
    }
}
