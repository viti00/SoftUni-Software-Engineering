using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jail
{
    public partial class frmMails : Form
    {
        public frmMails()
        {
            InitializeComponent();
        }

        private void mailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmMails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Prisoners' table. You can move, or remove it, as needed.
            this.prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);
            // TODO: This line of code loads data into the 'jailDataSet.Mails' table. You can move, or remove it, as needed.
            this.mailsTableAdapter.Fill(this.jailDataSet.Mails);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                prisonerIdTextBox.Text = prisonerIdComboBox.SelectedValue.ToString();
                this.Validate();
                this.mailsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.jailDataSet);
                MessageBox.Show("Тhe action completed successfully!");
                changeButtonsVisible();
                changeEnabled();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.mailsBindingSource.CancelEdit();
            changeEnabled();
            changeButtonsVisible();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            this.mailsBindingSource.AddNew();
            changeEnabled();
            changeButtonsVisible();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(this.bindingNavigatorPositionItem.Text) == 0)
            {
                MessageBox.Show("Database has no records!");
            }
            else
            {
                changeEnabled();
                changeButtonsVisible();
            }
        }

        private void changeEnabled()
        {
            if (descriptionTextBox.Enabled == false)
            {
                descriptionTextBox.Enabled = true;
                senderTextBox.Enabled = true;
                prisonerIdTextBox.Enabled = true;
                prisonerIdComboBox.Enabled = true;
            }
            else
            {
                descriptionTextBox.Enabled = false;
                senderTextBox.Enabled = false;
                prisonerIdTextBox.Enabled = false;
                prisonerIdComboBox.Enabled = false;
            }
        }

        private void changeButtonsVisible()
        {
            if (Create.Visible == true)
            {
                Create.Visible = false;
                Add.Visible = true;
                Cancel.Visible = true;
                Edit.Visible = false;
            }
            else
            {
                Create.Visible = true;
                Add.Visible = false;
                Cancel.Visible = false;
                Edit.Visible = true;
            }
        }

       
    }
}
