using Models;

//Equipe<Creature> equipe1 = new Equipe<Creature>();
//Orque orque1 = new Orque("orque1");
//equipe1.Add(orque1.Nom, orque1);

//Gobelin gobelin1 = new Gobelin("gobelin1");
//equipe1.Add(gobelin1.Nom, gobelin1);

//Centaure centaure1 = new Centaure("centaure1");
//equipe1.Add(centaure1.Nom, centaure1);

//Equipe<Creature> equipe2 = new Equipe<Creature>();
//Orque orque2 = new Orque("orque2");
//equipe2.Add(orque2.Nom, orque2);

//Gobelin gobelin2 = new Gobelin("gobelin2");
//equipe2.Add(gobelin2.Nom, gobelin2);

//Centaure centaure2 = new Centaure("centaure2");
//equipe2.Add(centaure2.Nom, centaure2);

//Console.WriteLine(equipe1);
//Console.WriteLine("- - -");
//Console.WriteLine(equipe2);



Combat combat = new Combat();
combat.equipe1 = CreateurEquipe.Start();
combat.equipe2 = CreateurEquipe.Start();

Console.WriteLine(combat.equipe1);
Console.WriteLine("- - -");
Console.WriteLine(combat.equipe2);

combat.boucle();
