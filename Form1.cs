using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5._1

{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String x = textBox1.Text;
            string resultado = "";
            char[] numbers = new char[10] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] letters = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < x.Length; i++)
            {
                for (int j=0; j<10;j++)
                {
                    if (numbers[j] == x[i])
                    {
                        resultado += x[i];
                    }
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (letters[j] == x[i])
                    {
                        resultado += x[i];
                    }
                }
            }

            MessageBox.Show("A caralha da resposta e: "+resultado);
            

        }

    }
}
