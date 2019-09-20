using PlanetServices.Data.Models;
using System.Collections.Generic;


namespace PlanetServices.Data.Interfaces
{
    public interface IPlanetRepository
    {
        List<Planet> GetAllPlanets();

        Planet GetPlanet(int id);
    }
}
