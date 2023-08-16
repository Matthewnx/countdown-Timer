using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Timers;
using System.Windows.Threading;

namespace Timer_countdown
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DateTime TargetTime = new DateTime(2023, 12, 5, 12, 0, 0);
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer intervaltimer = new DispatcherTimer();
            intervaltimer.Interval = TimeSpan.FromSeconds(1);
            intervaltimer.IsEnabled = true;
            intervaltimer.Tick += new EventHandler(TimerTick);
            intervaltimer.Start();
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }


        public void TimerTick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan remining = TargetTime.Subtract(now);
            day_timer.Text = Convert.ToString(remining.Days);
            hour_timer.Text = Convert.ToString(remining.Hours);
            minute_timer.Text = Convert.ToString(remining.Minutes);
            second_timer.Text = Convert.ToString(remining.Seconds);
        }
    }
}
