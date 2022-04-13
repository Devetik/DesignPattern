using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Chat : Animal
    {
        private bool aFaim = true;

        public bool estAffame
        {
            get { return aFaim; }
            //set { aFaim = value; }
        }

        public void Miauler()
        {
            Console.WriteLine("Le chat miaule");
        }

        override public void Manger()
        {
            Console.WriteLine("Le chat mange");
            aFaim = false;
        }

        override public void Dormir()
        {
            Console.WriteLine("Le chat dort comme un chat");
        }
    }
}
