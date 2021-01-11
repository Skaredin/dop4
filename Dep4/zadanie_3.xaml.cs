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
    /// Логика взаимодействия для zadanie_3.xaml
    /// </summary>
    public partial class zadanie_3 : Window
    {
        public zadanie_3()
        {
            InitializeComponent();
        }

        private void AddButSoobs_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadanie_4 zadanie_4 = new Zadanie_4();
            zadanie_4.Show();
        }
    }
}
