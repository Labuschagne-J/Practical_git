using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_prac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJean_Click(object sender, EventArgs e)
        {
            Jean_MeanCalc frmJM = new Jean_MeanCalc();
            frmJM.Show();
        }

        private void btnCharlMax_Click(object sender, EventArgs e)
        {
            Charl_MaxCal frmCM = new Charl_MaxCal();
            frmCM.Show();

        }
    }
}
