using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroBackend
{
    public class Repository
    {
        List<Brewery> breweries = new List<Brewery>()
        {
            new Brewery() { Id = 1, Name = "Minerva" },
            new Brewery() { Id = 2, Name = "Sierra Nevada" },
            new Brewery() { Id = 3, Name = "Sierra Madre" }
        };

        public List<Brewery> GetBreweries() => breweries;

        public Brewery GetBrewery(int id) => breweries.Find(r => r.Id == id);
    }

    public class Brewery
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}