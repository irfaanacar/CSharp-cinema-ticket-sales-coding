using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemabiletsatisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplamkisi = 0;
        int toplamucret = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            toplamkisi++;
            textBox1.Text = toplamkisi.ToString();
            toplamucret = toplamucret + 10;
            textBox2.Text = toplamucret.ToString();
            if (toplamkisi >= 10)
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            toplamkisi--;
            textBox1.Text = toplamkisi.ToString();
            toplamucret = toplamucret - 10;
            textBox2.Text = toplamucret.ToString();
            if (toplamkisi == 0)
            {
                button2.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            toplamkisi++;
            textBox4.Text = toplamkisi.ToString();
            toplamucret = toplamucret + 10;
            textBox3.Text = toplamucret.ToString();
            if (toplamkisi >= 10)
            {
                button4.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            toplamkisi--;
            textBox4.Text = toplamkisi.ToString();
            toplamucret = toplamucret - 10;
            textBox3.Text = toplamucret.ToString();
            if (toplamkisi == 0)
            {
                button3.Enabled = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button14.Enabled = true;
            toplamkisi++;
            textBox8.Text = toplamkisi.ToString();
            toplamucret = toplamucret + 10;
            textBox7.Text = toplamucret.ToString();
            if (toplamkisi >= 10)
            {
                button15.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button15.Enabled = true;
            toplamkisi--;
            textBox8.Text = toplamkisi.ToString();
            toplamucret = toplamucret - 10;
            textBox7.Text = toplamucret.ToString();
            if (toplamkisi == 0)
            {
                button14.Enabled = false;
            }
        }


        private void button12_Click(object sender, EventArgs e)
        {
            int toplamizleyici;
            toplamizleyici = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox8.Text);
            label16.Text = toplamizleyici.ToString();
            int sinematutari;
            sinematutari= Convert.ToInt32(textBox2.Text)+ Convert.ToInt32(textBox3.Text)+ Convert.ToInt32(textBox7.Text);
            label17.Text= sinematutari.ToString();
        }
        int misir = 0, kola = 0, su = 0;

        private void button8_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            kola++;
            label11.Text = kola.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kola--;
            label11.Text = kola.ToString();
            if (kola <= 0)
            {
                button7.Enabled= false;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button9.Enabled = true;
            su++;
            label10.Text = su.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            su--;
            label10.Text = su.ToString();
            if (su <= 0)
            {
                button9.Enabled= false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int toplamurun, urunfiyat;
            toplamurun = Convert.ToInt32(label12.Text) + Convert.ToInt32(label11.Text) + Convert.ToInt32(label10.Text);
            label22.Text= toplamurun.ToString();
            toplamurun= Convert.ToInt32(label12.Text)*10 + Convert.ToInt32(label11.Text)*7 + Convert.ToInt32(label10.Text)*3;
            label23.Text=toplamurun.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            misir--;
            label12.Text= misir.ToString();
            if (misir <= 0)
            {
                button6.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Enabled= true;
            misir++;
            label12.Text = misir.ToString();
            
        }
    }
}
