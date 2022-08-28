using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.IO;
using System.Reflection;
using JR.Utils.GUI.Forms;


namespace Time_reminder_application
{
    public partial class MainForm : Form
    {
        private SoundPlayer soundplayer1;
        private SoundPlayer endOftimesp;
        private SoundPlayer backStraightsp;
        string sp1dir = @"C:\Users\" + Environment.UserName + @"\Appdata\Roaming\write ur time\writeurtime.wav";
        string eotdir = @"C:\Users\" + Environment.UserName + @"\Appdata\Roaming\write ur time\eot.wav";
        string backStraight = @"C:\Users\" + Environment.UserName + @"\Appdata\Roaming\write ur time\Just remember to keep your back straight.wav";

        public MainForm()
        {
            InitializeComponent();
            soundplayer1 = new SoundPlayer(sp1dir);
            endOftimesp = new SoundPlayer(eotdir);
            backStraightsp = new SoundPlayer(backStraight);
            PassedTime.Visible = false;
            PassedTime.Enabled = false;
            labelPassedTime.Visible = false;
            labelPassedTime.Enabled = false;
            RemainTime.Visible = false;
            RemainTime.Enabled = false;
            labelRemainTime.Visible = false;
            labelRemainTime.Enabled = false;
            ElapsedTimer.Enabled = false;
            PauseButton.Visible = false;
            PauseButton.Enabled = false;
            UnPauseButton.Visible = false;
            UnPauseButton.Enabled = false;
            TimeQuestion.Visible = false;
            TimeQuestion.Enabled = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            MinuteReminder.Visible = false;
            MinuteReminder.Enabled = false;
            button1.Visible = false;
            button1.Enabled = false;
            
        }

        class Global
        {
            public static Stopwatch stopwatch = new Stopwatch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TimeQuestion.Visible = true;
            TimeQuestion.Enabled = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            MinuteReminder.Visible = true;
            MinuteReminder.Enabled = true;
            button1.Visible = true;
            button1.Enabled = true;
            if (!File.Exists(@"C:\Users\" + Environment.UserName + @"\Appdata\Roaming\write ur time\8d8392jdjlkwjd932jldkjalwjalajd98.jpg"))
            {
                Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\Appdata\Roaming\write ur time");
                Extract("Time_reminder_application", @"C:\Users\" + Environment.UserName + @"\Appdata\Roaming\write ur time\", "Resources", "8d8392jdjlkwjd932jldkjalwjalajd98.jpg");
                Extract("Time_reminder_application", @"C:\Users\" + Environment.UserName + @"\Appdata\Roaming\write ur time\", "Resources", "eot.wav");
                Extract("Time_reminder_application", @"C:\Users\" + Environment.UserName + @"\Appdata\Roaming\write ur time\", "Resources", "writeurtime.wav");
                Extract("Time_reminder_application", @"C:\Users\" + Environment.UserName + @"\Appdata\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\", "Resources", "run time reminder app.bat");
                Extract("Time_reminder_application", @"C:\Users\" + Environment.UserName + @"\Appdata\Roaming\write ur time\", "Resources", "Time reminder application.exe");
                Extract("Time_reminder_application", @"C:\Users\" + Environment.UserName + @"\Appdata\Roaming\write ur time\", "Resources", "Just remember to keep your back straight.wav");
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 3;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            backTimer.Start();
            soundplayer1.Play();
            Global.stopwatch.Start();            
            ElapsedTimer.Start();
            TimeQuestion.Visible = false;
            TimeQuestion.Enabled = false;
            textBox1.Visible = false;
            textBox1.Enabled = false;
            MinuteReminder.Visible = false;
            MinuteReminder.Enabled = false;
            button1.Visible = false;
            button1.Enabled = false;
            UnPauseButton.Visible = true;
            PauseButton.Visible = true;
            PauseButton.Enabled = true;
            labelPassedTime.Enabled = true;
            labelPassedTime.Visible = true;
            PassedTime.Enabled = true;
            PassedTime.Visible = true;
            ElapsedTimer.Enabled = true;
            ElapsedTimer.Start();
            labelRemainTime.Enabled = true;
            labelRemainTime.Visible = true;
            RemainTime.Enabled = true;
            RemainTime.Visible = true;

        }


        private void PauseButton_Click(object sender, EventArgs e)
        {
            Global.stopwatch.Stop();
            UnPauseButton.Enabled = true;
            PauseButton.Enabled = false;
            backTimer.Stop();
            
        }

        private void UnPauseButton_Click(object sender, EventArgs e)
        {
            long longstopwatchtime = Global.stopwatch.ElapsedMilliseconds;
            int stopwatchtime = Convert.ToInt32(longstopwatchtime);
            UnPauseButton.Enabled = false;
            PauseButton.Enabled = true;
            Global.stopwatch.Start();
            backTimer.Start();

        }

        private void ElapsedTimer_Tick(object sender, EventArgs e)
        {
            //passedtime
            TimeSpan ts = Global.stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            PassedTime.Text = elapsedTime;

            //remain time
            string strText = textBox1.Text;
            int screentime = Int32.Parse(strText) * 60000;
            long msts_ = Global.stopwatch.ElapsedMilliseconds;
            int msts = Convert.ToInt32(msts_);
            int remainms = (screentime - msts) + 1000;
            TimeSpan ts_remain = TimeSpan.FromMilliseconds(remainms);

            string remainTime = String.Format("{0:00}:{1:00}:{2:00}",ts_remain.Hours, ts_remain.Minutes, ts_remain.Seconds);
            RemainTime.Text = remainTime;
            if (remainms <= 0 && remainms > -10000)
            {
                Warning();
                
            }


        }
        private void Warning()
        {
            endOftimesp.Play();
            Global.stopwatch.Stop();
            Global.stopwatch.Reset();
            this.Hide();
            var NewForm = new TimesUpForm();
            NewForm.ShowDialog();
            this.Close();
        }

        private static void Extract(string nameSpace, string outdir, string internalFilePath, string ResourceName)
        {
            Assembly ass = Assembly.GetCallingAssembly();
            using (Stream s = ass.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + ResourceName))
            {
                using (BinaryReader r = new BinaryReader(s))
                {
                    using (FileStream fs = new FileStream(outdir + "\\" + ResourceName, FileMode.OpenOrCreate))
                    {
                        using (BinaryWriter w = new BinaryWriter(fs))
                        {
                            w.Write(r.ReadBytes((int)s.Length));

                        }
                    }
                }
            }
        }

        private void backTimer_Tick(object sender, EventArgs e)
        {
            backTimer.Stop();

            backStraightsp.Play();

            backTimer.Start();
        }
    }
}
