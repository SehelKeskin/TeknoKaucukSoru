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
    public partial class Islevsellik5 : Form
    {
        public Islevsellik5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            int sayi = Convert.ToInt32(txtSayi.Text);

            int a = 0, b = 1, c = 0;

            for (int i = 2; i < sayi; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            sonuc.Text ="Sonuç :"+ c.ToString();
        }

        private void TxtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Islevsellik5_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Islevsellik4 frm = new Islevsellik4();
            frm.Show();
        }
    }
}
