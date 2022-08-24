using DemoSansMain.Generique.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSansMain.Generique
{
    internal class Fourmi : IAnimal<Fruit>
    {
        public bool SeNourrir(Fruit aliment)
        {
            if (aliment.EstPerime())
                return false;

            Console.WriteLine("La fourmi mange un fruit");
            return true;
        }
    }
}
