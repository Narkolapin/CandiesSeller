using CandiesSellerWCF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesSellerWCF.Business
{
    public class controlleurBusiness
    {
        private dataContext monData { get; set; }

        public controlleurBusiness()
        {
            monData = new dataContext();
        }


        /*********************
         * Price
         * ********************/


        public stockBusiness getStock()
        {
            if (monData.getStock() != null)
                return convertBusiness.toStockBusiness(monData.getStock());
            else
                return null;
        }

        public bool setStock(stockBusiness leStock)
        {

           return monData.setStock(convertBusiness.toStock(leStock));

        }



        /*********************
         * Stock
         * ********************/


        public priceBusiness getPrice()
        {
            if (monData.getPrice() != null)
                return convertBusiness.toPriceBusiness(monData.getPrice());
            else
                return null;
        }


        public bool setPrice(priceBusiness unPrice)
        {
            return monData.setPrice(convertBusiness.toPrice(unPrice));
        }



        public bool setOrder(userBusiness unUser, Panier uneOrder)
        {
            return monData.setOrder(convertBusiness.toUser(unUser), convertBusiness.toOrder(uneOrder));
        }

        public bool Connexion(string pseudo, string password)
        {
            return false;
        }
    }
}
