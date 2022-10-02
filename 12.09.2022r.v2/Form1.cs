using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._09._2022r.v2
{
    public partial class Form1 : Form
    {

        private int licznik = 0;
        private int ticks;
        int seconds;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            licznik++;
            label1.Text = licznik.ToString();

          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                


            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label1.Text = "Wynik po kliknięciach";
            timer1.Start();
            button1.Enabled = true;
            licznik = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
               
        }
    }
}
