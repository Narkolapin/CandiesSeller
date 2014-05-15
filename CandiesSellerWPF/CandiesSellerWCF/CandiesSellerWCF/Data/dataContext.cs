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
    }
}
