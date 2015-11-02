namespace UWP10template.Services
{
    using Windows.Networking.Connectivity;

    public class NetworkService
    {
        public bool IsOnline()
        {
            var internetProfile = NetworkInformation.GetInternetConnectionProfile();
            return internetProfile != null &&
                internetProfile.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;
        }
    }
}
