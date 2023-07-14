using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDemo
{
    class Espada : IArma
    {
        public void Golpear(string alvo)
        {
            Console.WriteLine($"{alvo} cortado ao meio! ⚔️");
        }
    }
}
