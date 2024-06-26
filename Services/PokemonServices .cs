﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pokemones.Models;

namespace Pokemones.Services
{
    public class PokemonServices

    {
        public async Task<List<PokemonItem>> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=20&Soffset=20";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            ListPokemons lista_pokemons = JsonConvert.DeserializeObject<ListPokemons>(json);

            Debug.WriteLine("SIII");
            Debug.WriteLine(json);
            return lista_pokemons.results;
        }
    }
}
