using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echecs.IHM;

namespace Echecs.Domaine
{
    public class Roi : Piece
    {
        public Roi(Joueur joueur) : base(joueur, TypePiece.Roi) { }

        public override bool Deplacer(Case destination)
        {
            // Positive is up, Negative is down
            int horizontal_distance = this.position.Rangee - destination.Rangee;
            // Positive is left, Negative is right
            int vertical_distance = this.position.Colonne - destination.Colonne;

            bool destinationOccupiedBySameColor = false;

            if (destination.piece != null)
                destinationOccupiedBySameColor = destination.piece.joueur.couleur == joueur.couleur;

            bool movedOnlyOneTile = Math.Abs(vertical_distance) * Math.Abs(horizontal_distance) < 2;

            if (movedOnlyOneTile && destination != position && !destinationOccupiedBySameColor)
            {
                // capture
                if (destination.piece != null)
                    joueur.piecesCapturees.Add(destination.piece);

                destination.Link(this);
                this.position = destination;
                return true;
            }

            return false;
        }
    }
}
