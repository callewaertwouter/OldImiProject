using FreshMvvm;
using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.ViewModels
{
    class RecipesExternalViewModel : FreshBasePageModel
    {
        public ObservableCollection<TheMealDbRecipe> Recipes { get; set; } = new ObservableCollection<TheMealDbRecipe>();

        public async Task LoadRecipesAsync()
        {
            try
            {
                string apiUrl = "https://www.themealdb.com/api/json/v1/1/search.php?s=";

                using (HttpClient client = new HttpClient())
                {
                    string response = await client.GetStringAsync(apiUrl);
                    var result = JsonConvert.DeserializeObject<RecipeApiResponse>(response);

                    Recipes.Clear();
                    foreach (var recipe in result.Meals)
                    {
                        Recipes.Add(recipe);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
