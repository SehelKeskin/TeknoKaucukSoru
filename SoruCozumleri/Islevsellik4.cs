using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruCozumleri
{
    public partial class Islevsellik4 : Form
    {
       
        public Islevsellik4()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string[] wSpace = new string[4] { " ", "\n", "\t" ,"\r"};
                        fileContent = reader.ReadToEnd();
                        var sonuc = fileContent.Split(wSpace, StringSplitOptions.RemoveEmptyEntries);
                       double[] myInts = Array.ConvertAll(sonuc, s => double.Parse(s));
                        Array.Sort(myInts);
                        Array.Reverse(myInts);

                        foreach (double item in myInts)
                        {
                           
                           
                            listBox1.Items.Add(item);

                        }
                  
                        reader.Close();
                    }
                }
            }

     
        }

        private void Islevsellik4_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Islevsellik5 frm = new Islevsellik5();
            frm.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Islevsellik3 frm = new Islevsellik3();
            frm.Show();
        }
    }
}
