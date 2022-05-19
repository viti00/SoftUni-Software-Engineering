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
    public partial class frmOfficers : Form
    {
        public frmOfficers()
        {
            InitializeComponent();
        }

        private void officersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.officersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmOfficers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Sectors' table. You can move, or remove it, as needed.
            this.sectorsTableAdapter.Fill(this.jailDataSet.Sectors);
            // TODO: This line of code loads data into the 'jailDataSet.Officers' table. You can move, or remove it, as needed.
            this.officersTableAdapter.Fill(this.jailDataSet.Officers);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                sectorIdTextBox.Text = sectorIdComboBox.SelectedValue.ToString();
                this.Validate();
                this.officersBindingSource.EndEdit();
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
            this.officersBindingSource.CancelEdit();
            changeEnabled();
            changeButtonsVisible();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            this.officersBindingSource.AddNew();
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
            if (fullNameTextBox.Enabled == false)
            {
                fullNameTextBox.Enabled = true;
                salaryTextBox.Enabled = true;
                weaponTextBox.Enabled = true;
                sectorIdTextBox.Enabled = true;
                sectorIdComboBox.Enabled = true;
            }
            else
            {
                fullNameTextBox.Enabled = false;
                salaryTextBox.Enabled = false;
                weaponTextBox.Enabled = false;
                sectorIdTextBox.Enabled = false;
                sectorIdComboBox.Enabled = false;
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
