namespace UWP10template.Base
{
    using Microsoft.Practices.Unity;
    using UWP10template.Services;
    using UWP10template.ViewModels;
    public class ServiceLocator
    {
        /// <summary>
        /// Unity container
        /// </summary>
        private UnityContainer container = new UnityContainer();

        /// <summary>
        /// Register all Services an ViewModels <see cref="ServiceLocator"/>
        /// </summary>
        public ServiceLocator()
        {
            // Services
            this.container.RegisterType<NavigationService>();

            // ViewModels
            this.container.RegisterType<ShellViewModel>();
            this.container.RegisterType<MainViewModel>();
        }

        /// <summary>
        /// Gets an instance of <see cref="ShellViewModel"/>
        /// </summary>
        public ShellViewModel ShellViewModel
        {
            get { return this.container.Resolve<ShellViewModel>(); }
        }

        /// <summary>
        /// Gets an instance of <see cref="MainViewModel"/>
        /// </summary>
        public MainViewModel MainViewModel
        {
            get { return this.container.Resolve<MainViewModel>(); }
        }
    }
}