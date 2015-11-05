using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Authentication.Web;
using Windows.Security.Cryptography.Certificates;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;
using Windows.Web.Http.Filters;
using UWP10template.API;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP10template.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var redirectUri = "http://www.joseviagullo.com";
            var clientId = "de34d8ca69a30536136f503dbe0ce407a30f420c7960999e23f294befca6a996";
            var authorizeUri = new Uri($"https://api-v2launch.trakt.tv/oauth/authorize?client_id={clientId}&response_type=code&redirect_uri={redirectUri}");

            Uri redirect = new Uri(redirectUri);
            var authResult = await WebAuthenticationBroker.AuthenticateAsync(WebAuthenticationOptions.None, authorizeUri, redirect);
            var response = authResult.ResponseData;
            var code = response.Replace("http://www.joseviagullo.com/?code=", "");

            string token = string.Empty;

            try
            {
                UWPClient client = new UWPClient();
                token = await client.GetToken(code);
            }
            catch (Exception ex)
            {
                MessageDialog messageDialog =
                        new MessageDialog("A tear occured in the space-time continuum. Please try again when all planets in the solar system are aligned (excluding Pluto, which isn't a planet anymore).");

                // Meaningful error messages are important.
                messageDialog.ShowAsync();
            }
            finally
            {
                
            }

            var patata = "Hola";
        }
    }
}
