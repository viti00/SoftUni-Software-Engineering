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
    public partial class frmPrisoners : Form
    {
        public frmPrisoners()
        {
            InitializeComponent();
        }

        private void prisonersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prisonersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jailDataSet);

        }

        private void frmPrisoners_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Cells' table. You can move, or remove it, as needed.
            this.cellsTableAdapter.Fill(this.jailDataSet.Cells);
            // TODO: This line of code loads data into the 'jailDataSet.Prisoners' table. You can move, or remove it, as needed.
            this.prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);

        }

        private void addPrisoner_Click(object sender, EventArgs e)
        {
            try
            {
                cellIdTextBox.Text = cellIdComboBox.SelectedValue.ToString();
                this.Validate();
                this.prisonersBindingSource.EndEdit();
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

        private void create_Click(object sender, EventArgs e)
        {
            this.prisonersBindingSource.AddNew();
            changeEnabled();
            changeButtonsVisible();
        }

        private void CancelCreate_Click(object sender, EventArgs e)
        {
            this.prisonersBindingSource.CancelEdit();
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
            if(fullNameTextBox.Enabled == false)
            {
                fullNameTextBox.Enabled = true;
                prisonerNumberTextBox.Enabled = true;
                ageTextBox.Enabled = true;
                releaseDateDateTimePicker.Enabled = true;
                cellIdTextBox.Enabled = true;
                cellIdComboBox.Enabled = true;
            }
            else
            {
                fullNameTextBox.Enabled = false;
                prisonerNumberTextBox.Enabled = false;
                ageTextBox.Enabled = false;
                releaseDateDateTimePicker.Enabled = false;
                cellIdTextBox.Enabled = false;
                cellIdComboBox.Enabled = false;
            }
        }

        private void changeButtonsVisible()
        {
            if(create.Visible == true)
            {
                create.Visible = false;
                addPrisoner.Visible = true;
                CancelCreate.Visible = true;
                Edit.Visible = false;
            }
            else
            {
                create.Visible = true;
                addPrisoner.Visible = false;
                CancelCreate.Visible = false;
                Edit.Visible = true;
            }
        }
    }
}
