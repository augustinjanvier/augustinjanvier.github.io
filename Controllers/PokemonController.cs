using MyPokedex;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MyPokedex.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Pokedex()
        {
            return View(GetPokedex());
        }

        public IActionResult Detail(int id)
        {
            return View(GetPokemon(id));
        }

        private List<Pokemon> GetPokedex()
        {
            StreamReader r = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"Data\\pokemons_data.json"));
            string json = r.ReadToEnd();

            List<Pokemon> pokedex = JsonConvert.DeserializeObject<List<Pokemon>>(json);

            return pokedex;
        }

        private Pokemon GetPokemon(int id)
        {
            StreamReader r = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"Data\\pokemons_data.json"));
            string json = r.ReadToEnd();

            List<Pokemon> pokedex = JsonConvert.DeserializeObject<List<Pokemon>>(json);

            Pokemon pokemon = pokedex.Find(p => p.id == id);

            return pokemon;
        }

    }
}
