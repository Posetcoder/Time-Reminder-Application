using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Time_reminder_application
{
    public partial class WarningOne : Form
    {
        public bool isButtonClicked = false;
        public Stopwatch watch2 = new Stopwatch();

        public WarningOne()
        {
            InitializeComponent();
            TopMost = true;
            TopLevel = true;
            timer2.Enabled = false;
        }

        private void WarningTwo_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isButtonClicked = true;
            this.Hide();
            watch2.Stop();
            long ms = watch2.ElapsedMilliseconds;
            int msint = Convert.ToInt32(ms);
            int final = 120000 - msint;
            wait(final);
            runlastwarning();
        }

        public void runlastwarning()
        {
            this.Hide();
            var NewForm = new LastWarning();
            NewForm.ShowDialog();
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer2.Enabled = false;
            watch2.Stop();
            if (isButtonClicked == false)
            {
                runlastwarning();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
