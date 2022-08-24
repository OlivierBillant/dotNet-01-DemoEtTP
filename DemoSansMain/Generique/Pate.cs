using DemoSansMain.Generique.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSansMain.Generique
{
    internal class Pate : INourriture
    {
        public DateTime DatePeremption { get; set; }

        public bool EstPerime() 
            => DatePeremption < DateTime.Now;
    }
}
