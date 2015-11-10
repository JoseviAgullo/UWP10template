// <copyright file="ServiceLocator.cs" company="Josevi Agullo">
//Copyright(c) Josevi Agullo All Rights Reserved
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.
// </copyright>
// <author>Josevi Agullo</author>
// <date>10/11/2015 12:00:00 AM </date>
// <summary></summary>

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
            this.container.RegisterType<AboutViewModel>();
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

        /// <summary>
        /// Gets an instance of <see cref="AboutViewModel"/>
        /// </summary>
        public AboutViewModel AboutViewModel
        {
            get { return this.container.Resolve<AboutViewModel>(); }
        }
    }
}