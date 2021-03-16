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

        private bool hasMoved = false;

        public override bool Deplacer(Case destination)
        {
            // Positive is up, Negative is down
            int horizontal_distance = this.position.Rangee - destination.Rangee;
            // Positive is left, Negative is right
            int vertical_distance = this.position.Colonne - destination.Colonne;

            bool destinationOccupiedBySameColor = false;

            if (destination.piece != null)
                destinationOccupiedBySameColor = destination.piece.joueur.couleur == joueur.couleur;

            bool movedOnlyOneTile = Math.Abs(vertical_distance) < 2 && Math.Abs(horizontal_distance) < 2;

            if (movedOnlyOneTile && destination != position && !destinationOccupiedBySameColor)
            {
                destination.Link(this);
                this.position = destination;
                hasMoved = true;
                return true;
            }

            if (!hasMoved)
            {
                // droit
                if ((vertical_distance == -2 && horizontal_distance == 0))
                {
                    Tour tower = (Tour)joueur.partie.echiquier.Cases[63].piece;
                    Case towerDestination = joueur.partie.echiquier.Cases[61];

                    bool towerHasMoved = tower.hasMoved;

                    if (!towerHasMoved && !pieceSurLeChemin(tower.position))
                    {
                        towerDestination.Link(tower);
                        tower.position = towerDestination;
                        tower.hasMoved = true;

                        joueur.partie.vue.ActualiserCase(tower.position.Colonne, tower.position.Rangee, null);
                        joueur.partie.vue.ActualiserCase(destination.Colonne + 1, destination.Rangee, tower.info);

                        destination.Link(this);
                        this.position = destination;
                        hasMoved = true;

                        return true;
                    }
                }

                // gauche
                if (vertical_distance == 3 && horizontal_distance == 0)
                {
                    Tour tower = (Tour)joueur.partie.echiquier.Cases[55].piece;
                    bool towerHasMoved = tower.hasMoved;

                    if (!towerHasMoved && !pieceSurLeChemin(tower.position))
                    {
                        joueur.partie.vue.ActualiserCase(tower.position.Colonne, tower.position.Rangee, null);
                        joueur.partie.vue.ActualiserCase(destination.Colonne - 1, destination.Rangee, tower.info);

                        destination.Link(this);
                        this.position = destination;
                        hasMoved = true;

                        return true;
                    }
                }

            }


            Console.WriteLine(position.Rangee);

            return false;
        }
    }
}
