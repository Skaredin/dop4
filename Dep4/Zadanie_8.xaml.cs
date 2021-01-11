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
    /// Логика взаимодействия для Zadanie_8.xaml
    /// </summary>
    public partial class Zadanie_8 : Window
    {
        public Zadanie_8()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadanie_9 zadanie_9 = new Zadanie_9();
            zadanie_9.Show();
 
            

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
