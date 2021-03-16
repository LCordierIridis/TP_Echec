using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Echecs.IHM;

namespace Echecs.Domaine
{
    public class Joueur
    {
        // attributs
        public CouleurCamp couleur;

        // associations
        public Partie partie { get; }
        public List<Piece> pieces { get; set; }
        public List<Piece> piecesCapturees { get; set; }
        public static int LAST_PIECE = 64;
        public static int NB_MAX_PIECE = 16;
        public static int NB_PIECE_ROW = 8;
        

        // methodes
        public Joueur(Partie partie, CouleurCamp couleur)
        {
            this.couleur = couleur;
            this.partie = partie;

            pieces = new List<Piece>();
            piecesCapturees = new List<Piece>();

            pieces.Add(new Tour(this));
            pieces.Add(new Cavalier(this));
            pieces.Add(new Fou(this));
            pieces.Add(new Dame(this));
            pieces.Add(new Roi(this));
            pieces.Add(new Fou(this));
            pieces.Add(new Cavalier(this));
            pieces.Add(new Tour(this));
            // TODO : creation des pieces du joueur

            for (int i = 0; i < 8; i++) pieces.Add(new Pion(this));
        }

        public void ClearPieces()
        {
            pieces.Clear();
            piecesCapturees.Clear();
        }

        // TODO : décommentez lorsque vous auriez implementé les methode Unlink et Link de la classe Case
        public void PlacerPieces(Echiquier echiquier)
        {
            if (couleur == CouleurCamp.Blanche)
            {
                for (int i = LAST_PIECE - NB_PIECE_ROW; i < LAST_PIECE; i++)
                {
                    int index = i - (LAST_PIECE - NB_PIECE_ROW);

                    pieces[index].position = echiquier.Cases[i];
                    echiquier.Cases[i].Link(pieces[index]);
                }

                for (int i = LAST_PIECE - NB_MAX_PIECE; i < LAST_PIECE - NB_PIECE_ROW; i++)
                {
                    int index = i - (LAST_PIECE - NB_MAX_PIECE);

                    pieces[index + 8].position = echiquier.Cases[i];
                    echiquier.Cases[i].Link(pieces[index + 8]);
                }
            }
            else
            {
                for (int i = 0; i < NB_MAX_PIECE; i++)
                {
                    pieces[i].position = echiquier.Cases[i];
                    echiquier.Cases[i].Link(pieces[i]);
                }
            }
        }
    }
}
