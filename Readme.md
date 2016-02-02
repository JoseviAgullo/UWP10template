# UWP10template documentation
A template with the basics to start creating your own UWP using the MVVM pattern. 

*NOTE: This template doesn't teach you how to use the MVVM pattern, it is just one implementation using it, there are differents ways and every developer prefers one specific way, so you must learn about this pattern by your own and after that return here and start developing your app with a base!*

## Contents
* Hamburguer menu
* ViewModels
* Services

### Hamburguer menu
Following the new desing rules of the platform, we can find very usefull to implement a hamburguer menu to navigate between pages.

<img src="http://i1-news.softpedia-static.com/images/news2/Users-Rail-Against-the-Hamburger-Menu-of-Windows-10-for-Phones-473241-4.jpg" alt="Hamburguer menu" Height="640" Width="360">

To use the *Hamburguer menu* you just need to point to *Shell* view into *App.xaml.cs* and add a your own *MenuItem* into ShellViewModel.


### ViewModels

Here you can find the business logic of your application. 

To add a new ViewModel, you need to follow the next steps:

1. Create a new ViewModel class into ViewModels folder, and inherit from BaseViewModel class

        public class NewViewModel : ObservableObject
        {
            public NewViewModel()
            {
            }
        }

2. Register the ViewModel into ServiceLocator class

        this.container.RegisterType<NewViewModel>();
        
        public NewViewModel NewViewModel
        {
            get { return this.container.Resolve<NewViewModel>(); }
        }
3. Add mapping between View and ViewModel into NavigationServiceConfiguration
        { typeof(NewViewModel), typeof(NewPage) }
        
4. Add DataContext to XAML view file, into the environment declaration section
        DataContext="{Binding NewViewModel, Source={StaticResource Locator}}"

### Services

A Service is a class which represents an specific functionality, is useful to keep your code separated and well structured, and reuse those functionalities in different projects very easily

To add a new Service, you need to follow the next steps:

1. Create a new Service into Services folder

        public class MyService
        {
            public MyService()
            {
            }
        }
        
2. Register the Service into ServiceLocator class
        this.container.RegisterType<MyService>();

