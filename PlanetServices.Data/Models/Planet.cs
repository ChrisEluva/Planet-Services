using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetServices.Data.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DistanceFromSun { get; set; }
    }
}
