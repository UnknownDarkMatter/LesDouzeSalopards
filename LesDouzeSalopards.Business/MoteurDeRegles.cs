using LesDouzeSalopards.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDouzeSalopards.Business
{
    public class MoteurDeRegles
    {

        public Prime CalculePrimeFinale(List<Condamné> listeCondamnés)
        {
            var fabrique = new Fabrique();
            var listeRègles = fabrique.FabriqueRegles(listeCondamnés);

            Prime prime = new Prime();
            foreach(var règle in listeRègles)
            {
                prime = règle.CalculePrime(prime);
            }
            return prime;
        }
    }
}
