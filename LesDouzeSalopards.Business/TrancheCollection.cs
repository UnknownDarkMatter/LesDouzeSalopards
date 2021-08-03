using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDouzeSalopards.Business
{
    public class TrancheCollection
    {
        private Dictionary<int, decimal> _tranches;
        public TrancheCollection(Dictionary<int, decimal> tranches)
        {
            _tranches = tranches;
        }
        public decimal RetournerLaTranche(int nombreDeCondamné)
        {
            
            if (_tranches.Keys.Contains(nombreDeCondamné))
                {
                return _tranches[nombreDeCondamné];
            }
            if(nombreDeCondamné > _tranches.Keys.Max())
            {
                return _tranches[_tranches.Keys.Max()];
            }
            return 100;

        }
    }
}
