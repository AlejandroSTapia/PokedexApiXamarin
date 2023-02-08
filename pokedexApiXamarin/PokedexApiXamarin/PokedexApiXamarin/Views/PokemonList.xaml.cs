using Newtonsoft.Json;
using PokedexApiXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokedexApiXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokemonList : ContentPage
    {
        public string Url;
        public string Next;
        public string Previous;
        public PokemonList()
        {
            InitializeComponent();
            Url = " https://pokeapi.co/api/v2/pokemon/";
            _ = GetPokemon(Url);
        }

        //Metod para peticion a la url que nos dev un bool
        public async Task<bool> GetPokemon(string pokeUrlS)
        {
            HttpClient http = new HttpClient();
            //getasync traera la url en la variable response
            var response = await http.GetAsync(pokeUrlS);
            //de response vamos a recibir el contenido
            if (response.IsSuccessStatusCode)
            {
                //contenido http serializado en un string
                var respString = await response.Content.ReadAsStringAsync();
                //Cachar lista de elemntos deserializados de la clase
                var json_S = JsonConvert.DeserializeObject<PokemonApiModel>(respString);

            }
            return true;
        }
    }
}