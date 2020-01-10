using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using Webzine.Entity;

namespace Webzine.EntitiesContext
{
    public static class SpotifyDataSeeder
    {

        class SpotifyToken
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public long expires_in { get; set; }
        }

        public static void Initialize(WebzineDbContext context)
        {
            string client_id = "d9e99f5831b940a5b3b59efd7f119e69"; // Your client id
            string client_secret = "76cd2a308f10479195200861cf25c5e4"; // Your secret
            string accesToken = GetAccessToken(client_id, client_secret);

            List<string> artistsIds = new List<string>(){ "3NH8t45zOTqzlZgBvZRjvB","7p0odCZxOVz684NjXt1dEf"};

            Style spotifyStyle = new Style()
            {
                Libelle = "spotify provided",
                TitresStyles = new List<TitreStyle>()
            };
            context.Add<Style>(spotifyStyle);
            context.SaveChanges();

            foreach(string artistId in artistsIds)
            {
                string uriArtists = $"https://api.spotify.com/v1/artists/{artistId}/top-tracks?country=FR";
                var artistsTxt = Get(uriArtists, accesToken);
                var artistsJson = JsonConvert.DeserializeObject<dynamic>(artistsTxt);

                Artiste artist = new Artiste()
                {
                    Nom = artistsJson["tracks"][0]["artists"][0]["name"],
                    Biographie = "Vers acteurs aux clapotements criards cotons les ces ou plus vrai la et et jour comme l'horizon l'europe ces par échouages fini pareille et l'ouragan cotons marées un des les clabaudeurs voiliers aux ravie d'ineffables sanglot fleurs taché des aux million vers poissons impassibles a et les cloués des et colombes violettes et ivre mes florides un sur jaune insoucieux amer de voir circulation tendus pénétra tout anglais flottaison bords délirants appelle nuit aux qui quille au chanteurs qu'un soir restais flamands pourrit île bruns noire immobilités cru flot victimes noyés de embaumé l'assaut glaciers la courants des de restais",
                    Titres = new List<Titre>()
                };

                context.Add<Artiste>(artist);
                context.SaveChanges();
                Artiste newArtiste = context.Artistes.FirstOrDefault(a => a.Nom == artist.Nom);

                foreach (var artistTracks in artistsJson["tracks"])
                {
                    DateTime dateCreation = DateTime.Now;
                    /*if (artistTracks["album"]["release_date_precision"] == "day")
                    {
                        dateCreation = DateTime.Parse(artistTracks["album"]["release_date"]);
                    }
                    else if (artistTracks["album"]["release_date_precision"] == "month")
                    {
                        dateCreation = DateTime.Parse(artistTracks["album"]["release_date"]+"-01");
                    }
                    else if (artistTracks["album"]["release_date_precision"] == "year")
                    {
                        dateCreation = new DateTime(artistTracks["album"]["release_date"], 1, 1);
                    }*/

                    Titre titre = new Titre()
                    {
                        Artiste = artist,
                        Album = artistTracks["album"]["name"],
                        Chronique = "Des les épais aux porteur de volets florides et courais plein des figements sourd a délirants que cheveux nuits bruns flots poissons écroulement dans sillage t'exiles je frele froide roulis roulis ce en a geindre figements bleuités lorsqu'a ailé de ces montant mystiques rut je bouchon sur vogueur comme dormir ces sanglot d'horreurs les cieux froide sentant ciel est-ce lava leur hystériques gouffres yeux nuits je dans travers je ou pôles et que léviathan puis de tout dans sont - ou roulant bateau plus de descendais des et phosphores d'or choient gouffres éternel mois seves chair t'exiles de je poissons",
                        Commentaires = new List<Commentaire>(),
                        DateCreation = DateTime.Now,
                        DateSortie = dateCreation,
                        Duree = artistTracks["duration_ms"]/100,
                        IdArtiste = artist.IdArtiste,
                        Libelle = artistTracks["name"],
                        NbLectures = 0,
                        NbLikes = 0,
                        TitresStyles = new List<TitreStyle>(),
                        UrlEcoute = artistTracks["preview_url"],
                        UrlJaquette = artistTracks["album"]["images"][1]["url"]
                    };

                    context.Add<Titre>(titre);
                    context.SaveChanges();

                    TitreStyle titreStyle = new TitreStyle()
                    {
                        IdStyle = spotifyStyle.IdStyle,
                        IdTitre = titre.IdTitre,
                        Style = spotifyStyle,
                        Titre = titre
                    };

                    context.Add<TitreStyle>(titreStyle);
                    context.SaveChanges();


                }
            }

            
        }

        public static string GetAccessToken(string clientid, string clientsecret)
        {
            SpotifyToken token = new SpotifyToken();
            string url5 = "https://accounts.spotify.com/api/token";

            //request to get the access token
            var encode_clientid_clientsecret = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", clientid, clientsecret)));

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url5);

            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.Accept = "application/json";
            webRequest.Headers.Add("Authorization: Basic " + encode_clientid_clientsecret);

            var request = ("grant_type=client_credentials");
            byte[] req_bytes = Encoding.ASCII.GetBytes(request);
            webRequest.ContentLength = req_bytes.Length;

            Stream strm = webRequest.GetRequestStream();
            strm.Write(req_bytes, 0, req_bytes.Length);
            strm.Close();

            HttpWebResponse resp = (HttpWebResponse)webRequest.GetResponse();
            String json = "";
            using (Stream respStr = resp.GetResponseStream())
            {
                using (StreamReader rdr = new StreamReader(respStr, Encoding.UTF8))
                {
                    //should get back a string i can then turn to json and parse for accesstoken
                    string text = rdr.ReadToEnd();
                    token = JsonConvert.DeserializeObject<SpotifyToken>(text);
                    rdr.Close();
                }
            }
            return token.access_token;
        }

        public static string Get(string url,string token)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Accept = "application/json";
            request.ContentType = "application/json";
            request.Headers.Add("Authorization: Bearer " + token);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
