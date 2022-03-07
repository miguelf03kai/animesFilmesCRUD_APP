using Microsoft.EntityFrameworkCore;

namespace animesFilmesCRUD_APP.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Anime> Animes {get;set;}
        public DbSet<Genre> Genres {get;set;}
        public DbSet<Film> Films {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
            optionBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=animesFilmsCRUD_APP;Integrated Security=True");
        }
    }
}