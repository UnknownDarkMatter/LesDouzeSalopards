using LesDouzeSalopards.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDouzeSalopards.Business
{
    public class RègleRéalisationContrat: IRègle
    {
        public IRègle RèglePrécédente { get; set; }
        private List<Condamné> _listeCondamnés;
        public RègleRéalisationContrat(List<Condamné> listeCondamné, IRègle règlePrécédente)
        {
            RèglePrécédente = règlePrécédente;

            _listeCondamnés = listeCondamné;
        }
        public Prime CalculePrime(Prime prime)
        {
            foreach (var condamné in _listeCondamnés)
            {
                prime.Montant += CalculeMontantContratRéalisé(condamné).Montant;
            }
            return prime;
        }

        private Prime CalculeMontantContratRéalisé(Condamné newCondamné)
        {
            switch (newCondamné.EtatCondamné)
            {
                case EtatCondamné.Vivant:
                    {
                        return new Prime() { Montant = Constants.ValeurCondamnéVivant };
                    }
                case EtatCondamné.Mort:
                    {
                        return new Prime() { Montant = Constants.ValeurCondamnéMort};
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(newCondamné.EtatCondamné));

                    }
            }
        }


    }
}
