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
    public partial class Uvod : Form
    {
        public Uvod()
        {
            InitializeComponent();
        }

        private void bt_polynom_Click(object sender, EventArgs e)
        {
            new Polynomy(this).Show();
            this.Hide();
        }
    }
}
