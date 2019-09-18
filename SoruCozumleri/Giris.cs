using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruCozumleri
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            timer1.Interval = 3950;
            timer1.Start();
        }
        public int i = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                timer1.Stop();
                this.Hide();
                Islevsellik1 frm = new Islevsellik1();
                frm.Show();
            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
