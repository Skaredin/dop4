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
    /// Логика взаимодействия для Zadanie_11.xaml
    /// </summary>
    public partial class Zadanie_11 : Window
    {
        public Zadanie_11()
        {
            InitializeComponent();
        }

        private void Nul(object sender, RoutedEventArgs e)
        {
            TextKal.Text = TextKal.Text + 0;
        }

        private void Ed(object sender, RoutedEventArgs e)
        {
            TextKal.Text = TextKal.Text + 1;
        }

        private void Dv(object sender, RoutedEventArgs e)
        {
            TextKal.Text = TextKal.Text + 2;
        }

        private void Tr(object sender, RoutedEventArgs e)
        {
            TextKal.Text = TextKal.Text + 3;
        }

        private void Ce(object sender, RoutedEventArgs e)
        {
            TextKal.Text = TextKal.Text + 4;
        }

        private void Pa(object sender, RoutedEventArgs e)
        {
            TextKal.Text = TextKal.Text + 5;
        }

        private void Se(object sender, RoutedEventArgs e)
        {
            TextKal.Text = TextKal.Text + 6;
        }

        private void Sem(object sender, RoutedEventArgs e)
        {
            TextKal.Text = TextKal.Text + 7;
        }

        private void Vo(object sender, RoutedEventArgs e)
        {
            TextKal.Text = TextKal.Text + 8;
        }

        private void De(object sender, RoutedEventArgs e)
        {
            TextKal.Text = TextKal.Text + 9;
        }

        private void Zap(object sender, RoutedEventArgs e)
        {
            TextKal.Text = TextKal.Text + ",";
        }
        
        float a, b;
        int count;
        bool znak = true;

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(TextKal.Text);
                    TextKal.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(TextKal.Text);
                    TextKal.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(TextKal.Text);
                    TextKal.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(TextKal.Text);
                    TextKal.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }

        private void Plu(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextKal.Text);
            TextKal.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void Pro(object sender, RoutedEventArgs e)
        {

        }

        private void Min(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextKal.Text);
            TextKal.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void Rav(object sender, RoutedEventArgs e)
        {
            calculate();
            TextKal.Text = "";
        }

        private void Umn(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextKal.Text);
            TextKal.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void Dell(object sender, RoutedEventArgs e)
        {
            TextKal.Text = "";
            label1.Text = "";
        }

        private void Delll(object sender, RoutedEventArgs e)
        {
            int lenght = TextKal.Text.Length - 1;
            string text = TextKal.Text;
            TextKal.Clear();
            for (int i = 0; i < lenght; i++)
            {
                TextKal.Text = TextKal.Text + text[i];
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Del(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextKal.Text);
            TextKal.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }



    }
}
