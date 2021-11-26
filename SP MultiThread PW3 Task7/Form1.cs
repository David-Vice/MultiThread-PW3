using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_MultiThread_PW3_Task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writetext = new StreamWriter("resultWinForm.txt");
            writetext.Close();
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(100));
            }

            AddList(list);

            Thread.Sleep(100);
            Thread thread3 = new Thread(() => Min(list));
            thread3.Start();

            Thread.Sleep(100);
            Thread thread4 = new Thread(() => Median(list));
            thread4.Start();

            Thread.Sleep(100);
            Thread thread5 = new Thread(() => Max(list));
            thread5.Start();
        }
        private async void AddList(List<int> list)
        {
            using (StreamWriter writetext = new StreamWriter("resultWinForm.txt", append: true))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Thread.Sleep(10);
                    char[] num = Convert.ToString(list[i]).ToCharArray();
                    await writetext.WriteLineAsync(num);
                    TB1.Text = TB1.Text + Convert.ToString(list[i]);
                    TB1.AppendText(Environment.NewLine);
                }
            }
        }
        private void Min(List<int> list)
        {
            
            double min = list.Min();
            ThreadHelperClass.SetText(this, valueMin, Convert.ToString(min));
        }
        private void Median(List<int> list)
        {
            double avg = list.Average();
            ThreadHelperClass.SetText(this, valueMedian, Convert.ToString(avg));
        }
        private void Max(List<int> list)
        {
            double max = list.Max();
            ThreadHelperClass.SetText(this, valueMax, Convert.ToString(max));
        }
        public static class ThreadHelperClass
        {
            delegate void SetTextCallback(Form f, Control ctrl, string text);
            /// <summary>
            /// Set text property of various controls
            /// </summary>
            /// <param name="form">The calling form</param>
            /// <param name="ctrl"></param>
            /// <param name="text"></param>
            public static void SetText(Form form, Control ctrl, string text)
            {
                // InvokeRequired required compares the thread ID of the 
                // calling thread to the thread ID of the creating thread. 
                // If these threads are different, it returns true. 
                if (ctrl.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    form.Invoke(d, new object[] { form, ctrl, text });
                }
                else
                {
                    ctrl.Text = text;
                }
            }
        }
    }
}
