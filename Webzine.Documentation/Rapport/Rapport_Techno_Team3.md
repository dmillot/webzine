# Technologies Utilisées
##### [Retour au sommaire](Rapport_Introduction_Team3)

#

### Utilisation du Db context : 

Nous avons utiliser le Db context afin de faire communiquer notre application et notre base de données. L'utilisation est paramétrable dans le ficher appsettings.json présent à la racine de la Web app.

###### 

Le contexte est utilisé dans deux situations :

* Dans le cas ou on traite les données dans notre base ( ajouter, supprimer, ect )
* Dans le cas ou l'on Seed notre base de données

De plus, il nous permet de construire notre base de données à l'aide de ModelBuilder, il s'agit du Code First. Pour cela il est nécessaire d'annoter nos classes pour définir leur utilisation.

Suite à cela il cela necessaire de définir les relations dans le modelbuilder de notre DbContext.

Enfin pour acceder aux données, nous utilisons les accesseurs Dbset de notre Contexte

###### Exemple : 

DbSet de style nommé Styles

Afin d'obtenir tous les styles de notre base de données en tilisant le context il nous suffirait simplement de faire : 

#### return Context.Styles

Tout les Styles présent dans notre base de donnée seront retournée mais seulement ces élements.

#

### Utilisation de bootstrap

Afin de réaliser un site correspondant aux attentes du client nous avons réalisé l'aspect visuel à l'aide de bootstrap. Il y a peut à dire à ce sujetmais il est possible de se renseigner à ce sujet 
[ici](Rapport_Annexes_Team4)

#

### Utilisation de Newtonsoft.Json

Au cours de ce projet il était necessaire de réaliser un seeder qui récupérait des données depuis l'API de Spotify afin la réponse étant un flux Json, il était necessaire de Déserializer les données pour les inserer dans notre base
