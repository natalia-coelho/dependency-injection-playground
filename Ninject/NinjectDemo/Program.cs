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
            var warrior = new Samurai();
            warrior.Attack("the evildoers");
        }
    }
}
