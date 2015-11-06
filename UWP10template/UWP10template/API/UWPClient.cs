namespace UWP10template.API
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using UWP10template.Models;

    public class UWPClient
    {
        private const string BaseUrl = "YOUR_BASE_URL";
        private static string clientToken = "NoAuthorization";

        public static void SetClientToken(string value)
        {
            clientToken = value;
        }

        // Various

        

        // Requests
        private async Task<T> ExecuteGetRequest<T>(string operation)
        {
            T result = default(T);
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(
                    HttpMethod.Get,
                    string.Concat(BaseUrl, operation));

                // request.Headers.Add("TFGprojectJobs-Authorization", clientToken);
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string value = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(value);
                }
            }

            return result;
        }

        private async Task<T> ExecutePostRequest<T>(string operation, string element)
        {
            T result = default(T);
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(
                    HttpMethod.Post,
                    string.Concat(BaseUrl, operation));
                request.Content = new StringContent(element,
                                    Encoding.UTF8,
                                    "application/json");

                client.DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //StringContent content = new StringContent(element);

                //request.Headers.Add("Content-Type", "application/json");
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string value = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(value);
                }
            }

            return result;
        }

        private async Task<T> ExecutePutRequest<T>(string operation)
        {
            T result = default(T);
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(
                    HttpMethod.Put,
                    string.Concat(BaseUrl, operation));

                // request.Headers.Add("TFGprojectJobs-Authorization", clientToken);

                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string value = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(value);
                }
            }

            return result;
        }

        private async Task<T> ExecutePutRequest<T>(string operation, string element)
        {
            T result = default(T);
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(
                    HttpMethod.Put,
                    string.Concat(BaseUrl, operation));
                request.Content = new StringContent(element,
                                    Encoding.UTF8,
                                    "application/json");

                client.DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //StringContent content = new StringContent(element);

                //request.Headers.Add("Content-Type", "application/json");
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string value = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(value);
                }
            }

            return result;
        }

        private async Task<T> ExecuteDeleteRequest<T>(string operation)
        {
            T result = default(T);
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage(
                    HttpMethod.Delete,
                    string.Concat(BaseUrl, operation));

                // request.Headers.Add("TFGprojectJobs-Authorization", clientToken);
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    string value = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(value);
                }
            }

            return result;
        }
    }
}