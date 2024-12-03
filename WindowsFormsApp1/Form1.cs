using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Thread myThread1;
        Graphics graphics;
        private ManualResetEvent pauseEvent = new ManualResetEvent(true);
        public Form1()
        {
            InitializeComponent();
            graphics = CreateGraphics();
        }
        private void Clear()
        {
            //Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.Clear(BackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (myThread1 != null)
            {
                Clear();
                myThread1.Abort();
            }
            Figure sq = new Square(90, 120, 60);
            myThread1 = new Thread(() => sq.MoveRight(graphics));
            myThread1.Start();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (myThread1 != null)
            {
                Clear();
                myThread1.Abort();
            }
            Figure circle = new Circle(90, 120, 60);
            myThread1 = new Thread(() => circle.MoveRight(graphics));
            myThread1.Start();


        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (myThread1 != null)
            {
                Clear();
                myThread1.Abort();
            }
            Figure circle = new Romb(90, 120, 160, 80);
            myThread1 = new Thread(() => circle.MoveRight(graphics));
            myThread1.Start();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
