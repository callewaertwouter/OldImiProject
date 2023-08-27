using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Diagnostics;
using FreshMvvm;
using Imi.Project.Mobile.Domain.Services.Api;
using System.Net.Http;

namespace Imi.Project.Mobile.ViewModels
{
	public class RecipesExternalViewModel : FreshBasePageModel, INotifyPropertyChanged
	{
		private ObservableCollection<TheMealDbRecipe> recipes;
		public ObservableCollection<TheMealDbRecipe> Recipes
		{
			get { return recipes; }
			set
			{
				recipes = value;
				OnPropertyChanged(nameof(Recipes));
				OnPropertyChanged(nameof(LoadedRecipesCount));
			}
		}

		public int LoadedRecipesCount
		{
			get { return Recipes?.Count ?? 0; }
		}

		public async Task LoadRecipesAsync()
		{
			try
			{
				var httpClient = new HttpClient();
				var response = await httpClient.GetStringAsync("https://www.themealdb.com/api/json/v1/1/search.php?s=a");

				var apiResponse = JsonConvert.DeserializeObject<RecipeApiResponse>(response);

				if (apiResponse?.Meals != null)
				{
					Recipes = new ObservableCollection<TheMealDbRecipe>(apiResponse.Meals);
				}
				else
				{
					Debug.WriteLine("No recipes found.");
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine($"Error loading recipes: {ex.Message}");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
