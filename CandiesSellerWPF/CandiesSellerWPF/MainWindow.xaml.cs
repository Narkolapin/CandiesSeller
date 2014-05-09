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

namespace CandiesSellerWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Panier Panier1 = new Panier();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClickBouton100GSkittles(object sender, RoutedEventArgs e)
        {
            Panier1.QSkittles = Panier1.QSkittles + 0.1;
            LQSkittles2.Content = Panier1.QSkittles.ToString();
        }

        private void OnClickBouton1KGSkittles(object sender, RoutedEventArgs e)
        {
            Panier1.QSkittles = Panier1.QSkittles + 1;
            LQSkittles2.Content = Panier1.QSkittles.ToString();
        }

        private void OnClickBouton100GCottonCandy(object sender, RoutedEventArgs e)
        {
            Panier1.QCottonCandy = Panier1.QCottonCandy + 0.1;
            LQCottonCandy2.Content = Panier1.QCottonCandy.ToString();

        }

        private void OnClickBouton1KGCottonCandy(object sender, RoutedEventArgs e)
        {
            Panier1.QCottonCandy = Panier1.QCottonCandy + 1;
            LQCottonCandy2.Content = Panier1.QCottonCandy.ToString();

        }

        private void OnClickBouton100GCreamEgg(object sender, RoutedEventArgs e)
        {
            Panier1.QCreamEgg = Panier1.QCreamEgg + 0.1;
            LQCreamEgg2.Content = Panier1.QCreamEgg.ToString();
        }

        private void OnClickBouton1KGCreamEgg(object sender, RoutedEventArgs e)
        {
            Panier1.QCreamEgg = Panier1.QCreamEgg + 1;
            LQCreamEgg2.Content = Panier1.QCreamEgg.ToString();
        }

        private void OnClickBouton100GJawbreaker(object sender, RoutedEventArgs e)
        {
            Panier1.QJawbreaker = Panier1.QJawbreaker + 0.1;
            LQJawbreaker2.Content = Panier1.QJawbreaker.ToString();
        }

        private void OnClickBouton1KGJawbreaker(object sender, RoutedEventArgs e)
        {
            Panier1.QJawbreaker = Panier1.QJawbreaker + 1;
            LQJawbreaker2.Content = Panier1.QJawbreaker.ToString();
        }

        private void OnClickBouton100GRedvineLicornes(object sender, RoutedEventArgs e)
        {
            Panier1.QRedvinesLicornes = Panier1.QRedvinesLicornes + 0.1;
            LQRedvineLicornes2.Content = Panier1.QRedvinesLicornes.ToString();
        }

        private void OnClickBouton1KGRedvineLicornes(object sender, RoutedEventArgs e)
        {
            Panier1.QRedvinesLicornes = Panier1.QRedvinesLicornes + 1;
            LQRedvineLicornes2.Content = Panier1.QRedvinesLicornes.ToString();
        }

        private void OnClickBouton100GSugarDaddy(object sender, RoutedEventArgs e)
        {
            Panier1.QSugarDaddy = Panier1.QSugarDaddy + 0.1;
            LQSugarDaddy2.Content = Panier1.QSugarDaddy.ToString();
        }

        private void OnClickBouton1KGSugarDaddy(object sender, RoutedEventArgs e)
        {
            Panier1.QSugarDaddy = Panier1.QSugarDaddy + 1;
            LQSugarDaddy2.Content = Panier1.QSugarDaddy.ToString();
        }

   

    }
}
