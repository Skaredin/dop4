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

namespace Dep4
{
    /// <summary>
    /// Логика взаимодействия для Zadanie_2.xaml
    /// </summary>
    public partial class Zadanie_2 : Window
    {
        public Zadanie_2()
        {
            InitializeComponent();
            string[] ani = { "Volk", "Lisa", "Zaec" };
            list.ItemsSource = ani;
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(list.SelectedItem.ToString());
        }

        private void AddButSoobs_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            zadanie_3 zadanie_3 = new zadanie_3();
            zadanie_3.Show();
        }
    }
}
