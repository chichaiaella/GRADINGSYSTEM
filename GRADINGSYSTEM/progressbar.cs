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
    public partial class progressbar: Form
    {
        public progressbar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if(progressBar1.Value >= 99)
            {
                Menu Menu = new Menu();
                Menu.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }
    }
}
