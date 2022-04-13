using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Animal
    {
        virtual public void Dormir()
        {
            Console.WriteLine("L'animal dort comme une Animal");
        }

        virtual public void Manger()
        {
            Console.WriteLine("L'animal Mange");
        }
    }
}
