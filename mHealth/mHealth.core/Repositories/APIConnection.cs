﻿using MvvmCross.Platform;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Java.Lang;
using mHealth.core.Models;

namespace mHealth.core.Services
{

    public class APIConnection
    {
        HttpClient httpClient;

        public APIConnection()
        {
            httpClient = new HttpClient();
        }

        public async Task<HttpResponseMessage> PostJsonToApi(string url, object obj)
        {

            string newUrl = ReplaceUrlvalues(url, obj);
            var uri = new Uri(BaseUrl.GetBaseUrl() + newUrl);
            var newUri = uri.AbsoluteUri;
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string json = JsonConvert.SerializeObject(obj);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

        
               return await httpClient.PostAsync(newUri, content);
          
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





        public async Task<object> GetJsonFromApiAsync(string url, string id, object obj)
        {
            string newString; 
            Type ob = obj.GetType();
            if (ob.Equals(typeof(User)))
            {
                newString = BaseUrl.GetBaseUrl() + url.Replace("{username}", id);
            }
            else { newString = BaseUrl.GetBaseUrl() + url.Replace("{id}", id); }
   
            Uri uri = new Uri(newString);
            var apirequest = httpClient.GetAsync(uri).Result;
            apirequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            string response = await apirequest.Content.ReadAsStringAsync();
            //string news = Regex.Unescape( response);
             var jsonString = response.Replace(@"\", "");
             string final = jsonString.Trim().Substring(1, (jsonString.Length) - 2);
             return JsonConvert.DeserializeObject(final, ob);

            }
        }
}
