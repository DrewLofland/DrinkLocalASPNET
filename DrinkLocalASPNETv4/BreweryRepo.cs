using System;
using System.IO;
using System.Net.Http;
using DrinkLocalASPNETv4.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace DrinkLocalASPNETv4
{
    public class BreweryRepo 
    {
        public BreweryRepo()
        {
        }

        public static List<Brewery> GetBreweriesRESTSharp(string city)
        {
            var client = new RestClient($"https://api.openbrewerydb.org/breweries?by_city={city}&per_page=100");
            var request = new RestRequest();

            var response = client.Execute(request);

           
            var breweryList = JsonConvert.DeserializeObject<List<Brewery>>(response.Content);

            return breweryList;
        }


    }
}
