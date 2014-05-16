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
        ServiceReference1.stockBusiness stock = new ServiceReference1.stockBusiness();
        ServiceReference1.CandiesClient service1 = new ServiceReference1.CandiesClient();
        double PriceSkittles, PriceCottonCandy, PriceJawbreaker, PriceSugarDaddy, Priceredvinelicornes, PriceCreamEgg;

        public MainWindow()
        {
            InitializeComponent();

            PriceSkittles = service1.getPrice().Skittle_price;
            LPriceSkittles.Content = PriceSkittles.ToString();

            PriceCottonCandy = service1.getPrice().cottoncandy_price;
            LPriceCottonCandy.Content = PriceCottonCandy.ToString();

            PriceJawbreaker = service1.getPrice().jawbreaker_price;
            LPriceJawbreaker.Content = PriceJawbreaker.ToString();

            PriceSugarDaddy = service1.getPrice().sugardaddy_price;
            LPriceSugarDaddy.Content = PriceSugarDaddy.ToString();

            Priceredvinelicornes = service1.getPrice().redvinelicornes_price;
            LPriceRevineLicornes.Content = Priceredvinelicornes.ToString();

            PriceCreamEgg = service1.getPrice().creamegg_price;
            LPriceCreamEgg.Content = PriceCreamEgg.ToString();


            LQSkittlesD.Content = stock.Skittles;
            LQCottonCandyD.Content = stock.cottoncandy;
            LQCreamEggD.Content = stock.creamegg;
            LQJawbreakerD.Content = stock.jawbreaker;
            LQRedvineLicornesD.Content = stock.redvinelicornes;
            LQSugarDaddyD.Content = stock.sugardaddy;

        }

        private void OnClickBoutonConnexion(object sender, RoutedEventArgs e)
        { 
        
        }

        private void OnClickBouton100GSkittles(object sender, RoutedEventArgs e)
        {
            Panier1.QSkittles = Panier1.QSkittles + 0.1;
            LQSkittles2.Content = Panier1.QSkittles.ToString();
            Panier1.PricePanier = Panier1.PricePanier + PriceSkittles * Panier1.QSkittles;
            Panier1.PricePanier = Math.Round(Panier1.PricePanier, 2);
            LPricePanier.Content = Panier1.PricePanier; 
        }

        private void OnClickBouton1KGSkittles(object sender, RoutedEventArgs e)
        {
            Panier1.QSkittles = Panier1.QSkittles + 1;
            LQSkittles2.Content = Panier1.QSkittles.ToString();
            Panier1.PricePanier = Panier1.PricePanier + PriceSkittles * Panier1.QSkittles;
            Panier1.PricePanier = Math.Round(Panier1.PricePanier, 2);
            LPricePanier.Content = Panier1.PricePanier; 
        }

        private void OnClickBouton100GCottonCandy(object sender, RoutedEventArgs e)
        {
            Panier1.QCottonCandy = Panier1.QCottonCandy + 0.1;
            LQCottonCandy2.Content = Panier1.QCottonCandy.ToString();
            Panier1.PricePanier = Panier1.PricePanier + PriceCottonCandy * Panier1.QCottonCandy;
            Panier1.PricePanier = Math.Round(Panier1.PricePanier, 2);
            LPricePanier.Content = Panier1.PricePanier; 
        }

        private void OnClickBouton1KGCottonCandy(object sender, RoutedEventArgs e)
        {
            Panier1.QCottonCandy = Panier1.QCottonCandy + 1;
            LQCottonCandy2.Content = Panier1.QCottonCandy.ToString();
            Panier1.PricePanier = Panier1.PricePanier + PriceCottonCandy * Panier1.QCottonCandy;
            Panier1.PricePanier = Math.Round(Panier1.PricePanier, 2);
            LPricePanier.Content = Panier1.PricePanier; 
        }

        private void OnClickBouton100GCreamEgg(object sender, RoutedEventArgs e)
        {
            Panier1.QCreamEgg = Panier1.QCreamEgg + 0.1;
            LQCreamEgg2.Content = Panier1.QCreamEgg.ToString();
            Panier1.PricePanier = Panier1.PricePanier + PriceCreamEgg * Panier1.QCreamEgg;
            Panier1.PricePanier = Math.Round(Panier1.PricePanier, 2);
            LPricePanier.Content = Panier1.PricePanier; 
        }

        private void OnClickBouton1KGCreamEgg(object sender, RoutedEventArgs e)
        {
            Panier1.QCreamEgg = Panier1.QCreamEgg + 1;
            LQCreamEgg2.Content = Panier1.QCreamEgg.ToString();
            Panier1.PricePanier = Panier1.PricePanier + PriceCreamEgg * Panier1.QCreamEgg;
            Panier1.PricePanier = Math.Round(Panier1.PricePanier, 2);
            LPricePanier.Content = Panier1.PricePanier; 
        }

        private void OnClickBouton100GJawbreaker(object sender, RoutedEventArgs e)
        {
            Panier1.QJawbreaker = Panier1.QJawbreaker + 0.1;
            LQJawbreaker2.Content = Panier1.QJawbreaker.ToString();
            Panier1.PricePanier = Panier1.PricePanier + PriceJawbreaker * Panier1.QJawbreaker;
            Panier1.PricePanier = Math.Round(Panier1.PricePanier, 2);
            LPricePanier.Content = Panier1.PricePanier; 
        }

        private void OnClickBouton1KGJawbreaker(object sender, RoutedEventArgs e)
        {
            Panier1.QJawbreaker = Panier1.QJawbreaker + 1;
            LQJawbreaker2.Content = Panier1.QJawbreaker.ToString();
            Panier1.PricePanier = Panier1.PricePanier + PriceJawbreaker * Panier1.QJawbreaker;
            Panier1.PricePanier = Math.Round(Panier1.PricePanier, 2);
            LPricePanier.Content = Panier1.PricePanier; 
        }

        private void OnClickBouton100GRedvineLicornes(object sender, RoutedEventArgs e)
        {
            Panier1.QRedvinesLicornes = Panier1.QRedvinesLicornes + 0.1;
            LQRedvineLicornes2.Content = Panier1.QRedvinesLicornes.ToString();
            Panier1.PricePanier = Panier1.PricePanier + Priceredvinelicornes * Panier1.QRedvinesLicornes;
            Panier1.PricePanier = Math.Round(Panier1.PricePanier, 2);
            LPricePanier.Content = Panier1.PricePanier; 
        }

        private void OnClickBouton1KGRedvineLicornes(object sender, RoutedEventArgs e)
        {
            Panier1.QRedvinesLicornes = Panier1.QRedvinesLicornes + 1;
            LQRedvineLicornes2.Content = Panier1.QRedvinesLicornes.ToString();
            Panier1.PricePanier = Panier1.PricePanier + Priceredvinelicornes * Panier1.QRedvinesLicornes;
            Panier1.PricePanier = Math.Round(Panier1.PricePanier, 2);
            LPricePanier.Content = Panier1.PricePanier; 
        }

        private void OnClickBouton100GSugarDaddy(object sender, RoutedEventArgs e)
        {
            Panier1.QSugarDaddy = Panier1.QSugarDaddy + 0.1;
            LQSugarDaddy2.Content = Panier1.QSugarDaddy.ToString();
            Panier1.PricePanier = Panier1.PricePanier + PriceSugarDaddy * Panier1.QSugarDaddy;
            Panier1.PricePanier = Math.Round(Panier1.PricePanier, 2);
            LPricePanier.Content = Panier1.PricePanier; 
        }

        private void OnClickBouton1KGSugarDaddy(object sender, RoutedEventArgs e)
        {
            Panier1.QSugarDaddy = Panier1.QSugarDaddy + 1;
            LQSugarDaddy2.Content = Panier1.QSugarDaddy.ToString();
            Panier1.PricePanier = Panier1.PricePanier + PriceSugarDaddy * Panier1.QSugarDaddy;
            Panier1.PricePanier = Math.Round(Panier1.PricePanier, 2);
            LPricePanier.Content = Panier1.PricePanier; 
        }

        private void OnClickBCommand(object sender, RoutedEventArgs e)
        {
            TBNom.Visibility = System.Windows.Visibility.Visible;
            TBFirstName.Visibility = System.Windows.Visibility.Visible;
            TBAdresse.Visibility = System.Windows.Visibility.Visible;
            BValidation.Visibility = System.Windows.Visibility.Visible;
        }

        private void OnClickBValidation(object sender, RoutedEventArgs e)
        {
            ServiceReference1.userBusiness user = new ServiceReference1.userBusiness();
            ServiceReference1.Panier PanierWCF = new ServiceReference1.Panier()
            {
                QSkittles = Panier1.QSkittles,
                QCottonCandy = Panier1.QCottonCandy,
                QCreamEgg = Panier1.QCreamEgg,
                QJawbreaker = Panier1.QJawbreaker,
                QRedvinesLicornes = Panier1.QRedvinesLicornes,
                QSugarDaddy = Panier1.QSugarDaddy
            };
            user.nom = TBNom.Text;
            user.prenom = TBFirstName.Text;
            user.adresse = TBAdresse.Text;
            
            service1.setOrder(user, PanierWCF);
            MessageBox.Show("Commande validée");
            TBNom.Visibility = System.Windows.Visibility.Hidden;
            TBFirstName.Visibility = System.Windows.Visibility.Hidden;
            TBAdresse.Visibility = System.Windows.Visibility.Hidden;
            BValidation.Visibility = System.Windows.Visibility.Hidden;
        }

        /*----------------------------------------------------------------------------------*/
        // ONGLET ADMIN
        /*----------------------------------------------------------------------------------*/

        private void OnClickBouton100GSkittles2(object sender, RoutedEventArgs e)
        {
            stock.Skittles = stock.Skittles + 0.1;
            LQSkittles4.Content = stock.Skittles.ToString();
        }

        private void OnClickBouton1KGSkittles2(object sender, RoutedEventArgs e)
        {
            stock.Skittles = stock.Skittles + 1;
            LQSkittles4.Content = stock.Skittles.ToString();
        }

        private void OnClickManuelSkittles(object sender, RoutedEventArgs e)
        {
            string ajout = AjoutManuel.Text;
            
            if (ajout.Equals(""))
            {
                MessageBox.Show("zone de saisie vide");
            }
            else
            {
                double ajouter = Convert.ToDouble(ajout);
                stock.Skittles = stock.Skittles + ajouter;
                LQSkittles4.Content = stock.Skittles;
            }
        }

        private void OnClickBouton100GCottonCandy2(object sender, RoutedEventArgs e)
        {
            stock.cottoncandy = stock.cottoncandy + 0.1;
            LQCottonCandy4.Content = stock.cottoncandy.ToString();

        }

        private void OnClickBouton1KGCottonCandy2(object sender, RoutedEventArgs e)
        {
            stock.cottoncandy = stock.cottoncandy + 1;
            LQCottonCandy4.Content = stock.cottoncandy.ToString();

        }

        private void OnClickManuelCottonCandy(object sender, RoutedEventArgs e)
        {
            string ajout = AjoutManuel.Text;
            if (ajout.Equals(""))
            {
                MessageBox.Show("zone de saisie vide");
            }
            else
            {
                double ajouter = Convert.ToDouble(ajout);
                stock.cottoncandy = stock.cottoncandy + ajouter;
                LQCottonCandy4.Content = stock.cottoncandy;
            }
        }

        private void OnClickBouton100GCreamEgg2(object sender, RoutedEventArgs e)
        {
            stock.creamegg = stock.creamegg + 0.1;
            LQCreamEgg4.Content = stock.creamegg.ToString();
        }

        private void OnClickBouton1KGCreamEgg2(object sender, RoutedEventArgs e)
        {
            stock.creamegg = stock.creamegg + 1;
            LQCreamEgg4.Content = stock.creamegg.ToString();
        }

        private void OnClickManuelCreamEgg(object sender, RoutedEventArgs e)
        {
            string ajout = AjoutManuel.Text;
            if (ajout.Equals(""))
            {
                MessageBox.Show("zone de saisie vide");
            }
            else
            {
                double ajouter = Convert.ToDouble(ajout);
                stock.creamegg = stock.creamegg + ajouter;
                LQCreamEgg4.Content = stock.creamegg;
            }
        }

        private void OnClickBouton100GJawbreaker2(object sender, RoutedEventArgs e)
        {
            stock.jawbreaker = stock.jawbreaker + 0.1;
            LQJawbreaker4.Content = stock.jawbreaker.ToString();
        }

        private void OnClickBouton1KGJawbreaker2(object sender, RoutedEventArgs e)
        {
            stock.jawbreaker = stock.jawbreaker + 1;
            LQJawbreaker4.Content = stock.jawbreaker.ToString();
        }

        private void OnClickManuelJawBreaker(object sender, RoutedEventArgs e)
        {
            string ajout = AjoutManuel.Text;
            if (ajout.Equals(""))
            {
                MessageBox.Show("zone de saisie vide");
            }
            else
            {
                double ajouter = Convert.ToDouble(ajout);
                stock.jawbreaker = stock.jawbreaker + ajouter;
                LQJawbreaker4.Content = stock.jawbreaker;
            }
        }

        private void OnClickBouton100GRedvineLicornes2(object sender, RoutedEventArgs e)
        {
            stock.redvinelicornes = stock.redvinelicornes + 0.1;
            LQRedvineLicornes4.Content = stock.redvinelicornes.ToString();
        }

        private void OnClickBouton1KGRedvineLicornes2(object sender, RoutedEventArgs e)
        {
            stock.redvinelicornes = stock.redvinelicornes + 1;
            LQRedvineLicornes4.Content = stock.redvinelicornes.ToString();
        }

        private void OnClickManuelRedvineLicornes(object sender, RoutedEventArgs e)
        {
            string ajout = AjoutManuel.Text;
            if (ajout.Equals(""))
            {
                MessageBox.Show("zone de saisie vide");
            }
            else
            {
                double ajouter = Convert.ToDouble(ajout);
                stock.redvinelicornes = stock.redvinelicornes + ajouter;
                LQRedvineLicornes4.Content = stock.redvinelicornes;
            }
        }

        private void OnClickBouton100GSugarDaddy2(object sender, RoutedEventArgs e)
        {
            stock.sugardaddy = stock.sugardaddy + 0.1;
            LQSugarDaddy4.Content = stock.sugardaddy.ToString();
        }

        private void OnClickBouton1KGSugarDaddy2(object sender, RoutedEventArgs e)
        {
            stock.sugardaddy = stock.sugardaddy + 1;
            LQSugarDaddy4.Content = stock.sugardaddy.ToString();
        }

        private void OnClickManuelSugarDaddy(object sender, RoutedEventArgs e)
        {
            string ajout = AjoutManuel.Text;
            if (ajout.Equals(""))
            {
                MessageBox.Show("zone de saisie vide");
            }
            else
            {
                double ajouter = Convert.ToDouble(ajout);
                stock.sugardaddy = stock.sugardaddy + ajouter;
                LQSugarDaddy4.Content = stock.sugardaddy;
            }
        }

        private void OnClickBoutonMAJ(object sender, RoutedEventArgs e)
        { 
            //double Skittles_d, double cottoncandy_d, double creamegg_d, double jawbreaker_d, double redvinelicornes_d, double sugardaddy_d
            //service1.setStock(stock.Skittles, stock.cottoncandy, stock.creamegg, stock.jawbreaker, stock.redvinelicornes, stock.sugardaddy);
        }

        private void TBNom_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }




    }
}
