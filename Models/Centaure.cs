using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class Centaure: Creature
    { 
        public Centaure(string nom) : base(nom) 
        {
            genererStat(1, -3, 2, 4);
        }
        public Centaure(string nom, int force, int armure, int vitesse, int pointDeVie) : base(nom, force, armure, vitesse, pointDeVie) { }

        public override string ToString()
        {
            return $"Centaure {base.ToString()}";
        }
    }
}
