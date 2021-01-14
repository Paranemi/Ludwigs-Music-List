using Microsoft.AspNetCore.Components;
using System;
using DBConnection1.Data;
using DBConnection1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Controls
{
    public class ArtistDataInputBase : ComponentBase
    {
        [Parameter]
        public string ArtistName { get; set; }
        protected string Founded { get; set; }
        protected string Cover { get; set; }

        [Inject]
        public AppDataContext Db { get; set; }

        [Parameter]
        public bool Visible { get; set; } = false;

        public void HideWindow()
        {
            Visible = false;
        }


        //exception und rückmeldung dass erfolgreich!!
        public void AddArtist()
        {
            Visible = false;
            var artist = Db.Artist.FirstOrDefault(item => item.Name == ArtistName);

            artist.ArtistImageUrl = Cover;
            artist.Founded = int.Parse(Founded);  
            
            Db.Artist.Update(artist);
            Db.SaveChanges();
        }

        protected void ArtistNameValueChanged(string Value)
        {
            ArtistName = Value;
        }
        protected void CoverValueChanged(string Value)
        {
            Cover = Value;
        }
        protected void ReleaseDateValueChanged(string Value)
        {
            Founded = Value;
        }
    }
}
