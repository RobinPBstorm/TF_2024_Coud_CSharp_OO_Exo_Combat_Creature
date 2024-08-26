using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Creature
    {
        #region variable et propriété
        #region Force
        protected int _Force;

        public int Force
        {
            get { return _Force; }
            set 
            {
                value = setValue(value, 15, 30);
                _Force = value; 
            }
        }

        #endregion

        #region Armure
        protected int _Armure;

        public int Armure
        {
            get { return _Armure; }
            set
            {
                value = setValue(value, 1, 10);
                _Armure = value; 
            }
        }

        #endregion

        #region Vitesse
        private int _Vitesse;

        public int Vitesse
        {
            get { return _Vitesse; }
            set 
            { 
                if (value < 1 || value > 10)
                {
                    value = 1;
                }
                _Vitesse = value; 
            }
        }

        #endregion

        #region Point de vie
        protected int _PointDeVieMax;

        public int PointDeVieMax
        {
            get { return _PointDeVieMax; }
            set 
            {
                value = setValue(value, 15, 30);
                _PointDeVieMax = value;
                _PointDeVieActuel = _PointDeVieMax;
            }
        }

        private int _PointDeVieActuel;

        public int PointDeVieActuel
        {
            get { return _PointDeVieActuel; }
            set 
            {
                _PointDeVieActuel = value;
            }
        }

        #endregion
        
        #region autre propriete
        protected bool vaSeProteger { get; set; } = false;

        protected bool vaEsquiver { get; set; } = false;

        public string Nom { get; set; }
        #endregion
        #endregion
        protected int setValue(int value, int min, int max)
        {

            return (value < min || value > max) ? min : value;
        }

        protected void sePrendDegats(int forceAdverse)
        {
            Random rand = new Random();

            int valeurEsquive = rand.Next(0, 100);
            
            if (valeurEsquive < (Vitesse * 2) + (vaEsquiver ? 50 : 0) )
            {
                return;
            }
            
            if (vaSeProteger)
            {
                forceAdverse /= 2;
            }

            int degatReduit = forceAdverse - Armure < 0 ? 0 : forceAdverse - Armure;
            _PointDeVieActuel = _PointDeVieActuel - degatReduit;

            if (_PointDeVieActuel < 0)
            {
                _PointDeVieActuel = 0;
            }

            vaEsquiver = false;
            vaSeProteger = false;
        }
        public void Attaquer(Creature cible)
        {
            cible.sePrendDegats(Force);
        }

        public void SeProteger()
        {
            vaSeProteger = true;
        }
        public void Esquiver()
        {
            vaEsquiver = true;
        }

        
    }
}
