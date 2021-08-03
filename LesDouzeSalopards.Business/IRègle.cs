using LesDouzeSalopards.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDouzeSalopards.Business
{
    public interface IRègle
    {
        IRègle RèglePrécédente { get; set; }
        Prime CalculePrime(Prime prime);
    }
}
