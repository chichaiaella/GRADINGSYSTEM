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
    public partial class ABOUT: UserControl
    {
        public ABOUT()
        {
            InitializeComponent();
        }

        private void ABOUT_Load(object sender, EventArgs e)
        {
            lblDP.Text = "RIEL ALMONICAR \nGELRIC DEL CORRO";
        }
    }
}
