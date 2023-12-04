using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab6.DataBase
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext() : base("name=PokemonDataBase")
        {
        }
        public DbSet<Models.Pokemons> Pokemons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Pokemons>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
