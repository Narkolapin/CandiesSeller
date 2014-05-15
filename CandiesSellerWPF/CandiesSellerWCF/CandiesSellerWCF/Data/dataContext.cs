using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesSellerWCF.Data
{
    public class dataContext
    {

        private CandiesSellerEntities monEntity {get; set;}

        public dataContext()
        {
            monEntity = new CandiesSellerEntities();
        }

        public stock getStock()
        {
            stock stockactuelle = new stock();
            return stockactuelle =  monEntity.stock.SingleOrDefault(c => c.Id == 1);
        }

        public bool setStock(stock leStock)
        {

            stock test = new stock();

            monEntity.stock.SingleOrDefault(c => c.Id == 1) = leStock;
           
            if (monEntity.stock.SingleOrDefault(c => c.Id == 1) != null)
            {
                monEntity.stock.SingleOrDefault(c => c.Id == 1).cottoncandy = leStock.cottoncandy;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).cottoncandy_cost = leStock.cottoncandy_cost;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).sugardaddy = leStock.sugardaddy;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).sugardaddy_cost = leStock.sugardaddy_cost;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).Skittles = leStock.Skittles;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).Skittles_cost = leStock.Skittles_cost;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).creamegg = leStock.creamegg;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).creamegg_cost = leStock.creamegg_cost;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).jawbreaker = leStock.jawbreaker;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).jawbreaker_cost = leStock.jawbreaker_cost;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).redvinelicornes = leStock.redvinelicornes;
                monEntity.stock.SingleOrDefault(c => c.Id == 1).redvinelicornes_cost = leStock.redvinelicornes_cost;

                monEntity.SaveChanges();

                return true;
            }

            else
                return false;

        }
    }
}
