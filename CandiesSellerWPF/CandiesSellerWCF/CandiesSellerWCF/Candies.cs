using CandiesSellerWCF.Business;
using System;
using System.Collections.Generic;
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

        public stockBusiness getStock()
        {
            
            return monControlleur.getStock();
        }

        public bool setStock(int Skittles_d, int cottoncandy_d, int creamegg_d, int jawbreaker_d, int redvinelicornes_d, int sugardaddy_d, int Skittles_cost_d, int cottoncandy_cost_d, int creamegg_cost_d, int jawbreaker_cost_d, int redvinelicornes_cost_d, int sugardaddy_cost_d)
        {
            stockBusiness leStock2 = new stockBusiness()
            {
                Skittles = Skittles_d,
                cottoncandy = cottoncandy_d,
                creamegg = creamegg_d,
                jawbreaker = jawbreaker_d,
                redvinelicornes = redvinelicornes_d,
                sugardaddy = sugardaddy_d,
                Skittles_cost = Skittles_cost_d,
                cottoncandy_cost = creamegg_cost_d,
                creamegg_cost = creamegg_cost_d,
                jawbreaker_cost = jawbreaker_cost_d,
                redvinelicornes_cost = redvinelicornes_cost_d,
                sugardaddy_cost = sugardaddy_cost_d
            };

            return monControlleur.setStock(leStock2);
        }

        
    }
}
