using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSansMain.Heritage
{
    internal abstract class Aliment
    {
        protected Aliment() 
            => this.DatePeremption = DateTime.Now.AddMonths(6);

        public DateTime DatePeremption { get; set; }

        public bool EstPerime 
            => DateTime.Now > this.DatePeremption;

        protected void Jeter() 
            => this.DatePeremption = DateTime.Now;

        public abstract void Conserver();
    }
}
