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
        public int Skittles { get; set; }
        public int cottoncandy { get; set; }
        public int creamegg { get; set; }
        public int jawbreaker { get; set; }
        public int redvinelicornes { get; set; }
        public int sugardaddy { get; set; }
        public int id_user { get; set; }
    
        public virtual user user { get; set; }
    }
}
