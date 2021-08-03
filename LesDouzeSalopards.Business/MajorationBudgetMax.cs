using LesDouzeSalopards.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDouzeSalopards.Business
{
    public class MajorationBudgetMax : IRègle
    {
        public IRègle RèglePrécédente { get; set ; }

        public Prime CalculePrime(Prime prime)
        {
          if(prime.Montant > Constants.BudgetMax)
            {
                prime.Montant = Constants.BudgetMax;
            }
            return prime;
        }
    }
}
