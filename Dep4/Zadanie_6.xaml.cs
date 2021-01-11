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
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Input;
namespace Dep4
{
    /// <summary>
    /// Логика взаимодействия для Zadanie_6.xaml
    /// </summary>
    public partial class Zadanie_6 : Window
    {
        public DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public Zadanie_6()
        {
            InitializeComponent();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new System.TimeSpan(0, 0, 0, 0, 1000/60);

        }
       
        private void DispatcherTimer_Tick(object sender, System.EventArgs e)
        {
            image.Margin = new Thickness(Mouse.GetPosition(this).X-25, Mouse.GetPosition(this).Y-25, 0, 0);
        }
        private void image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            dispatcherTimer.Start();
        }

        private void image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            dispatcherTimer.Stop();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadanie_7 zadanie_7 = new Zadanie_7();
            zadanie_7.Show();
        }
    }
}
