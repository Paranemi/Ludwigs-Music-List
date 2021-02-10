using BlazorServerSide.Shared;
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
        //protected string FirstName { get; set; }
        //protected string LastName { get; set; }
        protected string ImageUrl { get; set; }
        //protected string From { get; set; }
        protected string To { get; set; }
        //protected string Born { get; set; }
        protected string Died { get; set; }
        [Parameter]
        public string ArtistName { get; set; }

        protected Validation Person { get; set; } = new Validation();

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
           
            if(!string.IsNullOrEmpty(Person.FirstName) && !string.IsNullOrEmpty(Person.LastName) && !string.IsNullOrEmpty(Person.From) && !string.IsNullOrEmpty(Person.Born))
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

                if (string.IsNullOrEmpty(ImageUrl))
                {
                    ImageUrl = "Unknown.jpg";
                }

                var person = new PersonViewModel()
                {
                    FirstName = Person.FirstName,
                    LastName = Person.LastName,
                    ImageUrl = ImageUrl,
                    From = int.Parse(Person.From),
                    To = int.Parse(To),
                    Born = DateTime.Parse(Person.Born),
                    Died = DateTime.Parse(Died),
                    Artist = ArtistWorkflow.GetArtistByName(ArtistName)
                };
                PersonWorkflow.CreatePerson(person, ArtistWorkflow.GetArtistIdByName(ArtistName));

                UriHelper.NavigateTo(UriHelper.Uri, true);
            }

            
        }
 
        protected void ClickHandler(string Value)
        {
            ImageUrl = Value;
        }
        protected void FirstNameValueChanged(string Value)
        {
            Person.FirstName = Value;
        }
        protected void LastNameValueChanged(string Value)
        {
            Person.LastName = Value;
        }
        protected void FromValueChanged(string Value)
        {
            Person.From = Value;
        }
        protected void ToValueChanged(string Value)
        {
            To = Value;            
        }
        protected void BornValueChanged(string Value)
        {
            Person.Born = Value;
        }
        protected void DiedValueChanged(string Value)
        {
            Died = Value;
        }

    }
}
