﻿using System;
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
    /// Логика взаимодействия для Zadanie_5.xaml
    /// </summary>
    public partial class Zadanie_5 : Window
    {
        public Zadanie_5()
        {
            InitializeComponent();
        }

        private void Anim1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Ilement vibron!!!!");

        }

        private void AddButSoobs_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Zadanie_6 zadanie_6 = new Zadanie_6();
            zadanie_6.Show();
        }
    }
}
