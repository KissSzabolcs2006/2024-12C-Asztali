using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMozg
{
    public partial class Form1 : Form
    {
        private int valtmagas = 10,
            valtszeles = 10,
            maxWidth = 0,
            maxHeight = 0,
            minWidth = 0,
            minHeight = 0;

        private void btnFel_Click(object sender, EventArgs e)
        {

        }

        private void btnFelul_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X,0);
        }

        private void BtnCsok_Click(object sender, EventArgs e)
        {
            if (Width >= Width - valtszeles)
            {
                Width -= valtszeles;
            }

            Width -= Width - valtszeles >=minWidth ? valtszeles : 0;
            Height-=Height-valtmagas>=minHeight ? valtmagas : 0;
        }

        public Form1()
        {
            InitializeComponent();
            maxHeight = Screen.GetWorkingArea(this).Height;
            maxWidth= Screen.GetWorkingArea(this).Width;
            minHeight = maxHeight / 2;
            minWidth = maxWidth / 2;
        }

        private void btnMeretNo_Click(object sender, EventArgs e)
        {
            if ((Location.X + Height) <= maxHeight)
            {
                Height += valtmagas;
            }
            if ((Location.X + Width) <= maxWidth)
            {
                Width += valtszeles;
            }
        }
    }
}
