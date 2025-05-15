using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRADINGSYSTEM
{
    public partial class STUDENTGRADES: UserControl
    {
        string remarks = "";
        public STUDENTGRADES()
        {
            InitializeComponent();
        }

        private void lblMidterm_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtLastname.Text == "" || txtFirstname.Text == "" || txtMiddlename.Text == "" || txtProgram.Text == "" ||
                txtPrelim.Text == "" || txtMidterm.Text == "" || txtFinal.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                var average = (Convert.ToSingle(txtPrelim.Text) + Convert.ToSingle(txtMidterm.Text)
                    + Convert.ToSingle(txtFinal.Text)) / 3;
                if (average <= 1)
                {
                    remarks = "Outsanding";
                }
                else if (average <= 2)
                {
                    remarks = "Highly Average";
                }
                else if (average <= 3)
                {
                    remarks = "Average";
                }
                else if (average <= 4)
                {
                    remarks = "Needs Improvement";
                }
                else if (average >= 4.1)
                {
                    remarks = "Failed";
                }



                ListViewItem newitem = new ListViewItem(txtFirstname.Text);
                var averageString = Convert.ToString(average);
                newitem.SubItems.Add(txtLastname.Text);
                newitem.SubItems.Add(txtMiddlename.Text);
                newitem.SubItems.Add(txtProgram.Text);
                newitem.SubItems.Add(cmbSubjects.SelectedItem.ToString());
                newitem.SubItems.Add(txtPrelim.Text);
                newitem.SubItems.Add(txtMidterm.Text);
                newitem.SubItems.Add(txtFinal.Text);
                newitem.SubItems.Add(averageString);
                newitem.SubItems.Add(remarks);
                lvwInfo.Items.Add(newitem);

            }
        }

        private void STUDENTGRADES_Load(object sender, EventArgs e)
        {
            lvwInfo.View = View.Details;

            lvwInfo.Columns.Add("FirstName", 90);
            lvwInfo.Columns.Add("LastName", 90);
            lvwInfo.Columns.Add("MiddleName", 90);
            lvwInfo.Columns.Add("Program", 70);
            lvwInfo.Columns.Add("Subject", 120);
            lvwInfo.Columns.Add("Prelim", 55);
            lvwInfo.Columns.Add("Midterm", 55);
            lvwInfo.Columns.Add("Final", 55);
            lvwInfo.Columns.Add("Average", 55);
            lvwInfo.Columns.Add("Remarks", 70);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtMiddlename.Text = "";
            txtProgram.Text = "";
            cmbSubjects.Text = "";
            txtPrelim.Text = "";
            txtMidterm.Text = "";
            txtFinal.Text = "";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lvwInfo.Items.Clear();
        }
    }
}
