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
    public partial class Islevsellik3 : Form
    {
        public Islevsellik3()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            try
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                if (sayi < 0 || sayi > 15)
                {
                    MessageBox.Show("Girdiğiniz sayı 0 ile 15 arasında olmalıdır.");
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    for (int k = 0; k < 5; k++)
                    {
                       
                        label1.Text += string.Format("{0,-10}", k);
                    }

                    label1.Text += "\n";
                    for (int i = 1; i <= sayi; i++)
                    {
                       

                        for (int j = 1; j < 5; j++)
                        {
                            if (j==1)
                            {
                                
                              label1.Text+=  string.Format("{0,-10}",(i * j).ToString() );
                     
                            }

                            if ((i * j) > 9)
                            {
                                label1.Text += string.Format("{0,-9}", (i * j).ToString());
                            }
                            else
                            {
                               
                                label1.Text += string.Format("{0,-10}", (i * j).ToString());
                            }
                            if (j==4)
                            {
                                label1.Text += "\n";
                            }

                          
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen sayısal bir değer giriniz.");
                textBox1.Clear();
                textBox1.Focus();
            }


          
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Islevsellik2 frm = new Islevsellik2();
            frm.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Islevsellik4 frm = new Islevsellik4();
            frm.Show();
        }
    }
}
