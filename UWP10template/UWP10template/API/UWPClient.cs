// <copyright file="UWPClient.cs" company="Josevi Agullo">
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