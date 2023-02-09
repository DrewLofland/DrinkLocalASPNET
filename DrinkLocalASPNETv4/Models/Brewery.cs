namespace DrinkLocalASPNETv4.Models
{
    public class Brewery
    {
        public Brewery()
        {
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string BreweryType { get; set; }
        public string Street { get; set; }
        public string Address2 { get; set; }
        public object Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountyProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Phone { get; set; }
        public string WebsiteUrl { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<Brewery> Breweries { get; set; }

        
    }
}

