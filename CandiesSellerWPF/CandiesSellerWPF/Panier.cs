using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandiesSellerWPF
{
    public class Panier
    {
        private double _QSkittles = 0;

        public double PricePanier = 0;

        public double QSkittles
        {
            get { return _QSkittles; }
            set { _QSkittles = value; }
        }
        private double _QCottonCandy = 0;

        public double QCottonCandy
        {
            get { return _QCottonCandy; }
            set { _QCottonCandy = value; }
        }
        private double _QCreamEgg = 0;

        public double QCreamEgg
        {
            get { return _QCreamEgg; }
            set { _QCreamEgg = value; }
        }
        private double _QJawbreaker = 0;

        public double QJawbreaker
        {
            get { return _QJawbreaker; }
            set { _QJawbreaker = value; }
        }
        private double _QRedvinesLicornes = 0;

        public double QRedvinesLicornes
        {
            get { return _QRedvinesLicornes; }
            set { _QRedvinesLicornes = value; }
        }
        private double _QSugarDaddy = 0;

        public double QSugarDaddy
        {
            get { return _QSugarDaddy; }
            set { _QSugarDaddy = value; }
        }

    }
}
