using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PlanetClient.Controllers
{
    public class PlanetsController : Controller
    {
        // GET: Planets
        public ActionResult Index()
        {
            var planets = GetPlanetsFromAPI();
            return View(planets);
        }

        private List<Planet> GetPlanetsFromAPI()
        {
            try
            {
                var resultList = new List<Planet>();
                var client = new HttpClient();
                var getDataTask = client.GetAsync("http://localhost:57104/api/planets").ContinueWith(response =>
                {
                    var result = response.Result;
                    if (result.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var readResult = result.Content.ReadAsAsync<List<Planet>>();
                        readResult.Wait();
                        resultList = readResult.Result;
                    }
                });
                getDataTask.Wait();
                return resultList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}