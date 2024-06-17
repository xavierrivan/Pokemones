﻿using Pokemones.Services;

namespace Pokemones
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            CargarData();
        }

        public async void CargarData()
        {
            PokemonServices poke_services = new PokemonServices();
            var listado_pokemones = await poke_services.DevuelveListadoPokemones();

            ListaPokemones.ItemsSource = listado_pokemones;
        
        }
    }

}
