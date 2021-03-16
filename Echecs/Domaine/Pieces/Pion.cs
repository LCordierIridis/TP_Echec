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
                // Promotion
                if ((joueur.couleur == CouleurCamp.Blanche && destination.Rangee == 0) ||
                    (joueur.couleur == CouleurCamp.Noire && destination.Rangee == 7))
                {
                    Dame dame = new Dame(joueur);
                    dame.position = destination;
                    destination.Link(dame);
                    position.Unlink();

                    joueur.pieces.Remove(this);
                    joueur.pieces.Add(dame);

                    enPassant = false;
                    return true;
                }

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

            Case[] cases = joueur.partie.echiquier.Cases;
            int indexDestination = destination.Rangee * 8 + destination.Colonne;

            bool belowDestinationOccupied = cases[indexDestination + 8 * colorMultiplier].piece != null;
            bool enPassantPossible = false;
            bool targetIsDifferentColor = false;

            Case cibleEnPassant = cases[indexDestination + 8 * colorMultiplier];
            if (destinationOccupied) { targetIsDifferentColor = destination.piece.joueur.couleur != joueur.couleur; }

            if (cibleEnPassant.piece != null) {
                if (cibleEnPassant.piece.info.type == TypePiece.Pion)
                {
                    enPassantPossible = ((Pion)cibleEnPassant.piece).enPassant && !destinationOccupied;
                    if (enPassantPossible)
                    {
                        targetIsDifferentColor = cibleEnPassant.piece.joueur.couleur != joueur.couleur;
                    }
                }
            }

            // Capture
            // Si la destination est occupée
            // Ou si la case en dessous de la destination est occupée par un pion vulnérable au en passant
            if ((destinationOccupied || (belowDestinationOccupied && enPassantPossible)) &&
                targetIsDifferentColor && // Et si la piece visée est de couleur opposée
                horizontal_distance == 1 * colorMultiplier && Math.Abs(vertical_distance) == 1) // Et que le mouvement d'attaque est conforme
            {
                if (enPassantPossible)
                {
                    joueur.partie.vue.ActualiserCase(cibleEnPassant.piece.position.Colonne, cibleEnPassant.piece.position.Rangee, null);
                    cases[indexDestination + 8 * colorMultiplier].Unlink();
                }

                destination.Link(this);
                this.position = destination;
                enPassant = false;
                return true;
            }

            return false;
        }
    }
}
