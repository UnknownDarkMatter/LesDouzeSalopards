using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDouzeSalopards.Business
{
    public class Constants
    {
        public const decimal ValeurCondamnéVivant = 500;
        public const decimal ValeurCondamnéMort = 300;
        public const decimal PourcentageAucunVivant = -30;
        public const decimal BudgetMax = 700;

        public static Dictionary<int, decimal> TrancheDeMajoration = new Dictionary<int, decimal>()
        {
            { 2, 90 },
            { 3, 80 },
            { 4, 70 },
            { 5, 60 },
        };

    }
}
