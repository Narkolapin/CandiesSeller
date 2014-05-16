using CandiesSellerWCF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesSellerWCF.Business
{
    public static class convertBusiness
    {
        /***************************
         * Stock Convert
         * *************************/

        public static stockBusiness toStockBusiness(stock leStock)
        {

            stockBusiness stockB = new stockBusiness()
            {
                cottoncandy = leStock.cottoncandy,
                creamegg = leStock.creamegg,
                jawbreaker = leStock.jawbreaker,
                redvinelicornes = leStock.redvinelicornes,
                Skittles = leStock.Skittles,
                sugardaddy = leStock.sugardaddy,

            };

            return stockB;
        }


        public static stock toStock(stockBusiness leStock)
        {
            stock stockS = new stock()
            {
               cottoncandy = leStock.cottoncandy,
               creamegg = leStock.creamegg,
               jawbreaker = leStock.jawbreaker,
               redvinelicornes = leStock.redvinelicornes,
               Skittles = leStock.Skittles,
               sugardaddy = leStock.sugardaddy,
             };

            return stockS;
        }



        /***************************
         * Price Convert
         * *************************/

        public static priceBusiness toPriceBusiness(Price lePrice)
        {
            priceBusiness lePriceBusiness = new priceBusiness()
            {

                Skittle_price = lePrice.Skittles_cost,
                cottoncandy_price = lePrice.cottoncandy_cost,
                creamegg_price = lePrice.creamegg_cost,
                jawbreaker_price = lePrice.jawbreaker_cost,
                redvinelicornes_price = lePrice.redvinelicornes_cost,
                sugardaddy_price = lePrice.sugardaddy_cost
            };
            return lePriceBusiness;
        }


        public static Price toPrice(priceBusiness lePrice)
        {
            Price lePriceData = new Price()
            {
                Skittles_cost = lePrice.Skittle_price,
                cottoncandy_cost = lePrice.cottoncandy_price,
                creamegg_cost = lePrice.creamegg_price,
                jawbreaker_cost = lePrice.jawbreaker_price,
                redvinelicornes_cost = lePrice.redvinelicornes_price,
                sugardaddy_cost = lePrice.sugardaddy_price
            };

            return lePriceData;
        }


        /***************************
         * Order Convert
         * *************************/


        public static order toOrder(Panier uneOrder)
        {
            order uneOrderData = new order()
            {
                cottoncandy = uneOrder.QCottonCandy,
                creamegg = uneOrder.QCreamEgg,
                jawbreaker = uneOrder.QJawbreaker,
                redvinelicornes = uneOrder.QRedvinesLicornes,
                Skittles = uneOrder.QSkittles,
                sugardaddy = uneOrder.QSugarDaddy
            };

            return uneOrderData;
        }

        public static Panier toOrderBusiness(order uneOrder)
        {
            Panier uneOrderBusiness = new Panier()
            {
                QCottonCandy  = uneOrder.cottoncandy,
                QCreamEgg = uneOrder.creamegg,
                QJawbreaker = uneOrder.jawbreaker,
                QRedvinesLicornes = uneOrder.redvinelicornes,
                QSkittles = uneOrder.Skittles,
                QSugarDaddy = uneOrder.sugardaddy
            };

            return uneOrderBusiness;
        }

        /***************************
         * Price Convert
         * *************************/

        public static user toUser ( userBusiness unUser)
        {
            user userData = new user()
            {
                nom = unUser.nom,
                prenom = unUser.prenom,
                adresse = unUser.adresse
            };

            return userData;
        }

        public static userBusiness toUserBusiness( user unUser)
        {
            userBusiness userBusi = new userBusiness()
            {
                nom = unUser.nom,
                prenom = unUser.prenom,
                adresse = unUser.adresse
            };
             return userBusi;

        }

    }
}
