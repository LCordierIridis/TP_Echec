using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echecs.IHM;

namespace Echecs.Domaine
{
    public class Dame : Piece
    {
        public Dame(Joueur joueur) : base(joueur, TypePiece.Dame) { }

        public override bool Deplacer(Case destination)
        {
            // Positive is up, Negative is down
            int horizontal_distance = this.position.Rangee - destination.Rangee;
            // Positive is left, Negative is right
            int vertical_distance = this.position.Colonne - destination.Colonne;

            bool destinationOccupiedBySameColor = false;

            if (destination.piece != null)
                destinationOccupiedBySameColor = destination.piece.joueur.couleur == joueur.couleur;

            bool movingInDiagonal = Math.Abs(horizontal_distance) == Math.Abs(vertical_distance);
            bool movingInOnlyOneDirection = horizontal_distance * vertical_distance == 0;

            Console.WriteLine("Diag : " + movingInDiagonal.ToString() + ", same tile : " + (destination != position) + ", sameColor : " + destinationOccupiedBySameColor);

            if ((movingInDiagonal || movingInOnlyOneDirection) && destination != position && !destinationOccupiedBySameColor && !pieceSurLeChemin(destination))
            {
                destination.Link(this);
                this.position = destination;
                return true;
            }

            return false;
        }
    }
}
