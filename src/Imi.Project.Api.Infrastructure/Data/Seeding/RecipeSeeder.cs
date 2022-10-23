using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class RecipeSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Title = "Testrecept",
                    Description = "Dit recept test de werking van dit recept.",
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Title = "Witte saus",
                    Description = "Maak een roux van de boter en de bloem. Dit doe je door de boter in een steelpannetje te smelten. " +
                                  "Doe de bloem bij de boter en roer met de garde.\r\n\r\nLaat het mengsel een beetje opdrogen in het pannetje, " +
                                  "tot je de geur van koekjes ruikt.\r\n\r\nGiet er beetje bij beetje de koude melk bij en roer telkens het mengsel glad. " +
                                  "Breng al roerend aan de kook, op matig vuur. Laat de witte saus indikken en laat nog enkele minuten doorkoken zodat de bloemsmaak " +
                                  "verdwijnt.Breng op smaak met nootmuskaat, peper en zout.",
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Title = "Gemarineerde brochetten",
                    Description = "Koop brochetten van de slager, easy. Smijt ze in een ovenpan, doe er boter over en zet ze in de combi-oven. Serveer met rijst en wortelen.",
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Title = "Champignonsoep",
                    Description = "Neem een ruime mengschaal, doe er het warm water in en week er de gedroogde paddenstoelen in. Het eekhoorntjesbrood zal z’n smaak " +
                                  "afgeven en het water in een bouillon veranderen. Pel de uien en snij ze in grove stukken. Verhit een ruime stoofpot of een soepketel. " +
                                  "Smelt er een klont boter in en stoof de stukken ui. Snij de stammen prei overlangs door, snij het donkerste loof weg en spoel ze onder " +
                                  "stromend water. Snij de gewassen prei in grove stukken en stoof ze mee met de uien. Pel de look, snij de teentjes grof en laat ze ook " +
                                  "meestoven. Maak 2/3 van de Parijse paddenstoelen schoon. Gebruik een borsteltje en snij (indien nodig) het steeltje wat bij. " +
                                  "Snij de paddenstoelen vervolgens middendoor en laat ze meestoven. Hou 1/3 van de paddenstoelen opzij. Maak een bouquet garni met " +
                                  "enkele blaadjes laurier, wat tijm en (indien beschikbaar) peterseliestengels. Bind alles samen met een eindje keukentouw en laat het " +
                                  "kruidentuiltje meestoven. Schil de aardappelen en snij ze in grove stukken. Laat ze meestoven. Zeef de bouillon van eekhoorntjesbrood " +
                                  "en giet het vocht in de soepketel met gestoofde groenten. De rubberachtige gewelde paddenstoelen gebruiken we niet. Laat de soep een " +
                                  "half uur sudderen op een zacht vuur. Intussen kan je de kaasstengels bereiden. Verwijder het bouquet garni en mix de soep glad met " +
                                  "een staafmixer. Je hoeft ze niet te zeven. Mix er ook een flinke scheut room in. Proef de soep en kruid het gerecht naar smaak met " +
                                  "wat peper van de molen en een snuif zout.",
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Title = "Gehaktbrood met bonen en patatten",
                    Description = "Meng gehakt en ajuin in een schaal en mix ze. Smijt de mix in een ovenpan en herschaap het tot een brood. Doe er vervolgens paneermeel " +
                                  "en boter over. 20 minuten in de combi-oven. Kook de patatten en de bonen. Smakelijk.",
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Title = "Hamburger met wortel en patatten",
                    Description = "Wortelen snijden en koken. Kook de patatten. Doe de hamburger in een pan en laat het bakken. Easy-peasy.",
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Title = "Viskroketjes met gebakken aardappelen",
                    Description = "1-pansgerecht met viskroketjes en patatjes. Groenten zijn voor de dieren.",
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Title = "Grillworst met puree",
                    Description = "Patatten koken tot ze zacht zijn. Water afgieten, doe er melk en nootmuskaat bij. Grillworst in de microgolfoven voor anderhalf minuut ofzo.",
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Title = "Spaghetti bolognaise",
                    Description = "1) Snij de ajuin, paprika, wortelen, courgette en champignons tot je ze klein genoeg vindt. Doe ze vervolgens allemaal in de pot met wat boter." +
                                  "2) Smijt het gehakt in een pan en bak ze lichtjes. Kap ze in kleinere stukken eenmaal de buitenkant gebakken is." +
                                  "3) Kook de spaghetti en voeg voldoende tomatenpuree en kruiden bij de bolognaise." +
                                  "4) Serveer met gemalen kaas." +
                                  "5) Bon appetit.",
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Title = "Ongelooflijk goed gerecht",
                    Description = "Ga naar de frituur ipv te koken. Ongelooflijk goed he LOL!",
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    CreatedOn = DateTime.Now,
                    LastEditedOn = DateTime.Now
                }
                );
        }
    }
}
