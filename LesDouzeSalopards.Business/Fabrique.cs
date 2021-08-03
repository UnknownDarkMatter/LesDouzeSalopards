using LesDouzeSalopards.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDouzeSalopards.Business
{
    public class Fabrique
    {
        public List<IRègle> FabriqueRegles(List<Condamné> listeCondamnés)
        {
            var regleRealisationContrat = new RègleRéalisationContrat(listeCondamnés, null);
            var regleMajorationAucunVivant = new MajorationAucunVivant(listeCondamnés, regleRealisationContrat);
            var regleMajorationNombreCondamné = new MajorationNombreCondamnés(listeCondamnés, regleMajorationAucunVivant);
            var regleMajorationBudgetMax = new MajorationBudgetMax();

            List<IRègle> listeRègles = new List<IRègle>();
            listeRègles.Add(regleRealisationContrat);
            listeRègles.Add(regleMajorationAucunVivant);
            listeRègles.Add(regleMajorationNombreCondamné);
            listeRègles.Add(regleMajorationBudgetMax);

            return listeRègles;
        }
    }
}
