using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Profit : Form
    {
        public Profit()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 监听计算按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cal_Click(object sender, EventArgs e)
        {
            double money = 0;
            double year = 0;
            double rate = 0;

            double interest = 0;
            double total = 0;
            try
            {
                money = Convert.ToDouble(txtMoney.Text);
                year = Convert.ToDouble(txtYear.Text);
                rate = Convert.ToDouble(txtRate.Text);
            } catch (Exception ex) { 
            
            }
            interest = money * rate * year;
            total = money + interest;

            txtInterest.Text = interest.ToString();
            txtTotal.Text = total.ToString();
        }
    }
}
