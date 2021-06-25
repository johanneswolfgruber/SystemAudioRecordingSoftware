// (c) Johannes Wolfgruber, 2021

using Microsoft.Extensions.DependencyInjection;
using MvvmGen.Events;
using SystemAudioRecordingSoftware.Presentation.MainContent;

namespace SystemAudioRecordingSoftware.App.Bootstrapping
{
    public class AppBootstrapper
    {
        public static ServiceProvider? ServiceProvider { get; private set; }
        
        private AppBootstrapper()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IEventAggregator, EventAggregator>();
            serviceCollection.AddTransient<MainWindow>();
            serviceCollection.AddTransient<MainContentView>();
            serviceCollection.AddTransient<MainContentViewModel>();

            ServiceProvider = serviceCollection.BuildServiceProvider(true);
        }

        public static AppBootstrapper Create() => new();
    }
}