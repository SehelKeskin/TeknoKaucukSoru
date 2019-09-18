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
    public partial class Islevsellik1 : Form
    {
        public Islevsellik1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int toplamSonuc = sayi1 + sayi2;
            int carpimSonuc = sayi1 * sayi2;
            txtToplam.Text = toplamSonuc.ToString();
            txtCarpim.Text = carpimSonuc.ToString();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtSayi1.Clear();
            txtSayi2.Clear();
            txtToplam.Clear();
            txtCarpim.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Islevsellik2 iki = new Islevsellik2();
            iki.Show();
        }
    }
}
