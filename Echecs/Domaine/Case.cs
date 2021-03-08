using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echecs.IHM;

namespace Echecs.Domaine
{
    public class Case
    {
        // attributs
        public static int WHITE = 1;
        public static int BLACK = 0;
        public int Color { get; set; }
        public int Rangee { get; set; }
        public int Colonne { get; set; }

        // associations
        public Piece piece;

        //public IEvenements vue { get; set; }

        // methodes
        public void Unlink()
        {
            // piece.joueur.partie.vue.ActualiserCase(Colonne, Rangee, null);

            piece = null;
        }
        public void Link(Piece newPiece)
        {
            //Console.WriteLine("Piece : " + newPiece.ToString() + " | Colonne : " + newPiece.position.Colonne + ", Rangee : " + newPiece.position.Rangee);
            // 1. Deconnecter newPiece de l'ancienne case
            if (newPiece.position != null)
                newPiece.position.Unlink();

            // 2. Connecter newPiece à cette case
            piece = newPiece;

            piece.joueur.partie.vue.ActualiserCase(Colonne, Rangee, piece.info);

            List<Piece> liste_pieces = piece.joueur.piecesCapturees;

            List<InfoPiece> infoPieces = liste_pieces.Select(x => x.info).ToList();

            piece.joueur.partie.vue.ActualiserCaptures(infoPieces);
        }
    }
}
