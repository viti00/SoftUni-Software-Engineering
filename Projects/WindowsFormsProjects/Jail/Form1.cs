using Jail.master_details_forms;
using Jail.report_forms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void prisonersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSectors sectors = new frmSectors();
            sectors.MdiParent = this;
            sectors.Show();
        }

        private void cellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCells cells = new frmCells();
            cells.MdiParent = this;
            cells.Show();
        }

        private void prisonersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrisoners prisoners = new frmPrisoners();
            prisoners.MdiParent = this;
            prisoners.Show();
        }

        private void officersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOfficers officers = new frmOfficers();
            officers.MdiParent = this;
            officers.Show();
        }

        private void mailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMails mails = new frmMails();
            mails.MdiParent = this;
            mails.Show();
        }

        private void isolatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsolator isolator = new frmIsolator();
            isolator.MdiParent = this;
            isolator.Show();
        }

        private void sectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSectorsList sectorsList = new frmSectorsList();
            sectorsList.MdiParent = this;
            sectorsList.Show();
        }

        private void cellsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCellsList cellsList = new frmCellsList();
            cellsList.MdiParent = this;
            cellsList.Show();
        }

        private void prisonersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPrisonersList prisonersList = new frmPrisonersList();
            prisonersList.MdiParent = this;
            prisonersList.Show();
        }

        private void officersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOfficersList officersList = new frmOfficersList();
            officersList.MdiParent = this;
            officersList.Show();
        }

        private void mailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMailList mailList = new frmMailList();
            mailList.MdiParent = this;
            mailList.Show();
        }

        private void isolatorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIsolatorList isolatorList = new frmIsolatorList();
            isolatorList.MdiParent = this;
            isolatorList.Show();
        }

        private void sectorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSectorsReport sectorsReport = new frmSectorsReport();
            sectorsReport.MdiParent = this;
            sectorsReport.Show();
        }

        private void cellsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCellsReport cellsReport = new frmCellsReport();
            cellsReport.MdiParent = this;
            cellsReport.Show();
        }

        private void prisonersToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPrisonersReport prisonersReport = new frmPrisonersReport();
            prisonersReport.MdiParent = this;
            prisonersReport.Show();
        }

        private void officersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmOfficersReport officersReport = new frmOfficersReport();
            officersReport.MdiParent = this;
            officersReport.Show();
        }

        private void mailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMailsReport mailsReport = new frmMailsReport();
            mailsReport.MdiParent = this;
            mailsReport.Show();
        }

        private void isolatorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmIsolatorReport isolatorReport = new frmIsolatorReport();
            isolatorReport.MdiParent = this;
            isolatorReport.Show();
        }

        private void officersSectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOfficersSector officersSector = new frmOfficersSector();
            officersSector.MdiParent = this;
            officersSector.Show();
        }

        private void prisonersMailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrisonersMails prisonersMails = new frmPrisonersMails();
            prisonersMails.MdiParent = this;
            prisonersMails.Show();
        }

        private void prisonersIsolatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrisonerIsolator prisonerIsolator = new frmPrisonerIsolator();
            prisonerIsolator.MdiParent = this;
            prisonerIsolator.Show();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jailDataSet.Prisoners' table. You can move, or remove it, as needed.
            this.prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            for (int i = 0; i < prisonersDataGridView.Rows.Count - 1; i++)
            {
                if (Convert.ToDateTime(prisonersDataGridView.Rows[i].Cells[4].Value) <= DateTime.Today)
                {
                    this.prisonersTableAdapter.DeleteQuery(Convert.ToInt32(prisonersDataGridView.Rows[i].Cells[0].Value));
                    this.prisonersTableAdapter.Fill(this.jailDataSet.Prisoners);
                }
            }
        }
    }
}
