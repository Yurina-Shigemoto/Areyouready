using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace 準備はいいか
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch = new Stopwatch();
        private Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000; // 1秒ごとに更新
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                timer.Stop();
                btnStartStop.Text = "Start";
            }
            else
            {
                stopwatch.Start();
                timer.Start();
                btnStartStop.Text = "Stop";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            lblTime.Text = "00:00:00";
            btnStartStop.Text = "Start";
        }
    }
}