using MyPokedex;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using MyPokedex.Models;

namespace MyPokedex.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Pokedex()
        {
            return View(GetPokedex());
        }

        public IActionResult PokemonCards()
        {
            return View(GetBaseSet());
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

        private List<PokemonCard> GetBaseSet()
        {
            StreamReader r = new StreamReader(Path.Combine(Environment.CurrentDirectory, @"Data\\baseset.json"));
            string json = r.ReadToEnd();

            List<PokemonCard> baseset = JsonConvert.DeserializeObject<List<PokemonCard>>(json);

            return baseset;
        }

    }
}
