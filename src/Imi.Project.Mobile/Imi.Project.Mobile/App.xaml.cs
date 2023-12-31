﻿using FreshMvvm;
using Imi.Project.Mobile.Domain.Services;
using Imi.Project.Mobile.Domain.Services.Api;
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

            FreshIOC.Container.Register<IRecipeService, ApiRecipesService>().AsSingleton();
            FreshIOC.Container.Register<IRecipeService>(new MockRecipeService());
            FreshIOC.Container.Register<IUserService>(new MockUserService());
            FreshIOC.Container.Register<IWebApiClient, WebApiClient>().AsSingleton();

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