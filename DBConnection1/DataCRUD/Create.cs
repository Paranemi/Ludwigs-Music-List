using DBConnection1.Data;
using Microsoft.AspNetCore.Components;

namespace DBConnection1.DataCRUD
{
    public class Create
    {
        [Inject]
        public AppDataContext AppDatacontext { get; set; }

        //public Create(AppDataContext appDatacontext)
        //{
        //    AppDatacontext = appDatacontext;
        //}

/*

        public void WriteData()
        {
            var album1 = new Album
            {
                Name = "The Joy of Motion",
                ImageUrl = "./Images/jom.jpg",
                ReleaseDate = new DateTime(2014, 03, 03)
            };

            AppDataContext.Album.Add(album1);

            var album2 = new Album
            {
                Name = "Endgame",
                ImageUrl = "./Images/endgame.jpg",
                ReleaseDate = new DateTime(2011, 03, 11)
            };

            AppDataContext.Album.Add(album2);

            var album3 = new Album
            {
                Name = "Geräusche",
                ImageUrl = "./Images/grsch.jpg",
                ReleaseDate = new DateTime(2003, 09, 29)
            };

            AppDataContext.Album.Add(album3);

            var album4 = new Album
            {
                Name = "Master of Puppetsssss",
                ImageUrl = "./Images/mop.jpg",
                ReleaseDate = new DateTime(1986, 03, 03)
            };

            AppDataContext.Album.Add(album4);


            var song1 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/0JGuSgtmWyfuxLGBs2wX0C",
                LinkYT = "https://www.youtube.com/embed/0jpOBd949O4",
                Name = "Physical Education"
            };
            AppDataContext.Song.Add(song1);

            var song2 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/7hY2Kc7Hvu0BudOoQwu8Ez",
                LinkYT = "https://www.youtube.com/embed/lbA3jxab4A0",
                Name = "Kascade"
            };
            AppDataContext.Song.Add(song2);

            var song3 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/4j6ascTxs21rACPdPpqFQN",
                LinkYT = "https://www.youtube.com/embed/g68hQ4zJ3t0",
                Name = "The Woven Web"
            };

            AppDataContext.Song.Add(song3);

            var song4 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/1O7oz3f9EuSeeX0J7t5z6J",
                LinkYT = "https://www.youtube.com/embed/NR3xVQy8ccM",
                Name = "Architects"
            };

            AppDataContext.Song.Add(song4);

            var song5 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/5sG3G54H21hNfd5etlheoe",
                LinkYT = "https://www.youtube.com/embed/6nQCxwneUwA",
                Name = "Satellite"
            };
            AppDataContext.Song.Add(song5);

            var song6 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/3nlnq3U8VrxOyp2mjXQAPA",
                LinkYT = "https://www.youtube.com/embed/eT-QlZjVmgI",
                Name = "Wait For Me"
            };
            AppDataContext.Song.Add(song6);

            var song7 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/45m4ag7gCHx3uKnSpOYFSO",
                LinkYT = "https://www.youtube.com/embed/gi4H5gQDuug",
                Name = "Midnight Hands"
            };
            AppDataContext.Song.Add(song7);

            var song8 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/2xbPgQOfICgLYs8P4lkEtx",
                LinkYT = "https://www.youtube.com/embed/8gX2kDsaYg0",
                Name = "Endgame"
            };
            AppDataContext.Song.Add(song8);

            var song9 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/0wHNrrefyaeVewm4NxjxrX",
                LinkYT = "https://www.youtube.com/embed/eT-QlZjVmgI",
                Name = "Wait For Me"
            };
            AppDataContext.Song.Add(song9);

            var song10 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/7KUaVteaQI4YrhV3Gp6px6",
                LinkYT = "https://www.youtube.com/embed/qhj9yQ3QyRo",
                Name = "Unrockbar"
            };
            AppDataContext.Song.Add(song10);

            var song11 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/0GT9OI4Fot0TKzsUsO7SVA",
                LinkYT = "https://www.youtube.com/embed/kRrP-bZvD2s",
                Name = "Deine Schuld"
            };
            AppDataContext.Song.Add(song11);

            var song12 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/2Fgmf2jZzNhCNHbZZLoXur",
                LinkYT = "https://www.youtube.com/embed/8zXuhykupwU",
                Name = "Geisterhaus"
            };
            AppDataContext.Song.Add(song12);

            var song13 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/2J96ewIQ9O95cs5sNY3c1q",
                LinkYT = "https://www.youtube.com/embed/hhMbgu8nYEQ",
                Name = "Ruhig angehn"
            };
            AppDataContext.Song.Add(song13);

            var song14 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/6UB9mShVLbMm0W4e6vud4C",
                LinkYT = "https://www.youtube.com/embed/uzlOcupu5UE",
                Name = "Battery"
            };
            AppDataContext.Song.Add(song14);

            var song15 = new Song
            {
                LinkSptfy = "https://open.spotify.com/embed/track/2HD5BWFthrNf2uFyEhi53d",
                LinkYT = "https://www.youtube.com/embed/z7bUJPj_8v0",
                Name = "Orion"
            };
            AppDataContext.Song.Add(song15);

            var artist = new Artist
            {
                Founded = new DateTime(2007),
                Id = new Guid(),
                ArtistImageUrl = "./Images/aal.jpg",
                Name = "Animals as Leaders"
            };
            AppDataContext.Artist.Add(artist);

            var artist1 = new Artist
            {
                Founded = new DateTime(1999),
                Id = new Guid(),
                ArtistImageUrl = "./Images/RiseAgainst.jpg",
                Name = "Rise Against"
            };
            AppDataContext.Artist.Add(artist1);

            var artist2 = new Artist
            {
                Founded = new DateTime(1982),
                Id = new Guid(),
                ArtistImageUrl = "./Images/DieAerzte.jpg",
                Name = "Die Ärzte"
            };
            AppDataContext.Artist.Add(artist2);

            var artist3 = new Artist
            {
                Founded = new DateTime(1981),
                Id = new Guid(),
                ArtistImageUrl = "./Images/Metallica.jpg",
                Name = "Metallica"
            };
            AppDataContext.Artist.Add(artist3);

            var larsulrich = new Member
            {
                Id = new Guid(),
                From = new DateTime(1981),
            };
            AppDataContext.Member.Add(larsulrich);

            var kirkhammett = new Member
            {
                Id = new Guid(),
                From = new DateTime(1983),
            };
            AppDataContext.Member.Add(kirkhammett);

            var cliffburton = new Member
            {
                Id = new Guid(),
                From = new DateTime(1982),
                To = new DateTime(1986)
            };
            AppDataContext.Member.Add(cliffburton);

            var farinurlaub = new Member
            {
                Id = new Guid(),
                From = new DateTime(1982),
            };
            AppDataContext.Member.Add(farinurlaub);

            var belab = new Member
            {
                Id = new Guid(),
                From = new DateTime(1982),
            };
            AppDataContext.Member.Add(belab);

            var rodrigogonzalez = new Member
            {
                Id = new Guid(),
                From = new DateTime(1993),
            };
            AppDataContext.Member.Add(rodrigogonzalez);

            var chrischasse = new Member
            {
                Id = new Guid(),
                From = new DateTime(2003),
                To = new DateTime(2007)
            };
            AppDataContext.Member.Add(chrischasse);

            var brandonbarnes = new Member
            {
                Id = new Guid(),
                From = new DateTime(2000),
            };
            AppDataContext.Member.Add(brandonbarnes);

            var zachblair = new Member
            {
                Id = new Guid(),
                From = new DateTime(2007),
            };
            AppDataContext.Member.Add(zachblair);

            var tosinabasi = new Member
            {
                Id = new Guid(),
                From = new DateTime(2007),
            };
            AppDataContext.Member.Add(tosinabasi);

            var javierreyes = new Member
            {
                Id = new Guid(),
                From = new DateTime(2007),
            };
            AppDataContext.Member.Add(javierreyes);

            var mattgarstka = new Member
            {
                Id = new Guid(),
                From = new DateTime(2007),
            };
            AppDataContext.Member.Add(mattgarstka);

            var person = new Person
            {
                Id = new Guid(),
                FirstName = "Matt",
                LastName = "Garstka",
                Born = new DateTime(1989, 04, 27),
                ImageUrl = "./Images/MattGarstka.jpg",
            };
            AppDataContext.Person.Add(person);

            var person1 = new Person
            {
                Id = new Guid(),
                FirstName = "Javier",
                LastName = "Reyes",
                ImageUrl = "./Images/JavierReyes.jpg",
            };
            AppDataContext.Person.Add(person1);

            var person2 = new Person
            {
                Id = new Guid(),
                FirstName = "Tosin",
                LastName = "Abasi",
                Born = new DateTime(1989, 04, 27),
                ImageUrl = "./Images/TosinAbasi.jpg",
            };
            AppDataContext.Person.Add(person2);

            var person3 = new Person
            {
                Id = new Guid(),
                FirstName = "Tosin",
                LastName = "Abasi",
                Born = new DateTime(1983, 01, 07),
                ImageUrl = "./Images/TosinAbasi.jpg",
            };
            AppDataContext.Person.Add(person3);

            var person4 = new Person
            {
                Id = new Guid(),
                FirstName = "Zach",
                LastName = "Blair",
                Born = new DateTime(1974, 12, 26),
                ImageUrl = "./Images/ZachBlair.jpg",
            };
            AppDataContext.Person.Add(person4);

            var person5 = new Person
            {
                Id = new Guid(),
                FirstName = "Brandon",
                LastName = "Barnes",
                Born = new DateTime(1974, 12, 26),
                ImageUrl = "./Images/BrandonBarnes.jpg",
            };
            AppDataContext.Person.Add(person5);

            var person6 = new Person
            {
                Id = new Guid(),
                FirstName = "Chris",
                LastName = "Chasse",
                ImageUrl = "./Images/Unknown.jpg",
            };
            AppDataContext.Person.Add(person6);

            var person7 = new Person
            {
                Id = new Guid(),
                FirstName = "Rodrigo",
                LastName = "Gonzalez",
                ImageUrl = "./Images/RodGonzalez.jpg",
                Born = new DateTime(1968, 05, 19)
            };
            AppDataContext.Person.Add(person7);

            var person8 = new Person
            {
                Id = new Guid(),
                FirstName = "Rodrigo",
                LastName = "Gonzalez",
                ImageUrl = "./Images/RodGonzalez.jpg",
                Born = new DateTime(1968, 05, 19)
            };
            AppDataContext.Person.Add(person8);

            var person9 = new Person
            {
                Id = new Guid(),
                FirstName = "Bela",
                LastName = "B",
                ImageUrl = "./Images/BelaB.jpg",
                Born = new DateTime(1962, 12, 14)
            };
            AppDataContext.Person.Add(person9);

            var person10 = new Person
            {
                Id = new Guid(),
                FirstName = "Farin",
                LastName = "Urlaub",
                ImageUrl = "./Images/FarinUrlaub.jpg",
                Born = new DateTime(1963, 10, 27)
            };
            AppDataContext.Person.Add(person10);

            var person11 = new Person
            {
                Id = new Guid(),
                FirstName = "Clifford",
                LastName = "Burton",
                ImageUrl = "./Images/CliffBurton.jpg",
                Born = new DateTime(1962, 02, 10),
                Died = new DateTime(1968, 09, 27)
            };
            AppDataContext.Person.Add(person11);

            var person12 = new Person
            {
                Id = new Guid(),
                FirstName = "Kirk",
                LastName = "Hammett",
                ImageUrl = "./Images/KirkHammett.jpg",
                Born = new DateTime(1962, 11, 18),
            };
            AppDataContext.Person.Add(person12);

            var person13 = new Person
            {
                Id = new Guid(),
                FirstName = "Lars",
                LastName = "Ulrich",
                ImageUrl = "./Images/LarsUlrich.jpg",
                Born = new DateTime(1963, 12, 26),
            };
            AppDataContext.Person.Add(person13);

            var useradm = new User
            {
                Id = new Guid(),
                UserName = "adm",
                Password = "adm123"
            };
            AppDataContext.User.Add(useradm);

            AppDataContext.SaveChanges();
        }*/

    }
}

