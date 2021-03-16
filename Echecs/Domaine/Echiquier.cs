using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echecs.Domaine
{
    public class Echiquier
    {
        public Case[] Cases { get; private set; }
        Partie partie;

        public Echiquier(Partie partie)
        {
            this.partie = partie;

            Cases = new Case[64];

            for (int i = 0; i < 64; i++)
            {
                Cases[i] = new Case();

                Cases[i].Rangee = i / 8;
                Cases[i].Colonne = i % 8;

                if (i % 2 == 1)
                    Cases[i].Color = Case.WHITE;
                else
                    Cases[i].Color = Case.BLACK;
            }
        }

        public void clearEchiquier() 
        {
            for (int i = 0; i < 64; i++)
            {
                int y = i / 8;
                int x = i % 8;

                partie.vue.ActualiserCase(x, y, null);
            }
        }
    }
}
