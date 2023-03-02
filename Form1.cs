using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("form1");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("label1");
        }

        private void trans_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text;
            double i = 0;
            try
            {
                i = Convert.ToDouble(s);
            }catch (Exception ex)
            {
                ex.Source = "Error";
            }
            textBox2.Text = (32 + 9 / 5 * i).ToString();
        }
    }
}
