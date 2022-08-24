using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSansMain.Generique.Abstractions
{
    internal interface IAnimal<TNourriture> where TNourriture : INourriture
    {
        bool SeNourrir(TNourriture aliment);
    }
}
