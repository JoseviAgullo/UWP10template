using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UWP10template.Models
{
    public class TokenRequest
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "client_id")]
        public string Client_id { get; set; }
        [JsonProperty(PropertyName = "client_secret")]
        public string Client_secret { get; set; }
        [JsonProperty(PropertyName = "redirect_uri")]
        public string Redirect_uri { get; set; }
        [JsonProperty(PropertyName = "grant_type")]
        public string Grant_type { get; set; }
    }
}
