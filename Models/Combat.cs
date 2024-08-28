using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Combat
    {
        public Equipe<Creature> equipe1 { get; set; }
        int indexCreature1 = 0;

        public Equipe<Creature> equipe2 { get; set; }
        int indexCreature2 = 0;
        public void boucle ()
        {
            Random random = new Random();
            string inputJoueur;
            while (equipe1 is not null && equipe2 is not null && !equipe1.estVaincu() && !equipe2.estVaincu())
            {
                Console.Clear();
                Console.WriteLine("- - - Nouveau tour - - -");
                Console.WriteLine($"{equipe1[indexCreature1].Nom} ({equipe1[indexCreature1].PointDeVieActuel}/{equipe1[indexCreature1].PointDeVieMax}) face à {equipe2[indexCreature2].Nom} ({equipe2[indexCreature2].PointDeVieActuel}/{equipe2[indexCreature2].PointDeVieMax})");
                Console.WriteLine("Que souhaiter vous faire ?");
                Console.WriteLine("(1) Attaquer   (2) Défendre   (3) Esquiver   (4) Changer de créature");

                inputJoueur = null;
                do
                {
                    inputJoueur = Console.ReadLine();
                }
                while (inputJoueur != "1" && inputJoueur != "2" && inputJoueur != "3" && inputJoueur != "4");

                string choixAdverse = "1";

                #region changement de creature
                if (choixAdverse == "4" )
                {
                    Console.WriteLine("L'adverse change de créature");
                    indexCreature2 = ChangementCreatureAdverse(equipe2);
                }
                else if (inputJoueur == "4")
                {
                    Console.WriteLine("Le joueur change de créature");
                    indexCreature1 = ChangementCreatureJoueur(equipe1, indexCreature1);

                }
                #endregion

                #region Se défendre
                if (choixAdverse == "2")
                {
                    Console.WriteLine("La créature adverse se protége");
                    equipe2[indexCreature2].SeProteger();
                }
                else if (inputJoueur == "2")
                {
                    Console.WriteLine("La créature du joueur se protége");
                    equipe1[indexCreature1].SeProteger();
                }
                #endregion

                #region Esquiver
                if (choixAdverse == "3")
                {
                    Console.WriteLine("La créature adverse se prépare à esquiver");
                    equipe2[indexCreature2].Esquiver();
                }
                else if (inputJoueur == "3")
                {
                    Console.WriteLine("La créature du joueur se prépare à esquiver");
                    equipe1[indexCreature1].Esquiver();
                }
                #endregion

                #region Attaquer
                if (choixAdverse == "1" || inputJoueur == "1")
                {
                    if (choixAdverse == "1" && inputJoueur == "1")
                    {
                        Console.WriteLine("Les 2 créatures vont frapper");
                        if (equipe1[indexCreature1].Vitesse >= equipe2[indexCreature2].Vitesse)
                        {
                            equipe1[indexCreature1].Attaquer(equipe2[indexCreature2]);
                            equipe2[indexCreature2].Attaquer(equipe1[indexCreature1]);
                        }
                        else
                        {
                            equipe2[indexCreature2].Attaquer(equipe1[indexCreature1]);
                            equipe1[indexCreature1].Attaquer(equipe2[indexCreature2]);
                        }
                    }
                    if (choixAdverse == "1")
                    {
                        Console.WriteLine("La créature adverse va frapper");
                        equipe1[indexCreature2].Attaquer(equipe2[indexCreature1]);
                    }
                    else
                    {
                        Console.WriteLine("La créature du joueur va frapper");
                        equipe1[indexCreature1].Attaquer(equipe2[indexCreature2]);
                    }
                }
                #endregion

                Console.ReadLine();
                #region cas de défaite de créature
                if (equipe1[indexCreature1].PointDeVieActuel == 0 && !equipe1.estVaincu())
                {
                    Console.WriteLine("La créature du joueur ne peut plus combattre");
                    indexCreature1 = ChangementCreatureJoueur(equipe1, indexCreature1);
                }
                if (equipe2[indexCreature2].PointDeVieActuel == 0 && !equipe2.estVaincu())
                {
                    Console.WriteLine("ici");
                    Console.WriteLine("La créature adverse ne peut plus combattre");
                    indexCreature2 = ChangementCreatureAdverse(equipe2);
                }
                #endregion
                Console.ReadLine();
            }
            if (equipe1.estVaincu())
            {
                Console.WriteLine("L'adverse a gagné'");
            }
            else if (equipe2.estVaincu())
            {
                Console.WriteLine("Le joueur a gagné'");
            }
        }
        public int ChangementCreatureJoueur(Equipe<Creature> equipe, int index)
        {
            int valeurEnInt;
            do
            {
                string inputJoueur = null;
                do
                {
                    inputJoueur = Console.ReadLine();
                }
                while (inputJoueur != "1" && inputJoueur != "2" && inputJoueur != "3");
                valeurEnInt = int.Parse(inputJoueur);
            }
            while (equipe[valeurEnInt].PointDeVieActuel == 0);
            return index;
        }
        public int ChangementCreatureAdverse(Equipe<Creature> equipe)
        {
            int valeurEnInt = -1;
            do
            {
                valeurEnInt++;
                Console.WriteLine(equipe[valeurEnInt].PointDeVieActuel);
            }
            while (equipe[valeurEnInt].PointDeVieActuel == 0);
            return valeurEnInt;
        }

    }
}
