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

    public class APIContextAsync
    {
        
        public async Task<IEnumerable<T>> GetObject<T>(string uriActionString)
        {
            IEnumerable<T> returnValue =
              default(IEnumerable<T>);

            try
            {
                using (var client = new HttpClient())
                {
                    // Establish a connection to the TFL API.
                    client.BaseAddress = new Uri("https://api.tfl.gov.uk/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Pass the URI requested by the calling Controller.
                    HttpResponseMessage response = await client.GetAsync(uriActionString);

                    // Check that a successfull response code was returned from the API otherwise throw an Exception.
                    response.EnsureSuccessStatusCode();

                    // Deserialize the returned JSON object to the Type specified by the calling Controller.
                    returnValue = JsonConvert.DeserializeObject<IEnumerable<T>>(((HttpResponseMessage)response).Content.ReadAsStringAsync().Result).ToList();

                }

                return returnValue;

            }

            catch (Exception Exception)
            {
                throw (Exception);
            }
        }


    }
}

