# Combat de créature 
Créer un programme qui permet de simuler un affrontement entre 2 dresseurs. 

Chaque dresseur peut avoir dans son équipe jusqu'à 3 créatures. 

## Une créature possède plusieurs statistiques 

• Force : 

o Permet de définir la puissance des coups. 

o Entre 1 - 10 

• Armure :  

o Réduit le dégât. 

o Entre 0 - 10 

• Vitesse : 

o Prit en compte pour l'esquive de la créature (max : 20%) 

o Entre 1 - 10 

• Point de vie : 

o Entre 15 – 30 

⚠Une créature valide a maximum un total de 42 points de statistiques 

## Le dresseur peut commander la créature : 

• Attaque : 

o Infliger des dégâts 

o Il y a 5% de chance d’infliger un coup critique (2x dégâts) 

• Se protéger : 

o Permet de restaurer son armure. 

o Réduit les dégâts de moitié durant le tour 

• Esquiver : 

o Donne 50% de bonus pour esquiver l'attaque durant le tour 

• Changer de créature (BONUS) 

o Permet au dresseur de changer de créature durant le combat 

Les combats se déroulent en tour par tour, les actions sont résolues dans l’ordre suivant 

1) Changer de créature 
2) Préparer une esquive 
3) Se protéger 
4) Effectuer l’attaque
   
o En cas d’attaque des 2 créatures, la vitesse permet de définir l'initiative. 
