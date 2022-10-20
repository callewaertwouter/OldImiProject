namespace Imi.Project.Shared.Models.RecipeModels
{
    public class RecipeSearchViewModel : BaseViewModel
    {
        public string SearchText { get; set; }

        public List<RecipeItemViewModel> Recipes { get; set; }
    }
}