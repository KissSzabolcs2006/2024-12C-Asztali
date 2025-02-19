using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            int n= (int)e.X;
            int m= (int)e.Y;

            label2.Text = ($"x:{n}, y:{m}");
            label2.Top = m;
            label2.Left = n;
        }
    }
}
