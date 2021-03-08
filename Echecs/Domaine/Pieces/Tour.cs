using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echecs.IHM;

namespace Echecs.Domaine
{
    public class Tour : Piece
    {
        public Tour(Joueur joueur) : base(joueur, TypePiece.Tour) { }

        public override bool Deplacer(Case destination)
        {
            // Positive is up, Negative is down
            int horizontal_distance = this.position.Rangee - destination.Rangee;
            // Positive is left, Negative is right
            int vertical_distance = this.position.Colonne - destination.Colonne;

            bool destinationOccupiedBySameColor = false;

            if (destination.piece != null)
                destinationOccupiedBySameColor = destination.piece.joueur.couleur == joueur.couleur;

            bool movingInOnlyOneDirection = horizontal_distance * vertical_distance == 0;

            if(movingInOnlyOneDirection && destination != position && !destinationOccupiedBySameColor && !pieceSurLeChemin(destination))
            {
                destination.Link(this);
                this.position = destination;
                return true;
            }

            return false;
        }
    }
}
