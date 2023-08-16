using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uçuş_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nereden = comboBox1.Text;
            string Nereye = comboBox2.Text;
            string Tarih = dateTimePicker1.Text;
            string Saat = maskedTextBox1.Text;
            string adSoyad = textBox1.Text;
            string TC = maskedTextBox2.Text;
            string Telefon = maskedTextBox3.Text;

            listBox1.Items.Add(Nereden + Nereye + Tarih + Saat + adSoyad + TC + Telefon);
        }

        public void swapString(string a,string b)
        {
            string tmp = a; // giresun = a istanbul = b tmp = giresun a = istanbul b = giresun
            a = b;
            b = tmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
