using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echecs.IHM
{
    public interface IEvenements
    {
        void ActualiserPartie(StatusPartie status);

        void ActualiserCase(int x, int y, InfoPiece info);

        void ActualiserCaptures(List<InfoPiece> pieces);
    }

     public enum EtatPartie {
        Reset,
        Trait,
        Echec,
        Mat
    };

    public enum TypePiece
    {
        Roi,
        Dame,
        Tour,
        Fou,
        Cavalier,
        Pion
    }

    public enum CouleurCamp
    {
        Blanche,
        Noire
    }

    public class InfoPiece
    {
        public TypePiece type { get; private set; }
        public CouleurCamp couleur { get; private set; }

        private InfoPiece(TypePiece type, CouleurCamp couleur)
        {
            this.type = type;
            this.couleur = couleur;
        }

        public static InfoPiece RoiBlanc      = new InfoPiece(TypePiece.Roi,      CouleurCamp.Blanche);
        public static InfoPiece DameBlanche   = new InfoPiece(TypePiece.Dame,     CouleurCamp.Blanche);
        public static InfoPiece TourBlanche   = new InfoPiece(TypePiece.Tour,     CouleurCamp.Blanche);
        public static InfoPiece FouBlanc      = new InfoPiece(TypePiece.Fou,      CouleurCamp.Blanche);
        public static InfoPiece CavalierBlanc = new InfoPiece(TypePiece.Cavalier, CouleurCamp.Blanche);
        public static InfoPiece PionBlanc     = new InfoPiece(TypePiece.Pion,     CouleurCamp.Blanche);
        public static InfoPiece RoiNoir       = new InfoPiece(TypePiece.Roi,      CouleurCamp.Noire);
        public static InfoPiece DameNoire     = new InfoPiece(TypePiece.Dame,     CouleurCamp.Noire);
        public static InfoPiece TourNoire     = new InfoPiece(TypePiece.Tour,     CouleurCamp.Noire);
        public static InfoPiece FouNoir       = new InfoPiece(TypePiece.Fou,      CouleurCamp.Noire);
        public static InfoPiece CavalierNoir  = new InfoPiece(TypePiece.Cavalier, CouleurCamp.Noire);
        public static InfoPiece PionNoir      = new InfoPiece(TypePiece.Pion,     CouleurCamp.Noire);

        public static InfoPiece GetInfo(CouleurCamp couleurCamp, TypePiece type)
        {
            switch(type)
            {
                case TypePiece.Roi      : return couleurCamp == CouleurCamp.Blanche ? RoiBlanc      : RoiNoir;
                case TypePiece.Dame     : return couleurCamp == CouleurCamp.Blanche ? DameBlanche   : DameNoire;
                case TypePiece.Tour     : return couleurCamp == CouleurCamp.Blanche ? TourBlanche   : TourNoire;
                case TypePiece.Fou      : return couleurCamp == CouleurCamp.Blanche ? FouBlanc      : FouNoir;
                case TypePiece.Cavalier : return couleurCamp == CouleurCamp.Blanche ? CavalierBlanc : CavalierNoir;
                case TypePiece.Pion     : return couleurCamp == CouleurCamp.Blanche ? PionBlanc     : PionNoir;
                default                 : return null;
            }
        }
    }

    public class StatusPartie
    {
        public EtatPartie etat { get; private set; }
        public CouleurCamp couleur { get; private set; }

        private StatusPartie(EtatPartie etat, CouleurCamp couleur)
        {
            this.etat = etat;
            this.couleur = couleur;
        }

        public static StatusPartie Reset       = new StatusPartie(EtatPartie.Reset, CouleurCamp.Blanche);
        public static StatusPartie TraitBlancs = new StatusPartie(EtatPartie.Trait, CouleurCamp.Blanche);
        public static StatusPartie TraitNoirs  = new StatusPartie(EtatPartie.Trait, CouleurCamp.Noire);
        public static StatusPartie EchecBlancs = new StatusPartie(EtatPartie.Echec, CouleurCamp.Blanche);
        public static StatusPartie EchecNoirs  = new StatusPartie(EtatPartie.Echec, CouleurCamp.Noire);
        public static StatusPartie MatBlancs   = new StatusPartie(EtatPartie.Mat,   CouleurCamp.Blanche);
        public static StatusPartie MatNoirs    = new StatusPartie(EtatPartie.Mat,   CouleurCamp.Noire);
    }
}
