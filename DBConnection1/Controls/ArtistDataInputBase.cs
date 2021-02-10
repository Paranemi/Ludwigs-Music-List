using BlazorServerSide.Shared;
using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using System.Linq;

namespace BlazorServerSide.Controls
{
    public class ArtistDataInputBase : ComponentBase
    {
        [Parameter]
        public string ArtistName { get; set; }
        //protected string Founded { get; set; }
        //protected string Cover { get; set; }

        protected Validation Artist { get; set; } = new Validation();

        [Parameter]
        public bool Visible { get; set; } = false;

        [Inject]
        public NavigationManager UriHelper { get; set; }
        [Inject]
        public IArtistWorkflow ArtistWorkflow { get; set; }

        public void HideWindow()
        {
            Visible = false;
        }


        public void AddArtist()
        {
            if(!string.IsNullOrEmpty(Artist.Founded) && !string.IsNullOrEmpty(Artist.ArtistImageUrl))
            {
                Visible = false;

                var artist = ArtistWorkflow.GetArtistByName(ArtistName);

                artist.ArtistImageUrl = Artist.ArtistImageUrl;
                artist.Founded = int.Parse(Artist.Founded);

                ArtistWorkflow.UpdateArtist(artist);

                UriHelper.NavigateTo(UriHelper.Uri, forceLoad: true);
            }

        }

        protected void ClickHandler(string Value)
        {
            Artist.ArtistImageUrl = Value;
        }
        protected void ReleaseDateValueChanged(string Value)
        {
            Artist.Founded = Value;
        }
    }
}
