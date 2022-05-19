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
    public partial class frmSectorsReport : Form
    {
        public frmSectorsReport()
        {
            InitializeComponent();
        }

        private void sectorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sectorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmSectorsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Sectors' table. You can move, or remove it, as needed.
            this.sectorsTableAdapter.Fill(this.jailDataSet.Sectors);

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
            else if (nameLabel.Visible == true)
            {
                seacrhMoreParams();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.sectorsBindingSource.CancelEdit();
            changeButtonsVisible();
            makeOneSearchInvisible();
            makeMoreSearchInvisible();
            makeSearchToReloadAllInformation();
        }

        private void sectorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == sectorsDataGridView.Columns["Delete"].Index)
            {
                const string message = "Are you sure you want to delete the item?";
                const string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    this.sectorsTableAdapter.DeleteQuery(Convert.ToInt32(sectorsDataGridView.Rows[e.RowIndex].Cells[0].Value));
                    this.sectorsTableAdapter.Fill(this.jailDataSet.Sectors);
                }
            }
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

            worksheet.Name = "Sectors";

            for (int i = 1; i < sectorsDataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = sectorsDataGridView.Columns[i -
               1].HeaderText;
            }

            for (int i = 0; i < sectorsDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < sectorsDataGridView.Columns.Count - 1; j++)
                {
                    worksheet.Cells[i + 2, j + 1] =
                   sectorsDataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs($"{ExportConstant.path}sectorReports.xls");
            app.Quit();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sectorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);
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
            oneValueTextBox.Visible = true;
        }

        private void makeOneSearchInvisible()
        {
            oneParamLabel.Visible = false;
            oneValueTextBox.Visible = false;
        }

        private void makeMoreSearchVisible()
        {
            nameLabel.Visible = true;
            nameTextBox.Visible = true;
            descriptionLabel.Visible = true;
            descriptionTextBox.Visible = true;
        }
        private void makeMoreSearchInvisible()
        {
            nameLabel.Visible = false;
            nameTextBox.Visible = false;
            descriptionLabel.Visible = false;
            descriptionTextBox.Visible = false;
        }

        private void searchOneParam()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name like '%{0}%'", oneValueTextBox.Text);
            sb.AppendFormat(" or Description like '%{0}%'", oneValueTextBox.Text);
            this.sectorsBindingSource.Filter = sb.ToString();
            this.sectorsTableAdapter.Fill(this.jailDataSet.Sectors);
        }
        private void seacrhMoreParams()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name like '%{0}%'", nameTextBox.Text);

            if (sb.Length > 0)
            {
                sb.Append(" AND ");
            }
            sb.AppendFormat("Description like '%{0}%'", descriptionTextBox.Text);

            sectorsBindingSource.Filter = sb.ToString();
            sectorsTableAdapter.Fill(this.jailDataSet.Sectors);
        }

        private void makeSearchToReloadAllInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name like '%{0}%'", "");
            sectorsBindingSource.Filter = sb.ToString();
            sectorsTableAdapter.Fill(this.jailDataSet.Sectors);
        }


    }
}
