using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Chien : Animal
    {
        public void Mordre(Facteur monFacteur)
        {
            Console.WriteLine("Le chien mord le facteur");
        }
    }
}
