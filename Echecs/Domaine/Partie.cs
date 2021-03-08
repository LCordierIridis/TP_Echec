using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echecs.IHM;

namespace Echecs.Domaine
{
    public class Partie : IJeu
    {
        public List<Coup> coups { get; set; }

        public IEvenements vue
        {
            get { return _vue; }
            set {_vue = value; }
        }

        StatusPartie status
        {
            get { return _status; }
            set
            {
                _status = value;
                vue.ActualiserPartie(_status);
            }
        }


        /* attributs */

        StatusPartie _status = StatusPartie.Reset;


        /* associations */
        
        IEvenements _vue;
        Joueur blancs;
        Joueur noirs;
        public Echiquier echiquier { get; set; }  // TODO : décommentez lorsque vous auriez implementé la classe Echiquier


        /* methodes */

        public void CommencerPartie()
        {
            // creation des joueurs
            blancs = new Joueur(this, CouleurCamp.Blanche);
            noirs = new Joueur(this, CouleurCamp.Noire);

            // creation de l'echiquier
            echiquier = new Echiquier(this);

            // placement des pieces
            blancs.PlacerPieces(echiquier);
            noirs.PlacerPieces(echiquier);

            // initialisation de l'état
            status = StatusPartie.TraitBlancs;         
        }

        public void DeplacerPiece(int x_depart, int y_depart, int x_arrivee, int y_arrivee)
        {
            /* TEST */
            //vue.ActualiserCase(x_depart,  y_depart,  null);
            //vue.ActualiserCase(x_arrivee, y_arrivee, InfoPiece.RoiBlanc);
            /* FIN TEST */

            // case de départ
            Case depart = echiquier.Cases[y_depart * 8 + x_depart];

            // case d'arrivée
            Case destination = echiquier.Cases[y_arrivee * 8 + x_arrivee];

            // deplacer
            bool ok = depart.piece.Deplacer(destination);

            // changer d'état
            if (ok)
            {
                vue.ActualiserCase(x_depart, y_depart, null);
                vue.ActualiserCase(x_arrivee, y_arrivee, destination.piece.info);

                ChangerEtat();
            }
        }

        void ChangerEtat(bool echec = false, bool mat = false)
        {
            if (status == StatusPartie.TraitBlancs)
            {
                status = StatusPartie.TraitNoirs;
            }
            else
            {
                status = StatusPartie.TraitBlancs;
            }

        }
    }
}
