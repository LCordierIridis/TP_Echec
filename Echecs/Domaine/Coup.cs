using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echecs.Domaine
{
    public class Coup
    {
        public Piece piece { get; private set; }
        public Case caseDepart { get; private set; }
        public Case caseArrivee { get; private set; }

        public Coup(Piece p, Case cd, Case ca)
        {
            piece = p;
            caseDepart = cd;
            caseArrivee = ca;
        }
    }
}
