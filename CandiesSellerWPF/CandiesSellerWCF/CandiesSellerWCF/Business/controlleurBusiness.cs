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

        public stockBusiness getStock()
        {
            dataContext monData = new dataContext();

            if (monData.getStock() != null)
                return convertBusiness.toStockBusiness(monData.getStock());
            else
                return null;
        }
    }
}
