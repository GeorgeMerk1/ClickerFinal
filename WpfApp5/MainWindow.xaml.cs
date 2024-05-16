using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Timers;
using System.Diagnostics;

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        public ProgressBar x;
        public double y;
        public int VauleNegr;
        public int VauleNegrFace;
        public int VauleNormGay;
        public static double stamina = 50;

        
        public MainWindow()
        {
            InitializeComponent();
            ProgresBarNegr.Value = VauleNegr;
            ProgresBarNegrFace.Value = VauleNegrFace;
            ProgresBarNormGay.Value = VauleNormGay;
            ProgresBarNegr.Maximum = 5000;
            ProgresBarNegrFace.Maximum = 5000;
            ProgresBarNormGay.Maximum = 5000;
            x = ProgresBarNegr;
            y = VauleNegr;

            Stopwatch stopwatch = new Stopwatch();

            Task timerTask = Task.Run(() =>
            {
                stopwatch.Start();
                while (true)
                {
                    Thread.Sleep(5000);
                    stamina += 5;
                }
            });
        }

        private void Clicker_Click(object sender, RoutedEventArgs e)
        {
            {
                if (stamina > 0)
                {
                    stamina -= 1;
                }
                if (stamina > 0)
                {
                    x.Value += 10;
                    if (x.Value >= 100 && x.Value < 200)
                    {
                        x.Value += 20;
                    }
                    if (x.Value >= 200 && x.Value < 300)
                    {
                        x.Value += 30;
                    }
                    if (x.Value >= 300)
                    {
                        x.Value += 40;
                    }
                }
                if (ProgresBarNegr.Value == 5000 && ProgresBarNegrFace.Value == 5000 && ProgresBarNormGay.Value == 5000)
                {
                    ProgresBarNegr.Value = 0;
                    ProgresBarNegrFace.Value = 0;
                    ProgresBarNormGay.Value = 0;
                    ProgresBarNegr.Maximum += 10000;
                    ProgresBarNegrFace.Maximum += 10000;
                    ProgresBarNormGay.Maximum += 10000;
                }
                if (ProgresBarNegr.Value == 15000 && ProgresBarNegrFace.Value == 15000 && ProgresBarNormGay.Value == 15000)
                {
                    MessageBox.Show("Putin\n ⣿⣿⣿⣿⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣵⣿⣿⣿⠿⡟⣛⣧⣿⣯⣿⣝⡻⢿⣿⣿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⣿⠋⠁⣴⣶⣿⣿⣿⣿⣿⣿⣿⣦⣍⢿⣿⣿⣿⣿⣿\r\n⣿⣿⣿⣿⢷⠄⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⢼⣿⣿⣿⣿\r\n⢹⣿⣿⢻⠎⠔⣛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⣿⣿⣿⣿\r\n⢸⣿⣿⠇⡶⠄⣿⣿⠿⠟⡛⠛⠻⣿⡿⠿⠿⣿⣗⢣⣿⣿⣿⣿\r\n⠐⣿⣿⡿⣷⣾⣿⣿⣿⣾⣶⣶⣶⣿⣁⣔⣤⣀⣼⢲⣿⣿⣿⣿\r\n⠄⣿⣿⣿⣿⣾⣟⣿⣿⣿⣿⣿⣿⣿⡿⣿⣿⣿⢟⣾⣿⣿⣿⣿\r\n⠄⣟⣿⣿⣿⡷⣿⣿⣿⣿⣿⣮⣽⠛⢻⣽⣿⡇⣾⣿⣿⣿⣿⣿\r\n⠄⢻⣿⣿⣿⡷⠻⢻⡻⣯⣝⢿⣟⣛⣛⣛⠝⢻⣿⣿⣿⣿⣿⣿\r\n⠄⠸⣿⣿⡟⣹⣦⠄⠋⠻⢿⣶⣶⣶⡾⠃⡂⢾⣿⣿⣿⣿⣿⣿\r\n⠄⠄⠟⠋⠄⢻⣿⣧⣲⡀⡀⠄⠉⠱⣠⣾⡇⠄⠉⠛⢿⣿⣿⣿\r\n⠄⠄⠄⠄⠄⠈⣿⣿⣿⣷⣿⣿⢾⣾⣿⣿⣇⠄⠄⠄⠄⠄⠉⠉\r\n⠄⠄⠄⠄⠄⠄⠸⣿⣿⠟⠃⠄⠄⢈⣻⣿⣿⠄⠄⠄⠄⠄⠄⠄\r\n⠄⠄⠄⠄⠄⠄⠄⢿⣿⣾⣷⡄⠄⢾⣿⣿⣿⡄⠄⠄⠄⠄⠄⠄\r\n⠄⠄⠄⠄⠄⠄⠄⠸⣿⣿⣿⠃⠄⠈⢿⣿⣿⠄⠄⠄⠄⠄⠄⠄");
                    Close();
                }
            }


        }
        private void LocationOne_Click(object sender, RoutedEventArgs e)
        {
            x = ProgresBarNegr;
        }

        private void LocationTwo_Click(object sender, RoutedEventArgs e)
        {
            x = ProgresBarNegrFace;
        }

        private void LocationThree_Click(object sender, RoutedEventArgs e)
        {
            x = ProgresBarNormGay;
        }
    }
}