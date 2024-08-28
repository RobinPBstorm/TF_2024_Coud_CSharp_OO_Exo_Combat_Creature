using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Gobelin: Creature
    {
        public Gobelin(string nom) : base(nom) 
        {
            genererStat(-1, -1, 3, 0);
        }
        public Gobelin(string nom, int force, int armure, int vitesse, int pointDeVie) : base(nom, force, armure, vitesse, pointDeVie) { }

        public override string ToString()
        {
            return $"Gobelin {base.ToString()}";
        }
    }
}
