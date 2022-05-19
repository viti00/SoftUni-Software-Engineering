using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jail
{
    public partial class frmSectors : Form
    {
        public frmSectors()
        {
            InitializeComponent();
        }

        private void sectorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sectorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmSectors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Sectors' table. You can move, or remove it, as needed.
            this.sectorsTableAdapter.Fill(this.jailDataSet.Sectors);

        }

        private void addSector_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sectorsBindingSource.EndEdit();
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
            this.sectorsBindingSource.CancelEdit();
            changeEnabled();
            changeButtonsVisible();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            this.sectorsBindingSource.AddNew();
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
            if (nameTextBox.Enabled == false)
            {
                nameTextBox.Enabled = true;
                descriptionTextBox.Enabled = true;
            }
            else
            {
                nameTextBox.Enabled = false;
                descriptionTextBox.Enabled = false;
            }
        }

        private void changeButtonsVisible()
        {
            if (Create.Visible == true)
            {
                Create.Visible = false;
                addSector.Visible = true;
                Cancel.Visible = true;
                Edit.Visible = false;
            }
            else
            {
                Create.Visible = true;
                addSector.Visible = false;
                Cancel.Visible = false;
                Edit.Visible = true;
            }
        }

        
    }
}
