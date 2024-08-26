namespace Models
{
    public class EquipeCreature
    {
		private int tailleMax = 3;
        private Dictionary<string, Creature> _Equipe = new Dictionary<string, Creature>();

		public Dictionary<string, Creature> Equipe
		{
			get { return _Equipe; }
			set { _Equipe = value; }
		}

		public int Count 
		{ 
			get { return _Equipe is null ? 0 : _Equipe.Count; } 
		}
		public Creature? this[string nomCreature]
		{
			get
			{
				if (!Equipe.ContainsKey(nomCreature))
                {
                    return null;
                }
                return Equipe[nomCreature];
            }
		}
		public Creature? this[int positionEquipe]
		{
			get 
			{
				if (positionEquipe > tailleMax || positionEquipe > Equipe.Values.ToArray().Count())
				{
					return null;
				}
                return Equipe.Values.ToArray()[positionEquipe];
            }
		}

		public void Add(string nomCreature, Creature creature) 
		{
            if (Equipe.Count < 3)
            {
				Equipe.Add(nomCreature, creature);
            }
        }

		public bool estVaincu()
		{
			bool vaincu = true;
			int i = 0;
			while (i < Equipe.Count && vaincu)
			{
				if (Equipe.Values.ToArray()[i].PointDeVieActuel > 0)
				{
					vaincu = false;
				}
				i++;
			}

			return vaincu;
		}
    }
}
