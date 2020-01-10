using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Webzine.Entity;

namespace Webzine.EntitiesContext
{
    public class LocalDataSeeder
    {

        public static void Initialize(WebzineDbContext context)
        {
            using (var transaction = context.Database.BeginTransaction())
            {

                foreach (Style style in FactoryStyle.Styles)
                {
                    style.TitresStyles = null;
                    context.Styles.Add(style);
                }
                
                context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT Style ON");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT Style OFF");
                context.SaveChanges();

                transaction.Commit();
            }

            using (var transaction = context.Database.BeginTransaction())
            {

                foreach (Artiste artiste in FactoryArtiste.Artistes)
                {
                    artiste.Titres = null;
                    context.Artistes.Add(artiste);
                }

                context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT Artiste ON");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT Artiste OFF");
                context.SaveChanges();

                transaction.Commit();
            }

            using (var transaction = context.Database.BeginTransaction())
            {

                foreach (Titre titre in FactoryTitre.Titres)
                {
                    titre.Commentaires = null;
                    titre.TitresStyles = null;
                    titre.Artiste = null;
                    context.Titres.Add(titre);
                }

                context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT Titre ON");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT Titre OFF");
                context.SaveChanges();

                transaction.Commit();
            }

            using (var transaction = context.Database.BeginTransaction())
            {

                foreach (Commentaire commentaire in FactoryCommentaire.Commentaires)
                {
                    commentaire.Titre = null;
                    context.Commentaires.Add(commentaire);
                }

                context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT Commentaire ON");
                context.SaveChanges();
                context.Database.ExecuteSqlCommand(@"SET IDENTITY_INSERT Commentaire OFF");
                context.SaveChanges();

                transaction.Commit();
            }

            using (var transaction = context.Database.BeginTransaction())
            {

                foreach (TitreStyle titreStyle in FactoryTitreStyle.TitreStyles)
                {
                    titreStyle.Titre = null;
                    titreStyle.Style = null;
                    context.TitresStyles.Add(titreStyle);
                }
                context.SaveChanges();

                transaction.Commit();
            }
            
        }
    }
}
