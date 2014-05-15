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
                Skittles_cost = leStock.Skittles_cost,
                cottoncandy_cost = leStock.cottoncandy_cost,
                creamegg_cost = leStock.creamegg_cost,
                jawbreaker_cost = leStock.jawbreaker_cost,
                redvinelicornes_cost = leStock.redvinelicornes_cost,
                sugardaddy_cost = leStock.sugardaddy_cost
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
               Skittles_cost = leStock.Skittles_cost,
               cottoncandy_cost = leStock.cottoncandy_cost,
               creamegg_cost = leStock.creamegg_cost,
               jawbreaker_cost = leStock.jawbreaker_cost,
               redvinelicornes_cost = leStock.redvinelicornes_cost,
               sugardaddy_cost = leStock.sugardaddy_cost
             };

            return stockS;
        }
    }
}
