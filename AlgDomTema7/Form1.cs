using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgDomTema7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Sk = new int[10];

        int k = 0; // paspaudimų skaičius

        private void button1_Click(object sender, EventArgs e) // 1 Užduotis
        {
            int suma = 0;
            richTextBox1.Clear();
            try
            {
                Sk[k] = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                richTextBox1.Text = "Įvedėte per daug skaičių arba neteisinga skaičiu";
                k--;
            }
            
            textBox1.Clear();
            k++;

            for (int i = 0; i < k; i++)
            {
                richTextBox1.Text += Sk[i].ToString() + "\n";
            }
            if (k == 10)
            {
                for( int i = 0; i < 10; i++)
                {
                    suma += Sk[i]; 
                }
                richTextBox1.Text += "\nSuma: " + suma.ToString() + "\n";
                label1.Text = "Įvedėte visus 10 skaičius";
            }
            else
            {
                label1.Text = "Įveskite " + (10-k) + " skaičius";
            }
            

        }

        private void button2_Click(object sender, EventArgs e) // 2 Užduotis
        {
            int n;
            n = Convert.ToInt32(textBox2.Text);

            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    richTextBox1.Text += " ";
                }
          
                for (int j = 0; j < i + 1; j++)
                {
                    richTextBox1.Text += "* ";
                }
                richTextBox1.Text += "\n";
            }
            


        }
    }
}
