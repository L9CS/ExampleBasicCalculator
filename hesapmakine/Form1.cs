using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int sayi = 0;
        int sonuc = 0;
        int onceki = 0;
        string op = "";



        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "2";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            sayi = Convert.ToInt32(textBox1.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "+";
            op = "+";
            onceki = sayi;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-";
            op = "-";
            onceki = sayi;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "/";
            op = "/";
            onceki = sayi;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "*";
            op = "*";
            onceki = sayi;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (op == "+") //toplama
            {
                sonuc = onceki + sayi;
                textBox1.Text = sonuc.ToString();
            }


            if (op == "-") //cıkarma
            {
                sonuc = onceki - sayi;
                textBox1.Text = sonuc.ToString();
            }



            if (op == "/") //bolme
            {
                sonuc = onceki / sayi;
                textBox1.Text = sonuc.ToString();
            }



            if (op == "*") //carpma
            {
                sonuc = onceki * sayi;
                textBox1.Text = sonuc.ToString();
            }



            if (op == "kare_al") // kare alma
            {
                sonuc = sayi * sayi;
                textBox1.Text = sonuc.ToString();
            }



            if (op == "kok_al")    //kok alma         
            {
                double a;
                a = Math.Sqrt(sayi);
                textBox1.Text = a.ToString();

            }


            if (op == "faktoriyel")  // faktoriyel alma
            {
                int fakto = 1;
                for (int i = 1; i <= sayi; i++)
                {
                    fakto *= i;
                }
                textBox1.Text = fakto.ToString();
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            op = "";
            sayi = 0;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "kare al";  // kare alma                                           
            op = "kare_al";
            onceki = sayi;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "kök al";
            op = "kok_al";
            onceki = sayi;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "faktoriyel işlemi";
            op = "faktoriyel";
            onceki = sayi;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.BackColor = Color.Black;
                radioButton1.ForeColor = Color.White;
                radioButton2.ForeColor = Color.White;
            }
            if (!radioButton1.Checked == true)
            {
                this.BackColor = Color.White;
                radioButton1.ForeColor = Color.Black;
                radioButton2.ForeColor = Color.Black;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
