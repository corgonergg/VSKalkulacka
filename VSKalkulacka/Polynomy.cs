using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSKalkulacka
{
    public partial class Polynomy : Form
    {
        public Polynomy(Uvod ukazovatko)
        {
            InitializeComponent();
            this.ukazovatko = ukazovatko;
        }
        Uvod ukazovatko;

        private void bt_vypocist_Click(object sender, EventArgs e)
        {

        }

        private void Polynomy_FormClosed(object sender, FormClosedEventArgs e)
        {
            ukazovatko.Show();
        }
    }
}
