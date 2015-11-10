// <copyright file="HttpService.cs" company="Josevi Agullo">
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
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using System.Text;

    public class HttpService
    {
        /// <summary>
        /// Initializes a new instance of the HttpService class
        /// </summary>
        public HttpService()
        {
        }

        /// <summary>
        /// Makes a GET request
        /// </summary>
        /// <param name="requestUriString">The request Uri</param>
        /// <returns>The task to wait for the response</returns>
        public async Task<byte[]> GetAsync(string requestUriString)
        {
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient httpClient = new HttpClient(handler);
            httpClient.MaxResponseContentBufferSize = 256000;
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, requestUriString);

            HttpResponseMessage response = await httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }

        /// <summary>
        /// Makes a POST request
        /// </summary>
        /// <param name="requestUriString">The request Uri</param>
        /// <returns>The task to wait for the response string</returns>
        public async Task<string> PostAsync(string requestUriString)
        {
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient httpClient = new HttpClient(handler);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, requestUriString);

            HttpResponseMessage response = await httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Makes a post request sending JSON content.
        /// </summary>
        /// <param name="requestUriString">The request Uri</param>
        /// <param name="data">The content to POST</param>
        /// <returns>The task to wait for the response string</returns>
        public async Task<string> PostAsync(string requestUriString, object data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync(requestUriString, content);

            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Makes a POST request
        /// </summary>
        /// <param name="requestUriString">The request Uri</param>
        /// <param name="contentType">The type of content to send with the request</param>
        /// <param name="content">The content to send with the request</param>
        /// <returns>The task to wait for the response string</returns>
        public async Task<string> PostAsync(string requestUriString, string contentType, byte[] content)
        {
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient httpClient = new HttpClient(handler);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, requestUriString);
            request.Content = new ByteArrayContent(content);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue(contentType);

            HttpResponseMessage response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Makes a POST request
        /// </summary>
        /// <param name="requestUriString">The request Uri</param>
        /// <param name="content">The content to send with the request</param>
        /// <returns>The task to wait for the response string</returns>
        public async Task<string> PostAsync(string requestUriString, List<KeyValuePair<string, string>> content)
        {
            HttpClientHandler handler = new HttpClientHandler();
            HttpClient httpClient = new HttpClient(handler);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, requestUriString);
            request.Content = new FormUrlEncodedContent(content);

            HttpResponseMessage response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
