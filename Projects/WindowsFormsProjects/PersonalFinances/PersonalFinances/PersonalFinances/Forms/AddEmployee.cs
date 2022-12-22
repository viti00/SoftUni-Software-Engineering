using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PersonalFinances.Common.SecurePasswordHasher;
using static PersonalFinances.Common.GlobalMethods;
using PersonalFinances.Common;

namespace PersonalFinances.Forms
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

                AutoClosingMessageBox.Show("Служителят е добавен успешно", "Добавяне на служител", 1000);

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
            Employees frm = new Employees();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void addBtn_MouseHover(object sender, EventArgs e)
        {
            addBtn.BackColor = Color.LimeGreen;
        }

        private void addBtn_MouseLeave(object sender, EventArgs e)
        {
            DefaultBackColor(addBtn);
        }
    }
}
