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
        public stockBusiness getStock()
        {
            controlleurBusiness monControlleur = new controlleurBusiness();
            return monControlleur.getStock();
        }
    }
}
