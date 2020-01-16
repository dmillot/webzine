


#	Problèmes Rencontrés : 
##### [Retour au sommaire](Rapport_Introduction_Team3)


* ##### [Problèmes lors de la récupération des données depuis le context]()





##### Problèmes lors de la récupération des données depuis le context()

Lors du changement de repository au profit du repos DB plusieur problémes ont été soulevé, nottament les pages ne pouvaient plus s'afficher suite au manque d'élément que nous obtenions auparavant.

###### Solution trouvée : 

Une méthode makeLink à été créé afin d'attribuer les éléments avec d'autres qui leurs appartiens

###### Solution Retenue : 

L'utilisation des include dans nos requète Linq afin de récuperer l'entièreté des élements

##### Problèmes lors de la récupération d'un ou plusieurs titres avec l'Api

Lors de la récupération d'un ou plusieurs titre, il était impossible de le ou les récupérer car la requête effectuait une boucle. Car l'objet titre possède une liste de style et la liste de style possède des titres
ce qui nous faisait dépasser la valeur max de la réponse. 

##### Solution trouvé : 

On peux modifier le formattage de la serialization du Json, pour cela il nous a fallu mettre la méthode "ReferenceLoopHandling" en Ignore

##### Solution retenue : 

L'utilisation d'une autre forme de formattage de la sérialization

##### Problèmes lors de l'insertion de données lors du seed de la base de données

Lors de l'insertion de données dans la base de données localdb sqlserver, une exception était levé car l'insertion d'une identité n'était pas possible. Par exemple pour insérer un style, le champ IdStyle ne peut etre mis manuellement.

##### Solution trouvé : 

Pour insérer une identité manuellement dans une table, il faut autoriser l'insertion d'identité avec la commande `SET IDENTITY_INSERT Style ON`. Donc excecuter la commande sql sur la base de donnée avec `context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT Style ON");` </br>
Ensuite Pour insérer les entités suivantes il faut enlever l'autorisation pour la donner au autres tables avec la commande `SET IDENTITY_INSERT Style OFF` </br>
De plus il faut sauvegarder les modifications apres chaque commande sql avec `context.SaveChanges();`

##### Solution retenue : 

Pour insérer des entités avec des id prédéfinis il faut insérer les données par type.


