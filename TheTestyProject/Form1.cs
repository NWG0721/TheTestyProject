using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTestyProject
{
    public partial class frmMain : Form
    {
        private int id;

        public void SElECT()
        {
            this.users_tblTableAdapter.SELECT(this.dB.users_tbl);
        }
        public void INSERT()
        {
            this.users_tblTableAdapter.INSERT(txtFName.Text, txtLName.Text, Convert.ToInt32(txtAge.Text));
        }
        public void UPDATE()
        {
            id = (int)dgPeople.CurrentRow.Cells[0].Value;
            users_tblTableAdapter.UPDATE(txtFName.Text, txtLName.Text, Convert.ToInt32(txtAge.Text), id);
        }
        public void DELETE()
        {
            id = (int)dgPeople.CurrentRow.Cells[0].Value;
            this.users_tblTableAdapter.DeleteQuery(id);
        }
        private void Selector()
        {
            if (btnAdd.Text == "Add Person")
            {
                if (txtFName.Text != "" && txtLName.Text != "")
                {
                    INSERT();
                    SElECT();
                }
                else
                {
                    MessageBox.Show("Enter all values");
                }

            }
            else
            {

                if (txtFName.Text != "" && txtLName.Text != "")
                {
                    UPDATE();
                    SElECT();
                }
                else
                {
                    MessageBox.Show("Enter all values");
                }
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.users_tbl' table. You can move, or remove it, as needed.
            SElECT();
        }

        private void tlsAddPerson_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "Add Person";
            panel2.Visible = true;
        }

        private void selectQueryToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void tlsRefresh_Click(object sender, EventArgs e)
        {
            SElECT();
        }

        private void tlsDeletePerson_Click(object sender, EventArgs e)
        {
            DELETE();
            SElECT();
        }

        private void tlsEditPerson_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "Edit Person";
            panel2.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Selector();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
