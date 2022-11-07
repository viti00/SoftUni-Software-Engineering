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
using static PersonalFinances.SecurePasswordHasher;
using static PersonalFinances.GlobalVariables;

namespace PersonalFinances
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
                if (GetForm("Container") == null)
                {
                    Container form1 = new Container();

                    form1.Closed += (s, args) => this.Close();

                    this.Hide();
                    form1.Show();
                }
                else
                {
                    GetForm("Container").Show();
                    this.Hide();
                }

                usernameTextBox.Text = "";
                passwordTextBox.Text = "";

                errorLabel.Visible = false;

                if(employee.EMP_IS_ADMINISTRATOR == "T")
                {
                    isAdministrator = true;
                    AdminForm frm = new AdminForm();
                    frm.MdiParent = GetForm("Container");
                    frm.Show();
                }
                else
                {
                    isAdministrator = false;
                }
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
