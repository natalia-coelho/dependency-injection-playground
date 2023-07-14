using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var capitão = new Samurai(new Espada());
            var soldado = new Samurai(new Shuriken());

            soldado.Atacar("os inimigos");
            capitão.Atacar("a tropa");
        }
    }
}
