using mHealth.core.Models;
using MvvmCross.Platform;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Android.App.DownloadManager;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace mHealth.core.Services
{

    public class APIConnection
    {
        HttpClient httpClient;

        public APIConnection()
        {
            httpClient = new HttpClient();
        }

        public async Task PostJsonToApi(string url, object obj)
        {

            string newUrl = ReplaceUrlvalues(url, obj);
            var uri = new Uri(BaseUrl.GetBaseUrl() + newUrl);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string json = JsonConvert.SerializeObject(obj);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync(uri, content);



            response.RequestMessage.ToString();

        }

        public string ReplaceUrlvalues(string url, object obj)
        {
            Dictionary<string, string> replacements = new Dictionary<string, string>();
            Type type = obj.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(type.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                if (prop.GetValue(obj) != null)
                {
                    replacements.Add("{" + prop.Name.ToLower() + "}", prop.GetValue(obj).ToString());
                }
            }
            foreach (var set in replacements)
            {
                url = url.Replace(set.Key, set.Value);
               
            }
            

            return url;
        }





        public async Task<object> GetJsonFromApiAsync(string url, long cpr, object obj)
        {
            Type ob = obj.GetType();

            string newString = BaseUrl.GetBaseUrl() + url.Replace("{cpr}", cpr.ToString());
            Uri uri = new Uri(newString);
            var apirequest = await httpClient.GetAsync(uri);
            apirequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            string response = apirequest.Content.ReadAsStringAsync().Result;
            //string news = Regex.Unescape( response);
             var jsonString = response.Replace(@"\", "");
             string final = jsonString.Trim().Substring(1, (jsonString.Length) - 2);
             return JsonConvert.DeserializeObject(final, ob);



         }


    }
}
