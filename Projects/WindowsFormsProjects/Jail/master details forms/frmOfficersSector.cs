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
    public partial class frmOfficersSector : Form
    {
        public frmOfficersSector()
        {
            InitializeComponent();
        }

        private void sectorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sectorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmOfficersSector_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Officers' table. You can move, or remove it, as needed.
            this.officersTableAdapter.Fill(this.jailDataSet.Officers);
            // TODO: This line of code loads data into the 'jailDataSet.Sectors' table. You can move, or remove it, as needed.
            this.sectorsTableAdapter.Fill(this.jailDataSet.Sectors);

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

            worksheet.Name = "officersSectors";

            for (int i = 1; i < officersDataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = officersDataGridView.Columns[i -
               1].HeaderText;
            }

            for (int i = 0; i < officersDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < officersDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] =
                    officersDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs($"{ExportConstant.path}officersSector.xls");
            app.Quit();
        }
    }
}
