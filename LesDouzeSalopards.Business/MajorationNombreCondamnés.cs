using LesDouzeSalopards.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDouzeSalopards.Business
{
    public class MajorationNombreCondamnés : IRègle
    {
        public IRègle RèglePrécédente {get; set; }
        private List<Condamné> _listeCondamnés;

        public MajorationNombreCondamnés(List<Condamné> listeCondamné, IRègle règlePrécédente)
        {
            RèglePrécédente = règlePrécédente;
            _listeCondamnés = listeCondamné;
        }

        public Prime CalculePrime(Prime prime)
        {
            var regleMajorationTousVivants = GetPreviousRegle<MajorationAucunVivant>();
            if (regleMajorationTousVivants != null && regleMajorationTousVivants.IsSatisfied())
            {
                return prime;
            }

            TrancheCollection tranchescCollection = new TrancheCollection(Constants.TrancheDeMajoration);
            var tranche = tranchescCollection.RetournerLaTranche(_listeCondamnés.Count());
            prime.Montant = prime.Montant * tranche / 100;

            return prime;
        }
        
        private TResult GetPreviousRegle<TResult>() where TResult : IRègle
        {
            IRègle regleCourante =  (IRègle) this;
            while(regleCourante != null && regleCourante.GetType() != typeof(TResult))
            {
                regleCourante = (TResult) regleCourante.RèglePrécédente;
            }
            return (TResult) regleCourante;
        }

    }
}
