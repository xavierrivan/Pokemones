using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pokemones.Models;

namespace Pokemones.Services
{
    public class PokemonServices
    {
        public async List<PokemonItem> DevuelveListadoPokemones(JsonConvert jsonConvert)
        {
            string url = "https://pokeapi.co/api/v2/ability/?limit=20&offset=20";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            ListPokemons lista_pokemons = JsonConvert.DeserializeObject<ListPokemons>(json);

            return lista_pokemons.results;
        }
    }
}
