using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            Form1.diagRes.ready = false;
        }

        private void F_Menu_Load(object sender, EventArgs e)
        {

        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            Form1.diagRes.width = Convert.ToInt32(num_width.Value);
            Form1.diagRes.heidth = Convert.ToInt32(num_heigth.Value);
            Form1.diagRes.ready = true;
            this.Close();
        }
    }
}
