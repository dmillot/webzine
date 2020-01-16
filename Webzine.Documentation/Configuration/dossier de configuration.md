### Ficher de configuration appsettings.json dans le projet Webzine.Webapplication

# Propriétés
#### Repository : valeurs
* Local : Utilise les donnés en brut dans les classes factories
* Database : Utilise la base de données localdb sqlserver
#### Seeder (active si repository Database utilisé && database création activée) : valeurs
* Local : Remplis la base de données avec les données des classes factories
*  Spotify : Remplis la base de données avec 10 artiste et 100 titres de l'api spotify

#### DatabaseCreation (active si repository Database utilisé) : valeurs
* true : Efface la base de données et la recrée (+seed)
* false : Ne crée pas la base de données (A utiliser si la base de données a deja été crée)