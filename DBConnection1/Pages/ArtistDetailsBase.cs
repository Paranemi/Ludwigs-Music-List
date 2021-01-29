﻿using Microsoft.AspNetCore.Components;
using MusicListWorkflow;
using MusicListWorkflow.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using ViewModels;
using ViewModels.Contracts;

namespace BlazorServerSide.Pages
{
    public class ArtistDetailsBase : ComponentBase
    {
        [Parameter]
        public string ArtistName { get; set; }
        [Parameter]
        public int Founded { get; set; }
        [Parameter]
        public string ArtistImageUrl { get; set; }
        [Parameter]
        public string PersonImageUrl { get; set; }
        [Parameter]
        public string FirstName { get; set; }
        [Parameter]
        public string LastName { get; set; }
        [Parameter]
        public int From { get; set; }
        [Parameter]
        public int To { get; set; }

        [Inject]
        public IArtistWorkflow ArtistWorkflow { get; set; }
        [Inject]
        public IPersonWorkflow PersonWorkflow { get; set; }
        protected bool ArtistInput { get; set; } = false;
        protected bool PersonInput { get; set; } = false;

     //   protected List<IArtistViewModel> artist;
        protected List<IPersonViewModel> persons;

        protected override void OnInitialized()
        {
            //  artist.Add(ArtistWorkflow.GetArtistByName(ArtistName));
            var artist = ArtistWorkflow.GetArtistByName(ArtistName);
            Founded = artist.Founded;
            ArtistImageUrl = artist.ArtistImageUrl;

            var person = PersonWorkflow.GetPersonByArtistId(artist.ArtistId);
            PersonImageUrl = person.ImageUrl;
            FirstName = person.FirstName;
            LastName = person.LastName;
            From = person.From;
            To = person.To;

        }

        private void SetElements()
        {

            //foreach (var artistDetails in artist)
            //{
            //    Founded = artistDetails.Founded;
            //    ArtistImageUrl = artistDetails.ArtistImageUrl;
            //}
        }
    }
}
