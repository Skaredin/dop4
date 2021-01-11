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

namespace Dep4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddBut_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Add("Add strok");
        }

        private void RemovBut_Click(object sender, RoutedEventArgs e)
        {
            list.Items.RemoveAt(4);
        }

        private void AddButSoobs_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Add(list.Items.Count.ToString());
        }

        private void AddButSoobs_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadanie_2 zadanie_2 = new Zadanie_2();
            zadanie_2.Show();
        }
    }
}
