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
    public partial class frmOfficersList : Form
    {
        public frmOfficersList()
        {
            InitializeComponent();
        }

        private void officersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.officersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmOfficersList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Sectors' table. You can move, or remove it, as needed.
            this.sectorsTableAdapter.Fill(this.jailDataSet.Sectors);
            // TODO: This line of code loads data into the 'jailDataSet.Officers' table. You can move, or remove it, as needed.
            this.officersTableAdapter.Fill(this.jailDataSet.Officers);

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

        private void saveOfficers_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                officersTableAdapter.Update(this.jailDataSet);
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
            workbook.SaveAs($"{ExportConstant.path}officersListReports.xls");
            app.Quit();
        }
    }
}
