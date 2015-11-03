namespace UWP10template.Services
{
    using System;
    using System.Collections.Generic;
    using UWP10template.ViewModels;
    using UWP10template.Views;

    /// <summary>
    /// Configuration two connect ViewModels with Views
    /// </summary>
    public class NavigationServiceConfiguration
    {
        /// <summary>
        /// Dictionary for this configuration
        /// </summary>
        public IDictionary<Type, Type> routingDictionary = new Dictionary<Type, Type>()
        {
            { typeof(ShellViewModel), typeof(Shell) },
            { typeof(MainViewModel), typeof(MainPage) },
            { typeof(AboutViewModel), typeof(AboutPage) },
        };
    }
}
