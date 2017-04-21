using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            DateTime curTime = DateTime.Now;
            lblDateTime.Text =
                    String.Format("現在時刻は{0}{1}　です",
                        curTime.ToShortDateString(),curTime.ToShortTimeString());
        }　
    }
}
