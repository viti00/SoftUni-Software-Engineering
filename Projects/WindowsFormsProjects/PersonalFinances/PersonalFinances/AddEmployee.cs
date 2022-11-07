using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonalFinances.SecurePasswordHasher;
using static PersonalFinances.GlobalMethods;

namespace PersonalFinances
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            SetFormLocation(this);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (IsValid())
            {
                var password = Hash(passwordTextBox.Text);

                eMPLOYEETableAdapter
                    .Insert(fullNameTextBox.Text, usernameTextBox.Text, password, "F");

                this.Close();
            }
        }

        private bool IsValid()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
            {
                errorProvider.SetError(fullNameTextBox, "Полето е задължително");
                isValid = false;
            }
            if(string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                errorProvider.SetError(usernameTextBox, "Полето е задължително");
                isValid = false;
            }
            if(eMPLOYEETableAdapter.GetData().Any(x=> x.EMP_USERNAME == usernameTextBox.Text))
            {
                errorProvider.SetError(usernameTextBox, "Вече има служител с такова потребителско име");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                errorProvider.SetError(passwordTextBox, "Полето е задължително");
                isValid = false;
            }
            if(passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                errorProvider.SetError(confirmPasswordTextBox, "Паролите не съвпадат");
                isValid = false;
            }

            return isValid;
        }

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminForm frm = new AdminForm();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
