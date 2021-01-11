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
    /// Логика взаимодействия для Zadanie_4.xaml
    /// </summary>
    public partial class Zadanie_4 : Window
    {
        public Zadanie_4()
        {
            InitializeComponent();
            
        }

        private void List2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddButSoobs_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadanie_5 zadanie_5 = new Zadanie_5();
            zadanie_5.Show();
        }
    }
}
