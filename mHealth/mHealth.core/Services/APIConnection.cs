using MvvmCross.Platform;
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

        public async Task<bool> PostJsonToApi(string url, string json)
        {
            var uri = new Uri(BaseUrl.GetBaseUrl() + url);
            Debug.WriteLine(BaseUrl.GetBaseUrl() + url);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
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
                replacements.Add("{" + prop.Name + "}", prop.GetValue(obj, null).ToString());
            }
            foreach (var set in replacements)
            {
                return url = BaseUrl.GetBaseUrl() + url.Replace(set.Key, set.Value);
            }
            return "";


        }



        public async Task<string> GetJsonFromApi(string url)
        {
            var result = await httpClient.GetAsync(url);
            return await result.Content.ReadAsStringAsync();
        }


    }
}
