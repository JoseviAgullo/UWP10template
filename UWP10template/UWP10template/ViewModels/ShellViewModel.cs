using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using UWP10template.Models;
using UWP10template.Services;
using UWP10template.Views;

namespace UWP10template.ViewModels
{
    public class ShellViewModel : ObservableObject
    {
        private static ObservableCollection<MenuItem> menu = new ObservableCollection<MenuItem>();

        public ObservableCollection<MenuItem> Menu
        {
            get { return menu; }
        }

        public ShellViewModel(NavigationService navigationService)
        {
            Menu.Add(new MenuItem() { Glyph = "", Text = "Main Page", NavigationDestination = typeof(MainPage) });
            Menu.Add(new MenuItem() { Glyph = "", Text = "About Page", NavigationDestination = typeof(AboutPage) });
            Menu.Add(new MenuItem() { Glyph = "", Text = "Third Page", NavigationDestination = null });
        }
    }
}
