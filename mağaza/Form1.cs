using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mağaza
{
    public partial class Form1 : Form
    {
        public int fiyat,adet;
        public double indirim,satis,toplam=0;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string metin,indirimadı;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0: fiyat = 150; break;
                case 1: fiyat = 80; break;
                case 2: fiyat = 120; break;
                case 3: fiyat = 300; break;
                default: MessageBox.Show("lütfen eçim yapınız");
                    break;
            }


            if(radioButton1.Checked)
            {
                indirim = 1;
                indirimadı = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                indirim = 0.95;
                indirimadı = radioButton2.Text;
            }
            else if(radioButton3.Checked)
            {
                indirim = 0.9;
                indirimadı = radioButton3.Text;
            }
            else if(radioButton4.Checked)
            {
                indirim = 0.8;
                indirimadı = radioButton4.Text;
            }

            adet = Convert.ToInt32(textBox1.Text);
            satis = fiyat * indirim*adet;
            toplam = toplam + satis;
            label5.Text = Convert.ToString(toplam);

            metin = "Ürün=" + comboBox1.SelectedItem + "  İndirim:" + indirimadı + "  Tutar:" + Convert.ToString(satis);
            richTextBox1.AppendText(metin );
            

            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            comboBox1.Text = "";
        }
    }
}
