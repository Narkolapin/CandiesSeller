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
    }
}
