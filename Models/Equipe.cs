namespace Models
{
    public class Equipe<T> where T : Creature
    {
		private int tailleMax = 3;
        private Dictionary<string, T> _Creatures = new Dictionary<string, T>();

		public Dictionary<string, T> Creatures
		{
			get { return _Creatures; }
			set { _Creatures = value; }
		}

		public int Count 
		{ 
			get { return _Creatures is null ? 0 : _Creatures.Count; } 
		}
		public T? this[string nomCreature]
		{
			get
			{
				if (!Creatures.ContainsKey(nomCreature))
                {
                    return null;
                }
                return Creatures[nomCreature];
            }
			set
			{
				Creatures[nomCreature] = value;
			}
		}
		public T? this[int positionEquipe]
		{
			get 
			{
				if (positionEquipe > tailleMax || positionEquipe > Creatures.Values.ToArray().Count())
				{
					return null;
				}
                return Creatures.Values.ToArray()[positionEquipe];
            }
		}

		public void Add(string nomCreature, T creature) 
		{
            if (Creatures.Count < 3)
            {
				Creatures.Add(nomCreature, creature);
            }
        }

		public bool estVaincu()
		{
			bool vaincu = true;
			int i = 0;
			while (i < Creatures.Count && vaincu)
			{
				if (Creatures.Values.ToArray()[i].PointDeVieActuel > 0)
				{
					vaincu = false;
				}
				i++;
			}

			return vaincu;
		}

        public override string ToString()
        {
			string content;

			if (Creatures.Values.Count < 1)
			{
				content = "l'équipe est vide";
			}
			else
			{
				content = "";
				foreach(T creature in Creatures.Values)
				{
					content += creature.ToString() + "\n";
				}
			}

			return content;
        }
    }
}
