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

        private double opValtoz = 0.2;

        private void button3_Click(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterParent;
            CenterToScreen();
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X, (Location.Y + Height + valtmagas) >= Screen.GetWorkingArea(this).Height ? Location.Y : Location.Y + valtmagas);
        }

        private void btnAlul_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X, Screen.GetWorkingArea(this).Height-Height);
        }

        private void btnBalszel_Click(object sender, EventArgs e)
        {
            Location = new Point(0, Location.Y);
        }

        private void btnBalra_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X - valtszeles < 0 ? 0 : Location.X - valtszeles, Location.Y);
        }

        private void btnJobb_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X + Width + valtszeles >= Screen.PrimaryScreen.Bounds.Width ? Screen.PrimaryScreen.Bounds.Width - Width : Location.X + valtszeles, Location.Y);
        }

        private void btnJobbszel_Click(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.Bounds.Width -Width, Location.Y);
        }

        private void btnOpNo_Click(object sender, EventArgs e)
        {
            Opacity += opValtoz;
        }

        private void btnOpCsok_Click(object sender, EventArgs e)
        {
            Opacity -= opValtoz;
        }

        private void btnFel_Click(object sender, EventArgs e)
        {
            Location = new Point(Location.X, Location.Y - (Location.Y - valtmagas) <= 0 ? 0 : Location.Y - valtmagas);
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
