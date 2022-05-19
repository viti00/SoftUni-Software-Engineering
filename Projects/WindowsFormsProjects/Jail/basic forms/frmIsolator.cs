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
    public partial class frmIsolator : Form
    {
        public frmIsolator()
        {
            InitializeComponent();
        }

        private void isolatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.isolatorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmIsolator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Prisoners' table. You can move, or remove it, as needed.
            this.prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);
            // TODO: This line of code loads data into the 'jailDataSet.Isolator' table. You can move, or remove it, as needed.
            this.isolatorTableAdapter.Fill(this.jailDataSet.Isolator);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                prisonerIdTextBox.Text = prisonerIdComboBox.SelectedValue.ToString();
                this.Validate();
                this.isolatorBindingSource.EndEdit();
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
            this.isolatorBindingSource.CancelEdit();
            changeEnabled();
            changeButtonsVisible();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            this.isolatorBindingSource.AddNew();
            changeEnabled();
            changeButtonsVisible();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.bindingNavigatorPositionItem.Text) == 0)
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
            if (prisonerIdTextBox.Enabled == false)
            {
                prisonerIdTextBox.Enabled = true;
                reasonTextBox.Enabled = true;
                releaseDateDateTimePicker.Enabled = true;
                prisonerIdComboBox.Enabled = true;
            }
            else
            {
                prisonerIdTextBox.Enabled = false;
                reasonTextBox.Enabled = false;
                releaseDateDateTimePicker.Enabled = false;
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
