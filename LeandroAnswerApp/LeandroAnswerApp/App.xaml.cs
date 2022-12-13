using LeandroAnswerApp.Services;
using LeandroAnswerApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LeandroAnswerApp.Views;

namespace LeandroAnswerApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new Ask());
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
