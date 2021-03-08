using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echecs.IHM;

namespace Echecs.Domaine
{
    abstract public class Piece
    {
        // attributs
        public InfoPiece info;

        // associations
        public Joueur joueur { get; }
        public Case position { get; set; }

        // methodes
        public Piece(Joueur joueur, TypePiece type)
        {
			this.joueur = joueur;
            info = InfoPiece.GetInfo(joueur.couleur, type);
        }

        public abstract bool Deplacer(Case destination);

        public bool pieceSurLeChemin(Case destination)
        {
            // Positive is up, Negative is down
            int horizontal_distance = this.position.Rangee - destination.Rangee;
            // Positive is left, Negative is right
            int vertical_distance = this.position.Colonne - destination.Colonne;

            Case[] cases = joueur.partie.echiquier.Cases;

            int direction_hor = 0;
            if (horizontal_distance != 0)
                direction_hor = horizontal_distance / Math.Abs(horizontal_distance) * -1;


            int direction_ver = 0;
            if (vertical_distance != 0)
                direction_ver = vertical_distance / Math.Abs(vertical_distance) * -1;

            int newDestinationIndex = (position.Rangee + direction_hor) * 8 + position.Colonne + direction_ver;

            //Console.WriteLine("Départ : " + position.Rangee + ":" + position.Colonne + ", arrivee : " + (position.Rangee + direction_hor) + ":" + (position.Colonne + direction_ver));

            //Console.WriteLine("Destination : " + destination + ", direction hor : " + direction_hor + ", direction ver : " + direction_ver + ", new destination : " + newDestinationIndex);

            Case positionEvaluee = cases[newDestinationIndex];

            while (positionEvaluee != destination)
            {
                if (positionEvaluee.piece != null) return true;

                positionEvaluee = cases[(positionEvaluee.Rangee + direction_hor) * 8 + positionEvaluee.Colonne + direction_ver];
            }

            return false;
        }
    }
}
