// (c) Johannes Wolfgruber, 2021

using System;
using System.Windows;
using SystemAudioRecordingSoftware.App.Bootstrapping;
using Microsoft.Extensions.DependencyInjection;

namespace SystemAudioRecordingSoftware.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly AppBootstrapper _bootstrapper;

        public App()
        {
            _bootstrapper = AppBootstrapper.Create();
        }
        
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            if (AppBootstrapper.ServiceProvider is null)
            {
                throw new NullReferenceException("ServiceProvider cannot be null");
            }

            var mainWindow = AppBootstrapper.ServiceProvider.GetService<MainWindow>();
            mainWindow?.Show();
        }
    }
}