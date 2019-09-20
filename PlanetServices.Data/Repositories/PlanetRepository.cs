using PlanetServices.Data.Interfaces;
using PlanetServices.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetServices.Data.Repositories
{
    public class PlanetRepository : IPlanetRepository
    {
        public List<Planet> planets = new List<Planet>()
        {
            new Planet { Id = 1, Name = "Mercury", DistanceFromSun = "57.91 million km"},
            new Planet { Id = 2, Name = "Venus", DistanceFromSun = "108.2 million km"},
            new Planet { Id = 3, Name = "Earth", DistanceFromSun = "149.6 million km"},
            new Planet { Id = 4, Name = "Mars", DistanceFromSun = "227.9 million km"},
            new Planet { Id = 5, Name = "Jupiter", DistanceFromSun = "778.5 million km"},
            new Planet { Id = 6, Name = "Saturn", DistanceFromSun = "1.434 billion km"},
            new Planet { Id = 7, Name = "Uranus", DistanceFromSun = "2.871 billion km"},
            new Planet { Id = 8, Name = "Neptune", DistanceFromSun = "4.495 billion km"}
        };


        public List<Planet> GetAllPlanets()
        {
            return planets;
        }

        public Planet GetPlanet(int id)
        {
            var planet = planets.FirstOrDefault(x => x.Id == id);
            return planet;
        }
    }
}
