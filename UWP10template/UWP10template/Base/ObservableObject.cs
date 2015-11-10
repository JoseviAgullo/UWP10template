// <copyright file="ObservableObject.cs" company="Josevi Agullo">
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
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// This event notifies if the property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Set new value to a property
        /// </summary>
        /// <typeparam name="T">Value type</typeparam>
        /// <param name="where">Field to store value</param>
        /// <param name="value">Value of the property</param>
        /// <param name="propertyName">C#5 is the property name</param>
        public void Set<T>(ref T where, T value, [CallerMemberName] string propertyName = null)
        {
            where = value;
            this.OnPropertyChanged(propertyName);
        }

        /// <summary>
        /// Notifies to suscribers that the property changed
        /// </summary>
        /// <param name="propertyName">Name of the property</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = this.PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
