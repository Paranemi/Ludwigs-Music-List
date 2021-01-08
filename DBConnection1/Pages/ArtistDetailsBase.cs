﻿using DBConnection1.Data;
using DBConnection1.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Pages
{
    public class ArtistDetailsBase
    {
        [Parameter]
        public string ArtistName { get; set; }
        [Parameter]
        public int Founded { get; set; }
        [Parameter]
        public string PersonImageUrl { get; set; }
        [Parameter]
        public string ArtistImageUrl { get; set; }
        [Parameter]
        public string FirstName { get; set; }
        [Parameter]
        public string LastName { get; set; }
        [Parameter]
        public int From { get; set; }
        [Parameter]
        public int To { get; set; }


        [Parameter]
        public int PersonCount { get; set; } = 0;


        [Inject]
        public AppDataContext AppDataContext { get; set; }
        protected List<Artist> artist;
        protected List<Person> persons;

        //protected override void OnInitialized()
        //{
        //    artist = AppDataContext.Artist.Where(b => b.Name.Contains(ArtistName)).ToList();
        //    SetElements();
        //}
        public ArtistDetailsBase()
        {
            artist = AppDataContext.Artist.Where(b => b.Name.Contains(ArtistName)).ToList();
            SetElements();
        }

        private void SetElements()
        {
            foreach (var artistDetails in artist)
            {
                Founded = artistDetails.Founded;
                ArtistImageUrl = artistDetails.ArtistImageUrl;
                persons = artistDetails.Persons.ToList();

            }
            foreach (var personDetails in persons)
            {

            }
        }
    }
}
