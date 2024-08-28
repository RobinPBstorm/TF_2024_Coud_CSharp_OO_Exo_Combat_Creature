using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Orque: Creature
    {
        public Orque(string nom) : base(nom)
        {
            Nom = nom;

            genererStat( 2, 2, -2, 1);
        }
        public Orque(string nom, int force, int armure, int vitesse, int pointDeVie) : base(nom, force, armure, vitesse, pointDeVie) { }

        public override string ToString()
        {
            return $"Orque {base.ToString()}";
        }
    }
}
