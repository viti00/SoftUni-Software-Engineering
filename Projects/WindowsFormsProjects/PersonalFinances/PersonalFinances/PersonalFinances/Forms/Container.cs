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
using static PersonalFinances.Common.GlobalVariables;

namespace PersonalFinances.Forms
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }

        private void logoutPictureBox_Click(object sender, EventArgs e)
        {

            var forms = Application.OpenForms.Cast<Form>().Where(x=> x.Name != "Container" && x.Name != "Login").ToList();

            forms.ForEach(x => x.Close());

            this.Hide();

            GetForm("Login").Show();
        }

        private void clientsPictureBox_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients();
            clients.MdiParent = this;
            clients.Show();
        }

        private void addClientPictureBox_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.MdiParent = this;
            addClient.Show();
        }

        private void ShowCorrectMenu()
        {
            if (isAdministrator)
            {
                clientsPictureBox.Visible = false;
                addClientPictureBox.Visible = false;
                dossierPictureBox.Visible = false;
                employeesPictureBox.Visible = true;
                infoPictureBox.Visible = false;
            }
            else
            {
                clientsPictureBox.Visible = true;
                addClientPictureBox.Visible = true;
                dossierPictureBox.Visible = true;
                employeesPictureBox.Visible = false;
                infoPictureBox.Visible = true;
            }
        }

        private void dossierPictureBox_Click(object sender, EventArgs e)
        {
            Dossiers frm = new Dossiers();
            frm.MdiParent = this;
            frm.Show();
        }

        private void employeesPictureBox_Click(object sender, EventArgs e)
        {
            Employees frm = new Employees();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Container_VisibleChanged(object sender, EventArgs e)
        {
            ShowCorrectMenu();
        }

        private void infoPictureBox_Click_1(object sender, EventArgs e)
        {
            HelpForm frm = new HelpForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
