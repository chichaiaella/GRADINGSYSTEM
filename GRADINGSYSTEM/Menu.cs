using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRADINGSYSTEM
{
    public partial class Menu: Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Clear the Dashboard
            pnlDisplay.Controls.Clear();
            // dock to dashboard ,declaring uc as new usercontrol local variable
            var uc = new STUDENTGRADES() { Dock = DockStyle.Fill };
            pnlDisplay.Controls.Add(uc);
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            //Clear the Dashboard
            pnlDisplay.Controls.Clear();
            // dock to dashboard ,declaring uc as new usercontrol local variable
            var uc = new STUDENTGRADES() { Dock = DockStyle.Fill };
            pnlDisplay.Controls.Add(uc);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //Clear the Dashboard
            pnlDisplay.Controls.Clear();
            // dock to dashboard ,declaring uc as new usercontrol local variable
            var uc = new ABOUT() { Dock = DockStyle.Fill };
            pnlDisplay.Controls.Add(uc);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
