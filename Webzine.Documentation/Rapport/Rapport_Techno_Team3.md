# Technologies Utilis�es
##### [Retour au sommaire](Rapport_Introduction_Team3)

#

### Utilisation du Db context : 

Nous avons utiliser le Db context afin de faire communiquer notre application et notre base de donn�es. L'utilisation est param�trable dans le ficher appsettings.json pr�sent � la racine de la Web app.

###### 

Le contexte est utilis� dans deux situations :

* Dans le cas ou on traite les donn�es dans notre base ( ajouter, supprimer, ect )
* Dans le cas ou l'on Seed notre base de donn�es

De plus, il nous permet de construire notre base de donn�es � l'aide de ModelBuilder, il s'agit du Code First. Pour cela il est n�cessaire d'annoter nos classes pour d�finir leur utilisation.

Suite � cela il cela necessaire de d�finir les relations dans le modelbuilder de notre DbContext.

Enfin pour acceder aux donn�es, nous utilisons les accesseurs Dbset de notre Contexte

###### Exemple : 

DbSet de style nomm� Styles

Afin d'obtenir tous les styles de notre base de donn�es en tilisant le context il nous suffirait simplement de faire : 

#### return Context.Styles

Tout les Styles pr�sent dans notre base de donn�e seront retourn�e mais seulement ces �lements.

#

### Utilisation de bootstrap

Afin de r�aliser un site correspondant aux attentes du client nous avons r�alis� l'aspect visuel � l'aide de bootstrap. Il y a peut � dire � ce sujetmais il est possible de se renseigner � ce sujet 
[ici](Rapport_Annexes_Team4)

#

### Utilisation de Newtonsoft.Json

Au cours de ce projet il �tait necessaire de r�aliser un seeder qui r�cup�rait des donn�es depuis l'API de Spotify afin la r�ponse �tant un flux Json, il �tait necessaire de D�serializer les donn�es pour les inserer dans notre base
