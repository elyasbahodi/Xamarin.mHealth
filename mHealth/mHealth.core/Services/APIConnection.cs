using MvvmCross.Platform;
using Newtonsoft.Json;
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
            string finishedUrl = BaseUrl.GetBaseUrl() + url; 

            return finishedUrl;
        }



        public async Task<string> GetJsonFromApi(string url)
        {
            var result = await httpClient.GetAsync(url);
            return await result.Content.ReadAsStringAsync();
        }


    }
}
