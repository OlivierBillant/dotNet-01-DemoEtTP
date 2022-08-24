using DemoSansMain.Generique.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSansMain.Generique
{
    internal static class Zoo
    {
        public static bool Nourrir<TAnimal, TNourriture>(TAnimal animal, TNourriture nourriture)
            where TNourriture : INourriture
            where TAnimal : IAnimal<TNourriture>
        {
            return animal.SeNourrir(nourriture);
        }
    }
}
