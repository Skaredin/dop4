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
    /// Логика взаимодействия для Zadanie_10.xaml
    /// </summary>
    public partial class Zadanie_10 : Window
    {
        public Zadanie_10()
        {
            InitializeComponent();
        }
     
            private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem treeViewItem = (TreeViewItem)sender;
            MessageBox.Show("Yzel " + treeViewItem.Header.ToString()+" Raskrit") ;
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem treeViewItem = (TreeViewItem)sender;
            MessageBox.Show("Vibran Yzel " + treeViewItem.Header.ToString());
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Hide();
            Zadanie_11 zadanie_11 = new Zadanie_11();
            zadanie_11.Show();
        }

    
    }
}
