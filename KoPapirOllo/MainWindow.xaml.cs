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

namespace KoPapirOllo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int szam = 0;
        int gepszamlal = 0;
        int jatekosszamlal = 0;
        int jatekok = 0;
        Random r = new Random();
        public void Ko_Gomb(object sender, RoutedEventArgs e)
        {
            szam = 1;
            Valasztott.Content = "Kő";
        }
        public void Papir_Gomb(object sender, RoutedEventArgs e)
        {
            szam = 2;
            Valasztott.Content = "Papír";
        }
        public void Ollo_Gomb(object sender, RoutedEventArgs e)
        {
            szam = 3;
            Valasztott.Content = "Olló";
        }
        private void Jatek_Gomb(object sender, RoutedEventArgs e)
        {
            Ko_Gep.Visibility = Visibility.Hidden;
            Papir_Gep.Visibility = Visibility.Hidden;
            Ollo_Gep.Visibility = Visibility.Hidden;
            int rszam=r.Next(3) + 1;
            JatszmakLabel.Content = "Játszmák: " + (jatekok += 1);
            if (rszam == 1 && szam==3)
            {
                Ko_Gep.Visibility=Visibility.Visible;
                GepLabel.Content = "Gép: " + (gepszamlal += 1);
            }
            else if(rszam==1 && szam==2)
            {
                Ko_Gep.Visibility = Visibility.Visible;
                JatekosLabel.Content = "Játékos: " + (jatekosszamlal += 1);
            }
            else if(rszam==1 && szam==1)
            {
                Ko_Gep.Visibility = Visibility.Visible;
            }
            else if(rszam == 2 && szam==1)
            {
                Papir_Gep.Visibility = Visibility.Visible;
                GepLabel.Content = "Gép: " + (gepszamlal += 1);
            }
            else if(rszam==2 && szam==3)
            {
                Papir_Gep.Visibility = Visibility.Visible;
                JatekosLabel.Content = "Játékos: " + (jatekosszamlal += 1);
            }
            else if (rszam == 2 && szam == 2)
            {
                Papir_Gep.Visibility = Visibility.Visible;
            }
            else if(rszam == 3 && szam==2)
            {
                Ollo_Gep.Visibility = Visibility.Visible;
                GepLabel.Content = "Gép: " + (gepszamlal += 1);
            }
            else if(rszam==3 && szam==1)
            {
                Ollo_Gep.Visibility = Visibility.Visible;
                JatekosLabel.Content = "Játékos: " + (jatekosszamlal += 1);
            }
            else if (rszam == 3 && szam == 3)
            {
                Ollo_Gep.Visibility = Visibility.Visible;
            }
        }
    }
}
