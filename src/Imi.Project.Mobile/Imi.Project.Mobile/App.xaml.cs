using FreshMvvm;
using Imi.Project.Mobile.Domain.Services;
using Imi.Project.Mobile.Domain.Services.Mocking;
using Imi.Project.Mobile.ViewModels;
using Xamarin.Forms;

namespace Imi.Project.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            FreshIOC.Container.Register<IRecipeService>(new MockRecipeService());

            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

/* TODO: Vragen voor MDE
 *  1) Voor Speech-To-Text heb ik de implementatie volgens het boekje gevolgd, maar ik krijg een "object reference not set to instance of an object"
 *     Daarnaast wordt de knop niet uitgeschakeld op UWP terwijl het nochtans zo gecodeerd staat
 *     
 *  2) Voor online strategie koos ik "Online CRUD operaties met eigen REST API". Nu ben ik niet zeker of dit kan en mag verwezen worden naar de API
 *     van PRI. Zo ja, neem ik aan dat ik dan al de connectie met de API van PRI zal moeten maken?
 *              Zo nee, ben ik niet zeker welke API ik dan wel moet gebruiken. Die van TheMealDB zoals ik in mijn voorstel genoteerd had? Of nog iets anders?
 */
