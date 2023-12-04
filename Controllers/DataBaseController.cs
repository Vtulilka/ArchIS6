using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Controllers
{
    public class DataBaseController
    {
        public void Insert(Models.Pokemons pokemons)
        {
            using (DataBase.PokemonDbContext db = new DataBase.PokemonDbContext())
            {
                db.Pokemons.Add(pokemons);
                db.SaveChanges();
            }
        }

        public List<Models.Pokemons> SelectAll()
        {
            List<Models.Pokemons> pokemons1;
            using (DataBase.PokemonDbContext db = new DataBase.PokemonDbContext())
            {
                pokemons1 = db.Pokemons.ToList();
            }
            return pokemons1;
        }

    }
}
