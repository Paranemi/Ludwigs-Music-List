using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels;

namespace BlazorServerSide.Controls
{
    public class PersonDataInputBase : ComponentBase
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string ImageUrl { get; set; }
        protected string From { get; set; }
        protected string To { get; set; }
        protected string Born { get; set; }
        protected string Died { get; set; }
        [Parameter]
        public string ArtistName { get; set; }
        

        [Parameter]
        public bool Visible { get; set; } = false;

        [Inject]
        public NavigationManager UriHelper { get; set; }
        [Inject]
        public IArtistWorkflow ArtistWorkflow { get; set; }
        [Inject]
        public IPersonWorkflow PersonWorkflow { get; set; }

        public void HideWindow()
        {
            Visible = false;
        }

        public void AddPerson()
        {
            Visible = false;

            if (string.IsNullOrEmpty(To))
            {
                To = "0";
            }
            if (string.IsNullOrEmpty(Died))
            {
                Died = "0001.01.01";
            }

            var person = new PersonViewModel()
            {
                FirstName = FirstName,
                LastName = LastName,
                ImageUrl = ImageUrl,
                From = int.Parse(From),
                To = int.Parse(To),
                Born = DateTime.Parse(Born),
                Died = DateTime.Parse(Died),
                Artist = ArtistWorkflow.GetArtistByName(ArtistName)
            };
            PersonWorkflow.CreatePerson(person, ArtistWorkflow.GetArtistIdByName(ArtistName));

            UriHelper.NavigateTo(UriHelper.Uri, true);
        }
 
        protected void ClickHandler(string Value)
        {
            ImageUrl = Value;
        }
        protected void FirstNameValueChanged(string Value)
        {
            FirstName = Value;
        }
        protected void LastNameValueChanged(string Value)
        {
            LastName = Value;
        }
        protected void FromValueChanged(string Value)
        {
            From = Value;
        }
        protected void ToValueChanged(string Value)
        {
            To = Value;            
        }
        protected void BornValueChanged(string Value)
        {
            Born = Value;
        }
        protected void DiedValueChanged(string Value)
        {
            Died = Value;
        }

    }
}
