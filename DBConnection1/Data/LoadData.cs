﻿using DBConnection1.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Linq;

namespace DBConnection1.Data
{
    public class LoadData
    {
        [Inject]
        public AppDataContext Db { get; set; }

        public void LoadSampleData()
        {
            if (Db.Album.Count() == 0)
            {
                SampleData();
            }
        }

        private void SampleData()
        {
            var album1 = new Album
            {
                Name = "The Joy of Motion",
                ImageUrl = "jom",
                ReleaseDate = new DateTime(2014, 03, 03)
            };

            Db.Album.Add(album1);

            var album2 = new Album
            {
                Name = "Endgame",
                ImageUrl = "endgame",
                ReleaseDate = new DateTime(2011, 03, 11)
            };

            Db.Album.Add(album2);

            var album3 = new Album
            {
                Name = "Geräusche",
                ImageUrl = "grsch",
                ReleaseDate = new DateTime(2003, 09, 29)
            };

            Db.Album.Add(album3);

            var album4 = new Album
            {
                Name = "Master of Puppets",
                ImageUrl = "mop",
                ReleaseDate = new DateTime(1986, 03, 03)
            };

            Db.Album.Add(album4);

            var animalsasleaders = new Artist
            {
                Founded = 2007,
                ArtistImageUrl = "aal",
                Name = "Animals as Leaders"
            };
            Db.Artist.Add(animalsasleaders);

            var riseagainst = new Artist
            {
                Founded = 1999,
                ArtistImageUrl = "RiseAgainst",
                Name = "Rise Against"
            };
            Db.Artist.Add(riseagainst);

            var dieaerzte = new Artist
            {
                Founded = 1982,
                ArtistImageUrl = "DieAerzte",
                Name = "Die Ärzte"
            };
            Db.Artist.Add(dieaerzte);

            var metallica = new Artist
            {
                Founded = 1981,
                ArtistImageUrl = "Metallica",
                Name = "Metallica"
            };
            Db.Artist.Add(metallica);

            var song1 = new Song
            {
                Artist = animalsasleaders,
                Album = album1,
                LinkSptfy = "0JGuSgtmWyfuxLGBs2wX0C",
                LinkYT = "0jpOBd949O4",
                Name = "Physical Education"
            };
            Db.Song.Add(song1);

            var song2 = new Song
            {
                Artist = animalsasleaders,
                Album = album1,
                LinkSptfy = "7hY2Kc7Hvu0BudOoQwu8Ez",
                LinkYT = "lbA3jxab4A0",
                Name = "Kascade"
            };
            Db.Song.Add(song2);

            var song3 = new Song
            {
                Artist = animalsasleaders,
                Album = album1,
                LinkSptfy = "4j6ascTxs21rACPdPpqFQN",
                LinkYT = "g68hQ4zJ3t0",
                Name = "The Woven Web"
            };

            Db.Song.Add(song3);

            var song4 = new Song
            {
                Artist = riseagainst,
                Album = album2,
                LinkSptfy = "1O7oz3f9EuSeeX0J7t5z6J",
                LinkYT = "NR3xVQy8ccM",
                Name = "Architects"
            };

            Db.Song.Add(song4);

            var song5 = new Song
            {
                Artist = riseagainst,
                Album = album2,
                LinkSptfy = "5sG3G54H21hNfd5etlheoe",
                LinkYT = "6nQCxwneUwA",
                Name = "Satellite"
            };
            Db.Song.Add(song5);

            var song6 = new Song
            {
                Artist = riseagainst,
                Album = album2,
                LinkSptfy = "3nlnq3U8VrxOyp2mjXQAPA",
                LinkYT = "eT-QlZjVmgI",
                Name = "Wait For Me"
            };
            Db.Song.Add(song6);

            var song7 = new Song
            {
                Artist = riseagainst,
                Album = album2,
                LinkSptfy = "45m4ag7gCHx3uKnSpOYFSO",
                LinkYT = "gi4H5gQDuug",
                Name = "Midnight Hands"
            };
            Db.Song.Add(song7);

            var song8 = new Song
            {
                Artist = riseagainst,
                Album = album2,
                LinkSptfy = "2xbPgQOfICgLYs8P4lkEtx",
                LinkYT = "8gX2kDsaYg0",
                Name = "Endgame"
            };
            Db.Song.Add(song8);

            var song10 = new Song
            {
                Artist = dieaerzte,
                Album = album3,
                LinkSptfy = "7KUaVteaQI4YrhV3Gp6px6",
                LinkYT = "qhj9yQ3QyRo",
                Name = "Unrockbar"
            };
            Db.Song.Add(song10);

            var song11 = new Song
            {
                Artist = dieaerzte,
                Album = album3,
                LinkSptfy = "0GT9OI4Fot0TKzsUsO7SVA",
                LinkYT = "kRrP-bZvD2s",
                Name = "Deine Schuld"
            };
            Db.Song.Add(song11);

            var song12 = new Song
            {
                Artist = dieaerzte,
                Album = album3,
                LinkSptfy = "2Fgmf2jZzNhCNHbZZLoXur",
                LinkYT = "8zXuhykupwU",
                Name = "Geisterhaus"
            };
            Db.Song.Add(song12);

            var song13 = new Song
            {
                Artist = dieaerzte,
                Album = album3,
                LinkSptfy = "2J96ewIQ9O95cs5sNY3c1q",
                LinkYT = "hhMbgu8nYEQ",
                Name = "Ruhig angehn"
            };
            Db.Song.Add(song13);

            var song14 = new Song
            {
                Artist = metallica,
                Album = album4,
                LinkSptfy = "6UB9mShVLbMm0W4e6vud4C",
                LinkYT = "uzlOcupu5UE",
                Name = "Battery"
            };
            Db.Song.Add(song14);

            var song15 = new Song
            {
                Artist = metallica,
                Album = album4,
                LinkSptfy = "2HD5BWFthrNf2uFyEhi53d",
                LinkYT = "z7bUJPj_8v0",
                Name = "Orion"
            };
            Db.Song.Add(song15);

            var person = new Person
            {
                Artist = animalsasleaders,
                From = 2007,
                FirstName = "Matt",
                LastName = "Garstka",
                Born = new DateTime(1989, 04, 27),
                ImageUrl = "MattGarstka",
            };
            Db.Person.Add(person);

            var person1 = new Person
            {
                Artist = animalsasleaders,
                From = 2000,
                FirstName = "Javier",
                LastName = "Reyes",
                ImageUrl = "JavierReyes",
            };
            Db.Person.Add(person1);

            var person3 = new Person
            {
                Artist = animalsasleaders,
                From = 2007,
                FirstName = "Tosin",
                LastName = "Abasi",
                Born = new DateTime(1983, 01, 07),
                ImageUrl = "TosinAbasi",
            };
            Db.Person.Add(person3);

            var person4 = new Person
            {
                Artist = riseagainst,
                From = 2007,
                FirstName = "Zach",
                LastName = "Blair",
                Born = new DateTime(1974, 12, 26),
                ImageUrl = "ZachBlair",
            };
            Db.Person.Add(person4);

            var person5 = new Person
            {
                Artist = riseagainst,
                From = 2000,
                FirstName = "Brandon",
                LastName = "Barnes",
                Born = new DateTime(1974, 12, 26),
                ImageUrl = "BrandonBarnes",
            };
            Db.Person.Add(person5);

            var person6 = new Person
            {
                Artist = riseagainst,
                From = 2003,
                To = 2007,
                FirstName = "Chris",
                LastName = "Chasse",
                ImageUrl = "Unknown",
            };
            Db.Person.Add(person6);


            var person8 = new Person
            {
                Artist = dieaerzte,
                From = 1993,
                FirstName = "Rodrigo",
                LastName = "Gonzalez",
                ImageUrl = "RodGonzalez",
                Born = new DateTime(1968, 05, 19)
            };
            Db.Person.Add(person8);

            var person9 = new Person
            {
                Artist = dieaerzte,
                From = 1982,
                FirstName = "Bela",
                LastName = "B",
                ImageUrl = "BelaB",
                Born = new DateTime(1962, 12, 14)
            };
            Db.Person.Add(person9);

            var person10 = new Person
            {
                Artist = dieaerzte,
                From = 1982,
                FirstName = "Farin",
                LastName = "Urlaub",
                ImageUrl = "FarinUrlaub",
                Born = new DateTime(1963, 10, 27)
            };
            Db.Person.Add(person10);

            var person11 = new Person
            {
                Artist = metallica,
                From = 1982,
                To = 1986,
                FirstName = "Clifford",
                LastName = "Burton",
                ImageUrl = "CliffBurton",
                Born = new DateTime(1962, 02, 10),
                Died = new DateTime(1968, 09, 27)
            };
            Db.Person.Add(person11);

            var person12 = new Person
            {
                Artist = metallica,
                From = 1983,
                FirstName = "Kirk",
                LastName = "Hammett",
                ImageUrl = "KirkHammett",
                Born = new DateTime(1962, 11, 18),
            };
            Db.Person.Add(person12);

            var person13 = new Person
            {
                Artist = metallica,
                From = 1981,
                FirstName = "Lars",
                LastName = "Ulrich",
                ImageUrl = "LarsUlrich",
                Born = new DateTime(1963, 12, 26),
            };
            Db.Person.Add(person13);

            var useradm = new User
            {
                UserName = "adm",
                Password = "adm123"
            };
            Db.User.Add(useradm);

            Db.SaveChanges();
        }
    }
}
