using Microsoft.AspNetCore.Components;
using MusicListWorkflow.Contracts;
using System.Linq;

namespace BlazorServerSide.Controls
{
    public class ArtistDataInputBase : ComponentBase
    {
        [Parameter]
        public string ArtistName { get; set; }
        protected string Founded { get; set; }
        protected string Cover { get; set; }

        [Parameter]
        public bool Visible { get; set; } = false;

        [Inject]
        public IArtistWorkflow ArtistWorkflow { get; set; }

        public void HideWindow()
        {
            Visible = false;
        }


        //exception und rückmeldung dass erfolgreich!!
        public void AddArtist()
        {
            Visible = false;

            var artist = ArtistWorkflow.GetArtistByName(ArtistName);
            artist.ArtistImageUrl = Cover;
            artist.Founded = int.Parse(Founded);

            ArtistWorkflow.UpdateArtist(artist);

           
        }

        protected void ArtistNameValueChanged(string Value)
        {
            ArtistName = Value;
        }
        protected void ClickHandler(string Value)
        {
            Cover = Value;
        }
        protected void ReleaseDateValueChanged(string Value)
        {
            Founded = Value;
        }
    }
}
