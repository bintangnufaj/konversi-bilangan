using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace konversi_bilangan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1 = cbofrom.SelectedItem.ToString();
            string value2 = cboto.SelectedItem.ToString();

            int hasil = 0;

            if (value1 == "Decimal") // base 10
            {
                if (value2 == "Biner")
                {
                    int angka = int.Parse(txt_enter.Text);
                    hasil = int.Parse(Convert.ToString(angka, 2));
                    txt_result.Text = hasil.ToString();
                }
                else if (value2 == "Octal")
                {
                    int angka = int.Parse(txt_enter.Text);
                    hasil = int.Parse(Convert.ToString(angka, 8));
                    txt_result.Text = hasil.ToString();
                }
                else if (value2 == "Hexadecimal")
                {
                    int angka = int.Parse(txt_enter.Text);
                    string Base = Convert.ToString(angka, 16);
                    txt_result.Text = Base;
                } 
            }
            else if (value1 == "Biner") // base 2
            {
                if (value2 == "Decimal")
                {
                    int angka = int.Parse(txt_enter.Text);
                    txt_result.Text = Convert.ToString(angka, 10); ;
                }
                else if (value2 == "Octal")
                {
                    hasil = Convert.ToInt32(txt_enter.Text, 2);
                    hasil = int.Parse(Convert.ToString(hasil, 8));
                    txt_result.Text = hasil.ToString();
                }
                else if (value2 == "Hexadecimal")
                {
                    string angka = txt_enter.Text;
                    int Base = Convert.ToUInt16(angka, 2);
                    txt_result.Text = Base.ToString();
                }
            }
            else if (value1 == "Octal") // base 8
            {
                if (value2 == "Decimal")
                {
                    hasil = Convert.ToInt32(txt_enter.Text, 8);
                    txt_result.Text = hasil.ToString();
                }
                else if (value2 == "Biner")
                {
                    hasil = Convert.ToInt32(txt_enter.Text, 8);
                    hasil = int.Parse(Convert.ToString(hasil, 2));
                    txt_result.Text = hasil.ToString();
                }
                else if (value2 == "Hexadecimal")
                {
                    int angka = Convert.ToInt32(txt_enter.Text, 8);
                    string Base = Convert.ToString(angka, 16);
                    txt_result.Text = Base;
                }
            }
            else if (value1 == "Hexadecimal") //base 16
            {
                if (value2 == "Decimal")
                {
                    string angka = txt_enter.Text;
                    int Base = Int32.Parse(angka, System.Globalization.NumberStyles.HexNumber);
                    txt_result.Text = Base.ToString();
                }
                else if (value2 == "Octal")
                {
                    string angka = txt_enter.Text;
                    int Base = int.Parse(Convert.ToString(Convert.ToInt64(angka, 16), 8));
                    txt_result.Text = Base.ToString();
                }
                else if (value2 == "Biner")
                {
                    string angka = txt_enter.Text;
                    int Base = int.Parse(Convert.ToString(Convert.ToInt64(angka, 16), 2));
                    txt_result.Text = Base.ToString();
                }
            }
        }

        private void cbofrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbofrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
            txt_enter.Text = "";
        }
    }
}
