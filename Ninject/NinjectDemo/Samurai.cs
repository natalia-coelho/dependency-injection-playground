using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDemo
{
    class Samurai
    {
        readonly IArma arma;

        public Samurai(IArma arma)
        {
            this.arma = arma;
        }

        public void Atacar(string alvo)
        {
            this.arma.Golpear(alvo);
        }
    }
}
