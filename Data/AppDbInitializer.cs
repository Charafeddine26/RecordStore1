using Microsoft.EntityFrameworkCore;
using RecordStore.Models;


namespace RecordStore.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
               

                //Label
                if (!context.Labels.Any())
                {
                    context.Labels.AddRange(new List<Label>()
                    {
                        new Label()
                        {
                            Nom = "Label 1",
                            PictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/DefJamRecordings.svg/1200px-DefJamRecordings.svg.png",
                            Description = "Description of the first Label"
                        },
                        new Label()
                        {
                            Nom = "Label 2",
                            PictureURL = "http://dotnethow.net/images/Labels/Label-2.jpeg",
                            Description = "This is the description of the first Label"
                        },
                        new Label()
                        {
                            Nom = "Label 3",
                            PictureURL = "http://dotnethow.net/images/Labels/Label-3.jpeg",
                            Description = "This is the description of the first Label"
                        },
                        new Label()
                        {
                            Nom = "Label 4",
                            PictureURL = "http://dotnethow.net/images/Labels/Label-4.jpeg",
                            Description = "This is the description of the first Label"
                        },
                        new Label()
                        {
                            Nom = "Label 5",
                            PictureURL = "http://dotnethow.net/images/Labels/Label-5.jpeg",
                            Description = "This is the description of the first Label"
                        },
                    });
                    context.SaveChanges();
                }


                //Artiste
                if (!context.Genres.Any())
                {
                    context.Genres.AddRange(new List<Genre>()
                    {
                        new Genre()
                        {
                            DisqueGenre =  DisqueGenre.Punk


                        },
                        new Genre()
                        {
                            DisqueGenre = DisqueGenre.Funk

                        },
                        new Genre()
                        {
                            DisqueGenre = DisqueGenre.Jazz

                        },
                        new Genre()
                        {
                            DisqueGenre = DisqueGenre.Rock

                        },
                        new Genre()
                        {
                            DisqueGenre = DisqueGenre.Alternative
                        }
                    });
                    context.SaveChanges();
                }



                //Artiste
                if (!context.Artistes.Any())
                {
                    context.Artistes.AddRange(new List<Artiste>()
                    {
                        new Artiste()
                        {
                            FullName = "Artiste 11",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Artistes/Artiste-1.jpeg"

                        },
                        new Artiste()
                        {
                            FullName = "Artiste 22",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Artistes/Artiste-2.jpeg"
                        },
                        new Artiste()
                        {
                            FullName = "Artiste 33",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Artistes/Artiste-3.jpeg"
                        },
                        new Artiste()
                        {
                            FullName = "Artiste 44",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Artistes/Artiste-4.jpeg"
                        },
                        new Artiste()
                        {
                            FullName = "Artiste 55",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Artistes/Artiste-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Disque
                if (!context.Disques.Any())
                {
                    context.Disques.AddRange(new List<Disque>()
                    {
                        new Disque()
                        {
                            Album = "Album 1",
                            Prix = 200,
                            Annee = 1999,
                            Cover = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/DefJamRecordings.svg/1200px-DefJamRecordings.svg.png",
                            Format = "2LP",
                            Pressing = "UK",
                            GenreId = 2,
                            LabelId = 1

    },
                        new Disque()
                        {
                            Album = "Album 2",
                            Prix = 200,
                            Annee = 1999,
                            Cover = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/DefJamRecordings.svg/1200px-DefJamRecordings.svg.png",
                            Format = "2LP",
                            Pressing = "UK",
                            GenreId = 2,
                            LabelId = 1


                        },
                        new Disque()
                        {
                            Album = "Album 3",
                            Prix = 200,
                            Annee = 1999,
                            Cover = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/DefJamRecordings.svg/1200px-DefJamRecordings.svg.png",
                            Format = "2LP",
                            Pressing = "UK",
                            GenreId = 2,
                            LabelId = 1

                        },
                        new Disque()
                        {
                            Album = "Album 4",
                            Prix = 200,
                            Annee = 1999,
                            Cover = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/DefJamRecordings.svg/1200px-DefJamRecordings.svg.png",
                            Format = "2LP",
                            Pressing = "UK",
                            GenreId = 2,
                            LabelId = 1

                        },
                        new Disque()
                        {
                            Album = "Album 5",
                            Prix = 200,
                            Annee = 1999,
                            Cover = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/DefJamRecordings.svg/1200px-DefJamRecordings.svg.png",
                            Format = "2LP",
                            Pressing = "UK",
                            GenreId = 2,
                            LabelId = 1
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.JointDisqueArtistes.Any())
                  {

                    context.JointDisqueArtistes.AddRange(new List<JointDisqueArtiste>()
                    {
                        new JointDisqueArtiste()
                        {
                            DisqueId = 1,
                            ArtisteId = 1
                        },
                        new JointDisqueArtiste()
                        {
                            DisqueId = 3,
                            ArtisteId = 1
                        },

                         new JointDisqueArtiste()
                        {
                            DisqueId = 1,
                            ArtisteId = 2
                        },
                         new JointDisqueArtiste()
                        {
                            DisqueId = 4,
                            ArtisteId = 2
                        },

                        new JointDisqueArtiste()
                        {
                            DisqueId = 1,
                            ArtisteId = 3
                        },
                        new JointDisqueArtiste()
                        {
                            DisqueId = 2,
                            ArtisteId = 3
                        },
                        new JointDisqueArtiste()
                        {
                            DisqueId = 5,
                            ArtisteId = 3
                        },


                        new JointDisqueArtiste()
                        {
                            DisqueId = 2,
                            ArtisteId = 4
                        },
                        new JointDisqueArtiste()
                        {
                            DisqueId = 3,
                            ArtisteId = 4
                        },
                        new JointDisqueArtiste()
                        {
                            DisqueId = 4,
                            ArtisteId = 4
                        },


                        new JointDisqueArtiste()
                        {
                            DisqueId = 2,
                            ArtisteId = 5
                        },
                        new JointDisqueArtiste()
                        {
                            DisqueId = 3,
                            ArtisteId = 5
                        },
                        new JointDisqueArtiste()
                        {
                            DisqueId = 4,
                            ArtisteId = 5
                        },
                        new JointDisqueArtiste()
                        {
                            DisqueId = 5,
                            ArtisteId = 5
                        },


                        new JointDisqueArtiste()
                        {
                            DisqueId = 3,
                            ArtisteId = 2
                        },
                        new JointDisqueArtiste()
                        {
                            DisqueId = 4,
                            ArtisteId = 3
                        },
                        new JointDisqueArtiste()
                        {
                            DisqueId = 5,
                            ArtisteId = 2
                        },
                    });
                    
                    context.SaveChanges();
                }

            }
        }
    }
}