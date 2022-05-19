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
    public partial class frmCellsReport : Form
    {
        public frmCellsReport()
        {
            InitializeComponent();
        }

        private void cellsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cellsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmCellsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Sectors' table. You can move, or remove it, as needed.
            this.sectorsTableAdapter.Fill(this.jailDataSet.Sectors);
            // TODO: This line of code loads data into the 'jailDataSet.Cells' table. You can move, or remove it, as needed.
            this.cellsTableAdapter.Fill(this.jailDataSet.Cells);

        }

        private void OneParam_Click(object sender, EventArgs e)
        {
            changeButtonsVisible();
            makeOneSearchVisible();
        }

        private void MoreParams_Click(object sender, EventArgs e)
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
            else if (cellNumberLabel.Visible == true)
            {
                seacrhMoreParams();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.cellsBindingSource.CancelEdit();
            changeButtonsVisible();
            makeOneSearchInvisible();
            makeMoreSearchInvisible();
            makeSearchToReloadAllInformation();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cellsBindingSource.EndEdit();
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

            worksheet.Name = "Cells";

            for (int i = 1; i < cellsDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = cellsDataGridView.Columns[i -
               1].HeaderText;
            }

            for (int i = 0; i < cellsDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < cellsDataGridView.Columns.Count - 1; j++)
                {
                    worksheet.Cells[i + 2, j + 1] =
                   cellsDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs($"{ExportConstant.path}cellsReports.xls");
            app.Quit();
        }

        private void cellsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == cellsDataGridView.Columns["Delete"].Index)
            {
                const string message = "Are you sure you want to delete the item?";
                const string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.cellsTableAdapter.DeleteQuery(Convert.ToInt32(cellsDataGridView.Rows[e.RowIndex].Cells[0].Value));
                    this.cellsTableAdapter.Fill(this.jailDataSet.Cells);

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
            cellNumberLabel.Visible = true;
            cellNumberTextBox.Visible = true;
            sectorIdLabel.Visible = true;
            SectorIdComboBox.Visible = true;
        }
        private void makeMoreSearchInvisible()
        {
            cellNumberLabel.Visible = false;
            cellNumberTextBox.Visible = false;
            sectorIdLabel.Visible = false;
            SectorIdComboBox.Visible = false;
        }

        private void makeSearchToReloadAllInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CellNumber > {0}", 0);
            cellsBindingSource.Filter = sb.ToString();
            cellsTableAdapter.Fill(this.jailDataSet.Cells);
        }

        private void searchOneParam()
        {
            StringBuilder sb = new StringBuilder();

            if (decimal.TryParse(oneParamTextBox.Text, out decimal cellNumberValue))
            {
                sb.AppendFormat("CellNumber={0}", cellNumberValue);
            }

            if (decimal.TryParse(oneParamTextBox.Text, out decimal sectorIdValue))
            {
                sb.AppendFormat(" or SectorId={0}", sectorIdValue);
            }

            this.cellsBindingSource.Filter = sb.ToString();
            this.cellsTableAdapter.Fill(this.jailDataSet.Cells);
        }
        private void seacrhMoreParams()
        {
            StringBuilder sb = new StringBuilder();
            if (decimal.TryParse(cellNumberTextBox.Text, out decimal cellNumberValue))
            {
                sb.AppendFormat("CellNumber={0}", cellNumberValue);
            }

            if (SectorIdComboBox.SelectedIndex > -1)
            {
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.AppendFormat("SectorId = {0}", SectorIdComboBox.SelectedValue);
            }

            cellsBindingSource.Filter = sb.ToString();
            cellsTableAdapter.Fill(this.jailDataSet.Cells);
        }
    }
}
