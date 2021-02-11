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
        [StringLength(15, ErrorMessage = "user name is too long.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "password is required")]
        [StringLength(40, ErrorMessage = "password is too long.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "security answer is required")]
        [StringLength(20, ErrorMessage = "name is too long.")]
        public string SecurityAnswer { get; set; }

        //Song
        [Required(ErrorMessage = "song name is required")]
        [StringLength(30, ErrorMessage = "song name is too long.")]
        public string SongName { get; set; }

        [Required(ErrorMessage = "spotify link is required")]
        [Url(ErrorMessage = "input is not a link")]
        public string LinkSptfy { get; set; }

        [Required(ErrorMessage = "youtube link is required")]
        [Url(ErrorMessage = "input is not a link")]
        public string LinkYT { get; set; }

        //Person
        [Required(ErrorMessage = "first name is required")]
        [StringLength(20, ErrorMessage = "first name is too long.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "last name is required")]
        [StringLength(20, ErrorMessage = "last name is too long.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "birth date is required")]
        [Range(typeof(DateTime), "1/1/1760", "1/1/2020",
        ErrorMessage = "value must be between 01.01.1760 and 01.01.2020")]
        public string Born { get; set; }

        [Required(ErrorMessage = "field is required")]
        public string From { get; set; }

        //Artist
        [Required(ErrorMessage = "artist name is required")]
        [StringLength(50, ErrorMessage = "artist name is too long.")]
        public string ArtistName { get; set; }

        [Required(ErrorMessage = "artist image is empty")]
        public string ArtistImageUrl { get; set; }

        [Required(ErrorMessage = "field founding date is empty")]
        [Range(1860, 2021,
        ErrorMessage = "Value must be between {1} and {2}.")]
        public string Founded { get; set; }

        //Album
        [Required(ErrorMessage = "album name is required")]
        [StringLength(50, ErrorMessage = "album name is too long.")]
        public string AlbumName { get; set; }

        [Required(ErrorMessage = "album image is required")]
        public string AlbumImageUrl { get; set; }

        [Required(ErrorMessage = "realease date is required")]
        [Range(typeof(DateTime), "1/1/1760", "1/1/2020",
        ErrorMessage = "value must be between 01.01.1760 and 01.01.2022")]
        public string ReleaseDate { get; set; }
    }
}
