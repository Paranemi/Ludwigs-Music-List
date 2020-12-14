using DBConnection1.Data;
using DBConnection1.Models;
using Microsoft.AspNetCore.Components;
using System;

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

        public void WriteData()
        {
            var album1 = new Album
            {
                Name = "The Joy of Motion2",
                ImageUrl = "./Images/jom.jpg",
                ReleaseDate = new DateTime(2014,03,03)
            };

            AppDatacontext.Album.Add(album1);
            AppDatacontext.SaveChanges();
        }
    }
}

