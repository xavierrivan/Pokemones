using System.Diagnostics;
using Newtonsoft.Json;
using Pokemones.Models;

namespace Pokemones.Services
{
    public class PokemonServicesBase1
    {
        public async Task<List<PokemonItem>> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=20&offset=20";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            ListPokemons lista_pokemons = JsonConvert.DeserializeObject<ListPokemons>(json);

            Debug.WriteLine("SIII");
            Debug.WriteLine(json);
            return lista_pokemons.results;
        }
    }
}