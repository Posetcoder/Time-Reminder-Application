
namespace Time_reminder_application
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimeQuestion = new System.Windows.Forms.Label();
            this.MinuteReminder = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.UnPauseButton = new System.Windows.Forms.Button();
            this.ElapsedTimer = new System.Windows.Forms.Timer(this.components);
            this.labelPassedTime = new System.Windows.Forms.Label();
            this.PassedTime = new System.Windows.Forms.Label();
            this.labelRemainTime = new System.Windows.Forms.Label();
            this.RemainTime = new System.Windows.Forms.Label();
            this.backTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeQuestion
            // 
            this.TimeQuestion.AutoSize = true;
            this.TimeQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeQuestion.Location = new System.Drawing.Point(12, 51);
            this.TimeQuestion.Name = "TimeQuestion";
            this.TimeQuestion.Size = new System.Drawing.Size(763, 33);
            this.TimeQuestion.TabIndex = 0;
            this.TimeQuestion.Text = "Please enter how much time you want to play (in minutes)";
            // 
            // MinuteReminder
            // 
            this.MinuteReminder.AutoSize = true;
            this.MinuteReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteReminder.Location = new System.Drawing.Point(495, 191);
            this.MinuteReminder.Name = "MinuteReminder";
            this.MinuteReminder.Size = new System.Drawing.Size(109, 31);
            this.MinuteReminder.TabIndex = 2;
            this.MinuteReminder.Text = "minutes";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(286, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 44);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(310, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.Color.Red;
            this.PauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseButton.Location = new System.Drawing.Point(168, 318);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(186, 70);
            this.PauseButton.TabIndex = 5;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // UnPauseButton
            // 
            this.UnPauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.UnPauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnPauseButton.Location = new System.Drawing.Point(458, 318);
            this.UnPauseButton.Name = "UnPauseButton";
            this.UnPauseButton.Size = new System.Drawing.Size(173, 70);
            this.UnPauseButton.TabIndex = 6;
            this.UnPauseButton.Text = "Unpause";
            this.UnPauseButton.UseVisualStyleBackColor = false;
            this.UnPauseButton.Click += new System.EventHandler(this.UnPauseButton_Click);
            // 
            // ElapsedTimer
            // 
            this.ElapsedTimer.Interval = 1000;
            this.ElapsedTimer.Tick += new System.EventHandler(this.ElapsedTimer_Tick);
            // 
            // labelPassedTime
            // 
            this.labelPassedTime.AutoSize = true;
            this.labelPassedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassedTime.Location = new System.Drawing.Point(220, 115);
            this.labelPassedTime.Name = "labelPassedTime";
            this.labelPassedTime.Size = new System.Drawing.Size(156, 29);
            this.labelPassedTime.TabIndex = 7;
            this.labelPassedTime.Text = "passed time: ";
            // 
            // PassedTime
            // 
            this.PassedTime.AutoSize = true;
            this.PassedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassedTime.Location = new System.Drawing.Point(436, 115);
            this.PassedTime.Name = "PassedTime";
            this.PassedTime.Size = new System.Drawing.Size(103, 29);
            this.PassedTime.TabIndex = 8;
            this.PassedTime.Text = "00:00:00";
            // 
            // labelRemainTime
            // 
            this.labelRemainTime.AutoSize = true;
            this.labelRemainTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainTime.Location = new System.Drawing.Point(192, 164);
            this.labelRemainTime.Name = "labelRemainTime";
            this.labelRemainTime.Size = new System.Drawing.Size(184, 29);
            this.labelRemainTime.TabIndex = 9;
            this.labelRemainTime.Text = "remaining time: ";
            // 
            // RemainTime
            // 
            this.RemainTime.AutoSize = true;
            this.RemainTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainTime.Location = new System.Drawing.Point(436, 164);
            this.RemainTime.Name = "RemainTime";
            this.RemainTime.Size = new System.Drawing.Size(103, 29);
            this.RemainTime.TabIndex = 10;
            this.RemainTime.Text = "00:00:00";
            // 
            // backTimer
            // 
            this.backTimer.Interval = 10000;
            this.backTimer.Tick += new System.EventHandler(this.backTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.RemainTime);
            this.Controls.Add(this.labelRemainTime);
            this.Controls.Add(this.PassedTime);
            this.Controls.Add(this.labelPassedTime);
            this.Controls.Add(this.UnPauseButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MinuteReminder);
            this.Controls.Add(this.TimeQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Timer App V. mehrad.alpha 0.3252 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeQuestion;
        private System.Windows.Forms.Label MinuteReminder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button UnPauseButton;
        private System.Windows.Forms.Timer ElapsedTimer;
        private System.Windows.Forms.Label labelPassedTime;
        private System.Windows.Forms.Label PassedTime;
        private System.Windows.Forms.Label labelRemainTime;
        private System.Windows.Forms.Label RemainTime;
        private System.Windows.Forms.Timer backTimer;
    }
}

