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
using static PersonalFinances.Common.SecurePasswordHasher;
using static PersonalFinances.Common.GlobalVariables;
using PersonalFinances.Data;

namespace PersonalFinances.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            SeedAdministrator();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var employee = GetEmployee();
            if (employee != null)
            {
                if (employee.EMP_IS_ADMINISTRATOR == "T")
                {
                    isAdministrator = true;
                }
                else
                {
                    isAdministrator = false;
                }

                if (GetForm("Container") == null)
                {
                    Container frm = new Container();

                    frm.Closed += (s, args) => this.Close();

                    this.Hide();
                    frm.Show();
                }
                else
                {
                    GetForm("Container").Show();
                    this.Hide();
                }
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";

                errorLabel.Visible = false;
            }
            else
            {
                errorLabel.Visible = true;
            }

        }

        private void SeedAdministrator()
        {
            if (!employeeTableAdapter.GetData().Any(x => x.EMP_IS_ADMINISTRATOR == "T" && x.EMP_USERNAME == "admin"))
            {
                employeeTableAdapter
                    .Insert("admin admin admin", "admin", Hash("123admin123"), "T");
            }
        }

        private PersonalFinancesDataSet1.EMPLOYEERow GetEmployee()
        {
            var employee = employeeTableAdapter
                .GetData()
                .FirstOrDefault(x => x.EMP_USERNAME == usernameTextBox.Text && Verify(passwordTextBox.Text, x.EMP_PASSWORD));

            return employee;
        }
    }
}
