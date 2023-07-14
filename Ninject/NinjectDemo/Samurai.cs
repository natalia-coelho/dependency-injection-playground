using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDemo
{
    class Samurai
    {
        readonly Sword sword;

        public Samurai()
        {
            this.sword = new Sword();
        }

        public void Attack(string target)
        {
            this.sword.Hit(target);
        }
    }
}
