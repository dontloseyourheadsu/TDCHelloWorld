using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDCHelloWorld
{
    internal interface LivingBeing
    {
        public abstract void Breath();
        public void Live()
        {
            Console.WriteLine("I'm Living");
        }
    }
}
