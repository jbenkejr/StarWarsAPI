using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWarsAPI.Models;

namespace StarWarsAPI.Controllers
{
    public class StarWarsController : Controller
    {
        //private readonly HttpClient _client;

        //public StarWarsController(IHttpClientFactory client)
        //{
        //    _client = client.CreateClient();
        //    _client.BaseAddress = new Uri("https://swapi.co/api/");
        //}

        public async Task<IActionResult> DisplayPeople()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");
            var response = await client.GetAsync("people/");
            var people = await response.Content.ReadAsAsync<PeopleData>();
            return View(people);
        }

        public async Task<IActionResult> FindPeople(int Id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");
            var response = await client.GetAsync($"people/{Id}");
            var people = await response.Content.ReadAsAsync<PeopleData>();

            return View(people);
        }

        public async Task<IActionResult> SearchByName(string name)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");
            var response = await client.GetAsync($"people/?search={name}");
            var people = await response.Content.ReadAsAsync<PeopleRoot>();

            return View(people);
        }

        public async Task<IActionResult> DisplayPlanets()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");
            var response = await client.GetAsync("planets/");
            var planet = await response.Content.ReadAsAsync<PlanetRoot>();

            return View(planet);
        }

        public async Task<IActionResult> FindPlanets(int Id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");
            var response = await client.GetAsync($"planets/{Id}");
            var planet = await response.Content.ReadAsAsync<PlanetData>();

            return View(planet);
        }

        public async Task<IActionResult> SearchByPlanetName(string name)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");
            var response = await client.GetAsync($"planets/?search={name}");
            var planet = await response.Content.ReadAsAsync<PlanetRoot>();

            return View(planet);
        }
    }
}