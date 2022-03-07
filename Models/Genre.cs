using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace animesFilmesCRUD_APP.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }

        public List<Anime> Animes { get; set; }
    }
}