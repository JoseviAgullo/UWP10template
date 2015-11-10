// <copyright file="NavigationService.cs" company="Josevi Agullo">
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

namespace UWP10template.Services
{
    using System;
    using System.Collections.Generic;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;
    using Windows.UI.Xaml.Media.Animation;
    using Windows.UI.Xaml.Navigation;

    /// <summary>
    /// Service to navigate between views
    /// </summary>
    public class NavigationService
    {
        /// <summary>
        /// Dictionary with configuration
        /// </summary>
        public IDictionary<Type, Type> routingDictionary { get; private set; }

        /// <summary>
        /// Constructor where I get the configuration
        /// </summary>
        public NavigationService()
        {
            var config = new NavigationServiceConfiguration();
            routingDictionary = config.routingDictionary;
        }

        /// <summary>
        /// Navigate to specific page
        /// </summary>
        /// <typeparam name="TDest">Type of destination page</typeparam>
        /// <param name="context">Optional context to share to the page</param>
        public void NavigateTo<TDest>(object context = null)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (context == null)
            {
                rootFrame.Navigate(routingDictionary[typeof(TDest)]);
            }
            else
            {
                rootFrame.Navigate(this.routingDictionary[typeof(TDest)], context);
            }
        }

        public void NavigateBack()
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }
    }
}