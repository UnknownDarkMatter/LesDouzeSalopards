using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDouzeSalopards.Entities
{
    public enum EtatCondamné
    {
        /// <summary>
        /// L'etat du condamné est inconnu !
        /// </summary>
        NonDefini = 0,
        /// <summary>
        /// Le condamné est vivant
        /// </summary>
        Vivant = 1, 
        /// <summary>
        /// Le condamné est mort
        /// </summary>
        Mort = 2
    }
}
