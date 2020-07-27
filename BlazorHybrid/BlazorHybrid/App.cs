using Microsoft.Extensions.DependencyInjection;
using Microsoft.MobileBlazorBindings;
using Microsoft.MobileBlazorBindings.WebView;
using Xamarin.Forms;

namespace BlazorHybrid
{
    public class App : Application
    {
        public App()
        {
            BlazorHybridHost.AddResourceAssembly(typeof(App).Assembly, contentRoot: "WebUI/wwwroot");

            var host = MobileBlazorBindingsHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddBlazorHybrid();
                    services.AddSingleton<BlazorLib.State.CounterState>();
                })
                .Build();

            MainPage = new ContentPage { Title = "My Application" };
            host.AddComponent<Main>(parent: MainPage);
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
