namespace Imi.Project.Shared.Models.RecipeModels
{
    public class RecipeItemViewModel : BaseViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        //TODO Add list of recipes
    }
}