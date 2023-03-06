using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_13022100074
{
    public partial class Form1 : Form
    {
        int a1, a2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + "" + button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + "" + button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + "" + button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + "" + button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + "" + button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + "" + button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + "" +button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + "" + button19.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + "" + button20.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if(a1 == 0)
            {
                a1 = int.Parse(label3.Text);
            }
            label3.Text = " ";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (a2 == 0)
            {
                a2 = int.Parse(label3.Text);
            }
            label3.Text = "" + (a1 + a2);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + "" + button23.Text;
        }
    }
}
