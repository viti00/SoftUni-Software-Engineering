using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonalFinances.Common.GlobalMethods;

namespace PersonalFinances.Forms
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            SetFormLocation(this);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.eMPLOYEETableAdapter.FillBy(this.personalFinancesDataSet1.EMPLOYEE);
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployee frm = new AddEmployee();
            frm.MdiParent = this.MdiParent;
            this.Close();
            frm.Show();
        }

        private void eMPLOYEEDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == employeeDataGridView.Columns["Fired"].Index && e.RowIndex >= 0)
            {
                var employeeId = eMPLOYEETableAdapter
                    .GetData()
                    .FirstOrDefault(x => x.EMP_USERNAME == employeeDataGridView.CurrentRow.Cells["Username"].Value.ToString()).EMP_ID;

                eMPLOYEETableAdapter.Fired(employeeId);

                RefreshGridView();
            }
        }

        private void RefreshGridView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("[EMP_USERNAME] like '%{0}%'", "");

            eMPLOYEEBindingSource.Filter = sb.ToString();
            eMPLOYEETableAdapter.FillBy(personalFinancesDataSet1.EMPLOYEE);
        }

        private void addEmployeeBtn_MouseHover(object sender, EventArgs e)
        {
            addEmployeeBtn.BackColor = Color.RoyalBlue;
        }

        private void addEmployeeBtn_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(addEmployeeBtn);
        }
    }
}
