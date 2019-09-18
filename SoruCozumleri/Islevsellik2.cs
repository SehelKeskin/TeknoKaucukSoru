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
    public partial class Islevsellik2 : Form
    {
        public Islevsellik2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 1; i <= 200; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    label1.Text += "\t zigzag \n ";
                }

                else if (i % 3 == 0)
                {
                    label1.Text += "\t zig \t";
                }
                else if (i % 5 == 0)
                {
                    label1.Text += "\t zag \t";
                }

                else
                {
                    label1.Text += i.ToString() + "\t ";
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
        int i = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Islevsellik1 frm = new Islevsellik1();
            frm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Islevsellik3 frm = new Islevsellik3();
            frm.Show();
        }
    }
}
