using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_12
{
    public partial class Form1 : Form
    {
        Thread t1, t2;

        public Form1()
        {
            InitializeComponent();
        }

        static void work()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name+" is executing");
                Thread.Sleep(100);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new Thread(work);
            t1.Name = "Thread 1";

            t2 = new Thread(work);
            t2.Name = "Thread 2";

            t1.Start();
            t2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Highest: 4
            // Lowest: 0
            t1 = new Thread(work);
            t1.Priority = ThreadPriority.Highest;
            t1.Name = "Thread 1";

            t2 = new Thread(work);
            t2.Priority = ThreadPriority.Lowest;
            t2.Name = "Thread 2";

            t1.Start();
            t2.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
        }
    }
}
