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
using static PersonalFinances.GlobalVariables;

namespace PersonalFinances
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
            ShowCorrectMenu();
        }

        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
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
            }
            else
            {
                clientsPictureBox.Visible = true;
                addClientPictureBox.Visible = true;
            }
        }

        private void dossierPictureBox_Click(object sender, EventArgs e)
        {
            Dossiers frm = new Dossiers();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
