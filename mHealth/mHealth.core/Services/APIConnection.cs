using mHealth.core.Models;
using MvvmCross.Platform;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Services
{

    public class APIConnection
    {
        HttpClient httpClient;

        public APIConnection()
        {
            httpClient = new HttpClient();
        }

        public async Task<bool> PostJsonToApi(string url, object obj)
        {
            string newUrl = ReplaceUrlvalues(url, obj);
            var uri = new Uri(BaseUrl.GetBaseUrl() + newUrl);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string json = JsonConvert.SerializeObject(obj);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(uri, content);

        return response.IsSuccessStatusCode;

        }

        public string ReplaceUrlvalues(string url, object obj)
        {
            Dictionary<string, string> replacements = new Dictionary<string, string>();
            Type type = obj.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(type.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                replacements.Add("{" + prop.Name.ToLower() + "}", prop.GetValue(obj, null).ToString());
            }
            foreach (var set in replacements)
            {
                url = url.Replace(set.Key, set.Value);
            }
            

            return url;
        }



        public object GetJsonFromApi(string url, object obj, int id)
        {
            string newString = BaseUrl.GetBaseUrl() + url.Replace("{id}", id.ToString());
            Uri uri = new Uri(newString);
            var result = httpClient.GetAsync(uri).Result;
            var json = result.Content.ReadAsStringAsync().Result;
            obj = JsonConvert.DeserializeObject<Client>(json);
            return obj;
        }


    }
}
