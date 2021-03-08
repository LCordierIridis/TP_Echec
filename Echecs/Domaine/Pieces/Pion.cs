using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echecs.IHM;

namespace Echecs.Domaine
{
    public class Pion : Piece
    {
        public Pion(Joueur joueur) : base(joueur, TypePiece.Pion) { }

        public bool enPassant { get; set; }

        public override bool Deplacer(Case destination)
        {
            // Positive is up, Negative is down
            int horizontal_distance = this.position.Rangee - destination.Rangee;
            // Positive is left, Negative is right
            int vertical_distance = this.position.Colonne - destination.Colonne;

            int starting_row_white = 6;
            int starting_row_black = 1;

            int colorMultiplier = joueur.couleur == CouleurCamp.Blanche ? 1 : -1;

            bool destinationOccupied = destination.piece != null;

            // Déplacement normal
            if (horizontal_distance == 1 * colorMultiplier && vertical_distance == 0 &&
                !destinationOccupied)
            {
                destination.Link(this);
                this.position = destination;
                enPassant = false;
                return true;
            }

            // Déplacemenent sur la position de départ
            if (((joueur.couleur == CouleurCamp.Blanche && position.Rangee == starting_row_white) ||
                (joueur.couleur == CouleurCamp.Noire && position.Rangee == starting_row_black)) &&
                !destinationOccupied && !pieceSurLeChemin(destination))
            {
                if (horizontal_distance == 2 * colorMultiplier && vertical_distance == 0)
                {
                    destination.Link(this);
                    this.position = destination;
                    enPassant = true;
                    return true;
                }
            }

            // Capture
            if(destinationOccupied && destination.piece.joueur.couleur != joueur.couleur &&
                horizontal_distance == 1 * colorMultiplier && Math.Abs(vertical_distance) == 1)
            {
                joueur.piecesCapturees.Add(destination.piece);
                destination.Link(this);
                this.position = destination;
                enPassant = false;
                return true;
            }

            // Prise en passant

            return false;
        }
    }
}
