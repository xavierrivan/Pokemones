using Pokemones.Services;

namespace Pokemones
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void CardarData()
        {
            PokemonServices poke_Services = PokemonServices();
            var listado_pokemones = poke_Services.DevuelveListadoPokemones();

            ListaPokemones.ItemsSource = listado_pokemones.Result;
        
        }
    }

}
