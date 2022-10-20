using Imi.Project.Api.Core.Services.Interfaces;
using Imi.Project.Api.Core.Services.Models.RecipeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Imi.Project.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IRecipeService _recipeService;

        public MainWindow(IRecipeService recipeService)
        {
            _recipeService = recipeService;

            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowErrorMessages(ViewRecipesResult result)
        {
            StringBuilder errorMessages = new StringBuilder();

            foreach (var error in result.ValidationResults)
            {
                errorMessages.Append(error.ErrorMessage);
            }

            lblFeedback.Content = errorMessages;
            lblFeedback.Background = Brushes.OrangeRed;
        }
    }
}
