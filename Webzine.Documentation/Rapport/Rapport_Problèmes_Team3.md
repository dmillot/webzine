


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



