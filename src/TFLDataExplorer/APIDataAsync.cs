using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using TFLDataExplorer.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace TFLDataExplorer
{

    public class APIDataAsync
    {
        
        public async Task<IEnumerable<T>> GetObject<T>(string uriActionString)
        {
            IEnumerable<T> returnValue =
              default(IEnumerable<T>);

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://api.tfl.gov.uk/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(uriActionString);
                    response.EnsureSuccessStatusCode();

                    returnValue = JsonConvert.DeserializeObject<IEnumerable<T>>(((HttpResponseMessage)response).Content.ReadAsStringAsync().Result).ToList();

                }

             
                return returnValue;

            }
            catch (Exception e)
            {
                throw (e);
            }
        }


    }
}

