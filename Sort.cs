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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private const int LENGTH = 5;
        //用户输入的数字序列
        private double[] arr = new double[LENGTH];
        //当前添加的数字的下标
        private int index = 0;

        /// <summary>
        /// 添加一个元素到数组序列中去
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click(object sender, EventArgs e)
        {
            double element = 0;
            try
            {
                element = Convert.ToDouble(input.Text);
            } catch (Exception ex)
            {

            }
            arr[index] = element;
            index = (index+1)%LENGTH;
            preSort.Text += element.ToString() + " ";
            no.Text = "请输入第" + (index+1).ToString() + "元素";
        }

        private void sort_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            for(int i  = 0; i < LENGTH; i++)
            {
                thenSort.Text += arr[i].ToString()+" ";
            }
        }

    }
}
