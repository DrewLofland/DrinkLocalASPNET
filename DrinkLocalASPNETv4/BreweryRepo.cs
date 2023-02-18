using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.NetworkInformation;
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

        public static Brewery GetBreweries(string city)
        {
            var client = new RestClient($"https://api.openbrewerydb.org/breweries?by_city={city}&per_page=100");
            var request = new RestRequest();

            var response = client.Execute(request);

            var brewery = new Brewery();
           
            brewery.Breweries = JsonConvert.DeserializeObject<List<Brewery>>(response.Content);

           return brewery;


        }

        public static Brewery GetBreweryById(string obdbId)
        {
            var client = new RestClient($"https://api.openbrewerydb.org/breweries/{obdbId}");
            var request = new RestRequest();

            var response = client.Execute(request);

            var brewery = new Brewery();

            brewery = JsonConvert.DeserializeObject<Brewery>(response.Content);

            return brewery;
        }

        public static Brewery GetBreweryMap(Brewery brewery)

        {
          
            var mapkey = System.IO.File.ReadAllText("appsettings.json");
            brewery.MapsKey = JObject.Parse(mapkey).GetValue("MapsKey").ToString();

            brewery.MapsURL = $"https://www.google.com/maps/embed/v1/view?key={brewery.MapsKey}&center={brewery.Latitude},{brewery.Longitude}&zoom=17&maptype=satellite";

            return brewery;
        }

        
    }
}
