using CandiesSellerWCF.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CandiesSellerWCF
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICandies
    {
        [OperationContract]
        stockBusiness getStock();

        [OperationContract]
        bool setStock(int Skittles_d, int cottoncandy_d, int creamegg_d, int jawbreaker_d, int redvinelicornes_d, int sugardaddy_d, int Skittles_cost_d, int cottoncandy_cost_d, int creamegg_cost_d, int jawbreaker_cost_d, int redvinelicornes_cost_d, int sugardaddy_cost_d);
        
    }
}
