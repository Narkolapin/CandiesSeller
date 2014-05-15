using CandiesSellerWCF.Business;
using CandiesSellerWCF.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CandiesSellerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Candies : ICandies
    {
        private controlleurBusiness monControlleur; 

        public Candies()
        {
            monControlleur = new controlleurBusiness();
        }



        /**********
         * Stock
         * *******/


        /// <summary>
        /// Fonction pour renvoyer toutes les informations de la Table Stock
        /// </summary>
        /// <returns>toute les valeures des champs de la table Stock</returns>
        public stockBusiness getStock()
        {
            
            return monControlleur.getStock();
        }


        /// <summary>
        /// Fonction pour modifier les valeurs des champs de la table Stock
        /// </summary>
        /// <param name="Skittles_d">Type int nbr de Skittles</param>
        /// <param name="cottoncandy_d">Type int nbr de cottoncandy</param>
        /// <param name="creamegg_d">Type int nbr de creamegg</param>
        /// <param name="jawbreaker_d">Type int nbr de jawbreaker</param>
        /// <param name="redvinelicornes_d">Type int nbr de redvinelicornes</param>
        /// <param name="sugardaddy_d">Type int nbr de sugardaddy</param>
        public bool setStock(int Skittles_d, int cottoncandy_d, int creamegg_d, int jawbreaker_d, int redvinelicornes_d, int sugardaddy_d)
        {
            stockBusiness leStock2 = new stockBusiness()
            {
                Skittles = Skittles_d,
                cottoncandy = cottoncandy_d,
                creamegg = creamegg_d,
                jawbreaker = jawbreaker_d,
                redvinelicornes = redvinelicornes_d,
                sugardaddy = sugardaddy_d,
            };

            return monControlleur.setStock(leStock2);
        }


        /**********
         * Price
         * *******/



        public priceBusiness getPrice()
        {
            return monControlleur.getPrice();
        }

        public bool setPrice(int Skittles_cost_d, int cottoncandy_cost_d, int creamegg_cost_d, int jawbreaker_cost_d, int redvinelicornes_cost_d, int sugardaddy_cost_d)
        {
            priceBusiness lePrice = new priceBusiness() {
                Skittle_price = Skittles_cost_d,
                cottoncandy_price = creamegg_cost_d,
                creamegg_price = creamegg_cost_d,
                jawbreaker_price = jawbreaker_cost_d,
                redvinelicornes_price = redvinelicornes_cost_d,
                sugardaddy_price = sugardaddy_cost_d
            };
            
            return monControlleur.setPrice(lePrice);
        }


        public bool setOrder(userBusiness unUser, orderBusiness uneOrder)
        {
            return monControlleur.setOrder(unUser, uneOrder);
        }
    }
}
