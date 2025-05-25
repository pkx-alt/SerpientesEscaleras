using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesEscaleras
{
    public class Dado
    {
        public int Tirar()
        {
            Random random = new Random();
            int aleatorio = random.Next(1, 7);

            return aleatorio;
        }

    }
}
