//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CandiesSellerWCF.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int Id { get; set; }
        public double Skittles { get; set; }
        public double cottoncandy { get; set; }
        public double creamegg { get; set; }
        public double jawbreaker { get; set; }
        public double redvinelicornes { get; set; }
        public double sugardaddy { get; set; }
        public int id_user { get; set; }
    
        public virtual user user { get; set; }
    }
}
