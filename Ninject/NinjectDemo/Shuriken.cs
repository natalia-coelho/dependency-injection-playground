using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDemo
{
    public class Shuriken : IArma
    {
        public void Golpear(string alvo)
        {
            Console.WriteLine("{0} Armadura perfuradas!", alvo);
        }
    }
}
