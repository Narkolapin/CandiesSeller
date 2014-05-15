using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesSellerWCF.Data
{
    public class dataContext
    {

        private CandiesSellerEntities monEntity { get; set; }


        public dataContext()
        {
            monEntity = new CandiesSellerEntities();
        }


        /*********************
         * Stock
         * ********************/


        /// <summary>
        /// Fonction pour renvoyer toutes les informations de la Table Stock
        /// </summary>
        /// <returns>toute les valeures des champs de la table Stock</returns>
        public stock getStock()
        {
            stock stockactuelle = new stock();
            return stockactuelle = monEntity.stock.SingleOrDefault(c => c.Id == 1);
        }

        /// <summary>
        /// Fonction pour modifier les valeurs des champs de la table Stock
        /// </summary>
        /// <param name="leStock">Classe de type Stock chargé avec les données du WPF</param>
        /// <returns>True si l'opération c'est bien déroulé, False sinon</returns>
        public bool setStock(stock leStock)
        {

            if (monEntity.stock.SingleOrDefault(c => c.Id == 1) != null)
            {
                monEntity.stock.SingleOrDefault(c => c.Id == 1).cottoncandy = leStock.cottoncandy;

                monEntity.stock.SingleOrDefault(c => c.Id == 1).sugardaddy = leStock.sugardaddy;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).Skittles = leStock.Skittles;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).creamegg = leStock.creamegg;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).jawbreaker = leStock.jawbreaker;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).redvinelicornes = leStock.redvinelicornes;

                monEntity.SaveChanges();

                return true;
            }

            else
                return false;

        }



        /*********************
         * Price
         * ********************/


        public Price getPrice()
        {
            Price actualprice = new Price();
            return actualprice = monEntity.Price.SingleOrDefault(c => c.Id == 1);
        }



        public bool setPrice(Price lePrice)
        {

            if (monEntity.Price.SingleOrDefault(c => c.Id == 1) != null)
            {
                monEntity.Price.SingleOrDefault(c => c.Id == 1).jawbreaker_cost = lePrice.jawbreaker_cost;
                monEntity.Price.SingleOrDefault(c => c.Id == 1).redvinelicornes_cost = lePrice.redvinelicornes_cost;
                monEntity.Price.SingleOrDefault(c => c.Id == 1).Skittles_cost = lePrice.Skittles_cost;
                monEntity.Price.SingleOrDefault(c => c.Id == 1).sugardaddy_cost = lePrice.sugardaddy_cost;
                monEntity.Price.SingleOrDefault(c => c.Id == 1).cottoncandy_cost = lePrice.cottoncandy_cost;
                monEntity.Price.SingleOrDefault(c => c.Id == 1).creamegg_cost = lePrice.creamegg_cost;

                monEntity.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }       
}
