using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonalFinances.GlobalMethods;

namespace PersonalFinances
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            SetFormLocation(this);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.eMPLOYEETableAdapter.Fill(this.personalFinancesDataSet1.EMPLOYEE);
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployee frm = new AddEmployee();
            frm.MdiParent = this.MdiParent;
            this.Close();
            frm.Show();
        }
    }
}
