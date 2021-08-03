using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LesDouzeSalopards.Entities;

namespace LesDouzeSalopards.Business
{
    public class MajorationAucunVivant: IRègle
    {
        public IRègle RèglePrécédente { get; set; }
        private List<Condamné> _listeCondamnés;

        public MajorationAucunVivant(List<Condamné> listeCondamné, IRègle règlePrécédente)
        {
            RèglePrécédente = règlePrécédente;
            _listeCondamnés = listeCondamné;
        }

        public Prime CalculePrime(Prime prime)
        {
            if (IsSatisfied())
            {
                prime.Montant = prime.Montant * (100 + Constants.PourcentageAucunVivant) / 100; 
            }
            return prime;
        }

        public bool IsSatisfied()
        {
            bool auMoinsUnVivant = _listeCondamnés.Any(m => m.EtatCondamné == EtatCondamné.Vivant);
            return !auMoinsUnVivant;

        }

    }
}
