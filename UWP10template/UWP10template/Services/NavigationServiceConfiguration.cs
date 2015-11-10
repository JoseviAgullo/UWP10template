// <copyright file="NavigationServiceConfiguration.cs" company="Josevi Agullo">
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
