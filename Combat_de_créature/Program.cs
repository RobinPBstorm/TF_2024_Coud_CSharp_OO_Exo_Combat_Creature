using Models;

EquipeCreature equipe1 = new EquipeCreature();
Orque orque1 = new Orque();
orque1.Force = 10;
orque1.Armure = 5;
orque1.Vitesse = 5;
orque1.PointDeVieMax = 5;
orque1.Nom = "orque1";
equipe1.Add(orque1.Nom, orque1);

Gobelin gobelin1 = new Gobelin();
gobelin1.Force = 10;
gobelin1.Armure = 5;
gobelin1.Vitesse = 5;
gobelin1.PointDeVieMax = 5;
gobelin1.Nom = "gobelin1";
equipe1.Add(gobelin1.Nom, gobelin1);

Centaure centaure1 = new Centaure();
centaure1.Force = 10;
centaure1.Armure = 5;
centaure1.Vitesse = 5;
centaure1.PointDeVieMax = 5;
centaure1.Nom = "centaure1";
equipe1.Add(centaure1.Nom, centaure1);

EquipeCreature equipe2 = new EquipeCreature();
Orque orque2 = new Orque();
orque2.Force = 10;
orque2.Armure = 5;
orque2.Vitesse = 5;
orque2.PointDeVieMax = 5;
orque2.Nom = "orque2";
equipe2.Add(orque2.Nom, orque2);

Gobelin gobelin2 = new Gobelin();
gobelin2.Force = 10;
gobelin2.Armure = 5;
gobelin2.Vitesse = 5;
gobelin2.PointDeVieMax = 5;
gobelin2.Nom = "gobelin2";
equipe2.Add(gobelin2.Nom, gobelin2);

Centaure centaure2 = new Centaure();
centaure2.Force = 10;
centaure2.Armure = 5;
centaure2.Vitesse = 5;
centaure2.PointDeVieMax = 5;
centaure2.Nom = "centaure2";
equipe2.Add(centaure2.Nom, centaure2);

Combat combat = new Combat();
combat.equipe1 = equipe1;
combat.equipe2 = equipe2;

combat.boucle();
