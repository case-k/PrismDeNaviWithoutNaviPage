﻿using Prism.Unity;
using PrismDeNaviWithoutNaviPage.Views;

namespace PrismDeNaviWithoutNaviPage
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<SubPage>();
        }
    }
}
