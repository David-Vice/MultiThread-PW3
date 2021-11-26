using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_MultiThread_PW3_Task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compButton_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(() => CountRange1(Convert.ToInt32(range1Start.Text), Convert.ToInt32(range1End.Text)));
            thread1.Start();

            Thread thread2 = new Thread(() => CountRange2(Convert.ToInt32(range2Start.Text), Convert.ToInt32(range2End.Text)));
            thread2.Start();

            Thread thread3 = new Thread(() => CountRange3(Convert.ToInt32(range3Start.Text), Convert.ToInt32(range3End.Text)));
            thread3.Start();
        }

        private void CountRange1(int num1, int num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                Thread.Sleep(10);
                TB1.Text = TB1.Text + Convert.ToString(i);
                TB1.AppendText(Environment.NewLine);
            }
        }
        private void CountRange2(int num1, int num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                Thread.Sleep(10);
                TB2.Text = TB2.Text + Convert.ToString(i);
                TB2.AppendText(Environment.NewLine);
            }
        }
        private void CountRange3(int num1, int num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                Thread.Sleep(10);
                TB3.Text = TB3.Text + Convert.ToString(i);
                TB3.AppendText(Environment.NewLine);
            }
        }
    }
}
