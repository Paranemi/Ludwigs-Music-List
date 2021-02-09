using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSide.Shared
{
    public class Validation
    {

        //User
        [Required(ErrorMessage = "user name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "security answer is required")]
        public string SecurityAnswer { get; set; }

        //Song
        [Required(ErrorMessage = "song name is required")]
        public string SongName { get; set; }

        [Required(ErrorMessage = "spotify link is required")]
        public string LinkSptfy { get; set; }

        [Required(ErrorMessage = "youtube link is required")]
        public string LinkYT { get; set; }

        //Person
        [Required(ErrorMessage = "first name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "born date is required")]
        public DateTime Born { get; set; }

        //Artist
        [Required(ErrorMessage = "artist name is required")]
        public string ArtistName { get; set; }

        [Required(ErrorMessage = "artist image is required")]
        public string ArtistImageUrl { get; set; }

        [Required(ErrorMessage = "founding is required")]
        public int Founded { get; set; }

        //Album
        [Required(ErrorMessage = "album name is required")]
        public string AlbumName { get; set; }

        [Required(ErrorMessage = "album image is required")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "realease date is required")]
        public DateTime ReleaseDate { get; set; }
    }
}
