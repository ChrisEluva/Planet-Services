using PlanetServices.Data.Interfaces;
using PlanetServices.Data.Models;
using PlanetServices.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlanetServices.Controllers
{
    public class PlanetsController : ApiController
    {
        private IPlanetRepository planets;

        public PlanetsController(IPlanetRepository _planets)
        {
            this.planets = _planets;
        }

        public IEnumerable<Planet> Get()
        {
            return planets.GetAllPlanets();
        }

        public IHttpActionResult Get(int id)
        {
            var planet = planets.GetPlanet(id);
            if (planet == null)
            {
                return NotFound();
            }

            return Ok(planet);
        }
    }
}
