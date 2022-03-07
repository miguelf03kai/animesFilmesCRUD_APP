using System.ComponentModel.DataAnnotations;

namespace animesFilmesCRUD_APP.Models
{
    public class Film
    {
        public int Id { get; set; }
        [Required]
		public string Title { get; set; }
        [Display(Name = "Cover")]
        public string LinkCover { get; set; }
		public string Synopsis { get; set; }
        [Display(Name = "Release Year")]
		public int ReleaseYear { get; set; }
        public int? GenreId { get; set;}
        [Display(Name = "Genre")]
        public Genre genre {get; set;}
    }
}