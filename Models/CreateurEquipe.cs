using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class CreateurEquipe
    {
        public static Equipe<Creature> Start()
        {
            Equipe<Creature> equipe = new Equipe<Creature>();

            string inputJoueur = null;
            do
            {
                Console.WriteLine("Souhaitez-vous rajouter une créature ?");
                foreach (int i in Enum.GetValues(typeof(EnumCreature)))
                {
                    Console.WriteLine($"({i}) => {(EnumCreature)i}");
                }
                Console.WriteLine("Tapper 'fin' pour arreter la sélection");

                inputJoueur = Console.ReadLine();

                ProcessEntreeJoueur(equipe, inputJoueur);
            }
            while (inputJoueur?.ToLower() != "fin");

            return equipe;
        }

        private static void ProcessEntreeJoueur(Equipe<Creature> equipe, string? inputJoueur)
        {
            if (inputJoueur is null) return;

            Creature creature = null;
            switch(inputJoueur)
            {
                case "1":
                    creature = new Orque($"orque{equipe.Count}");
                    break;
                case "2":
                    creature = new Gobelin($"Gobelin{equipe.Count}");
                    break;
                case "3":
                    creature = new Centaure($"Centaure{equipe.Count}");
                    break;
            }
            if(creature is not null)
            {
                equipe.Add(creature.Nom, creature);
                Console.WriteLine("Une creature a été ajouté");
            }
            Console.WriteLine($"La taille actuelle de l'équipe est de {equipe.Count}");
        }
    }
}
