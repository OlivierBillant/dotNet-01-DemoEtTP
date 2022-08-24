using DemoSansMain.Generique.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSansMain.Generique
{
    internal class Chat : IAnimal<Pate>
    {
        public bool SeNourrir(Pate aliment)
        {
            if (aliment.EstPerime())
                return false;

            Console.WriteLine("Le chat mange le delicieux paté");
            return true;
        }
    }
}
