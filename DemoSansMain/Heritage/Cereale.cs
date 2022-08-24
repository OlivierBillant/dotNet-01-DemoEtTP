using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSansMain.Heritage.Abstractions;

namespace DemoSansMain.Heritage
{
    internal class Cereale : Aliment, IEmballage
    {
        public override void Conserver()
        {
            this.RangerDansLePlacard();
        }

        private void RangerDansLePlacard()
        {
            throw new NotImplementedException();
        }

        public void Fermer()
        {
            throw new NotImplementedException();
        }

        public void Ouvrir()
        {
            throw new NotImplementedException();
        }
    }
}
