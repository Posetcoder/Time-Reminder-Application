using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Time_reminder_application
{
    public partial class TimesUpForm : Form
    {

        public bool isButtonClicked = false;
        public Stopwatch watch = new Stopwatch();

        public TimesUpForm()
        {
            InitializeComponent();
            TopMost = true;
            TopLevel = true;
            timer1.Enabled = false;

        }


        private void WarningOne_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            watch.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            watch.Stop();

            if (isButtonClicked == false)
            {
                runnextwarning();
            }
            

        }

        private void runnextwarning()
        {
            this.Hide();
            var NewForm = new WarningOne();
            NewForm.ShowDialog();
            Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            isButtonClicked = true;
            this.Hide();
            watch.Stop();
            long ms = watch.ElapsedMilliseconds;
            int msint = Convert.ToInt32(ms);
            int final = 120000 - msint;
            wait(final);
            runnextwarning();
        }
    }
}
