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

namespace Kalkulator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float liczba1, wypis;
        int licz;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Jeden_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Text = Wynik.Text + 1;
        }

        private void Dwa_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Text = Wynik.Text + 2;
        }

        private void Trzy_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Text = Wynik.Text + 3;
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Text = Wynik.Text + 0;
        }

        private void Kasowanie_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Clear();
            licz = 0;
        }

        private void Rowne_Click(object sender, RoutedEventArgs e)
        {
            obliczanie(licz);
        }

        private void Dodawanie_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = float.Parse(Wynik.Text);
            Wynik.Clear();
            Wynik.Focus();
            licz = 2;
        }

        private void Odejmowanie_Click(object sender, RoutedEventArgs e)
        {
            if (Wynik.Text != "")
            {
                liczba1 = float.Parse(Wynik.Text);
                Wynik.Clear();
                Wynik.Focus();
                licz = 1;
            }
        }

        private void Cztery_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Text = Wynik.Text + 4;
        }

        private void Piec_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Text = Wynik.Text + 5;
        }

        private void Szesc_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Text = Wynik.Text + 6;
        }

        private void Mnozenie_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = float.Parse(Wynik.Text);
            Wynik.Clear();
            Wynik.Focus();
            licz = 3;
        }

        private void Siedem_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Text = Wynik.Text + 7;
        }

        private void Osiem_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Text = Wynik.Text + 8;
        }

        private void Dziewiec_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Text = Wynik.Text + 9;
        }

        private void Dzielenie_Click(object sender, RoutedEventArgs e)
        {
            liczba1 = float.Parse(Wynik.Text);
            Wynik.Clear();
            Wynik.Focus();
            licz = 4;
        }
        public void obliczanie(int count)
        {
            switch (count)
            {
                case 1:
                    wypis = liczba1 - float.Parse(Wynik.Text);
                    Wynik.Text = wypis.ToString();
                    break;
                case 2:
                    wypis = liczba1 + float.Parse(Wynik.Text);
                    Wynik.Text = wypis.ToString();
                    break;
                case 3:
                    wypis = liczba1 * float.Parse(Wynik.Text);
                    Wynik.Text = wypis.ToString();
                    break;
                case 4:
                    if (float.Parse(Wynik.Text) != 0)
                    {
                        wypis = liczba1 / float.Parse(Wynik.Text);
                        Wynik.Text = wypis.ToString();
                    }
                    else
                        Wynik.Text = "Nie można dzielić przez zero";
                        break;
                default:
                    break;
            }
        }

        }
}
