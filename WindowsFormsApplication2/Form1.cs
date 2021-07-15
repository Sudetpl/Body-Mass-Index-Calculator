using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad,soyad,cinsiyet;
            int yaş,boy;
            double kilo,idealkilo=0,K=0;

            ad = Convert.ToString(textBox1.Text);
            soyad = Convert.ToString(textBox2.Text);
            yaş = Convert.ToInt32(textBox3.Text);
            boy = Convert.ToInt32(textBox4.Text);
            kilo = Convert.ToDouble(textBox5.Text);
            cinsiyet = Convert.ToString(comboBox1.Text);
            if( comboBox1.SelectedIndex==0)
            K = 0.8;
            else if (comboBox1.SelectedIndex==1)
            K = 0.9;
            


            idealkilo = (boy - 100 + yaş / 10) * K;
            textBox6.Text = idealkilo.ToString();
         
            
            if (idealkilo == kilo)
                label9.Text = ("Bravo ideal kilodasınız");
            else if (idealkilo > kilo)
                label9.Text =  "Zayıfsın" +(idealkilo - kilo).ToString() + "kilo almalısın!";
            else if (idealkilo < kilo)
                label9.Text = "Şişmansın" + (kilo - idealkilo).ToString() + "kilo zayıflamalısın";





           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
