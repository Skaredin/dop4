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
    /// Логика взаимодействия для Zadanie_7.xaml
    /// </summary>
    public partial class Zadanie_7 : Window
    {
        public Zadanie_7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadanie_8 zadanie_8 = new Zadanie_8();
            zadanie_8.Show();
        }
    }
}
