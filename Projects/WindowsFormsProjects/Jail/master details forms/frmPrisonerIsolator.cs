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
    public partial class frmPrisonerIsolator : Form
    {
        public frmPrisonerIsolator()
        {
            InitializeComponent();
        }

        private void prisonersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prisonersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmPrisonerIsolator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Isolator' table. You can move, or remove it, as needed.
            this.isolatorTableAdapter.Fill(this.jailDataSet.Isolator);
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

            worksheet.Name = "prisonersIsolator";

            for (int i = 1; i < isolatorDataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = isolatorDataGridView.Columns[i -
               1].HeaderText;
            }

            for (int i = 0; i < isolatorDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < isolatorDataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] =
                    isolatorDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs($"{ExportConstant.path}prisonerIsolator.xls");
            app.Quit();
        }
    }
}
