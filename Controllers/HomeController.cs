using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Prueba_Técnica.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Collections.Generic;

namespace Prueba_Técnica.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        string url = "https://fakestoreapi.com/products";
        var client = new HttpClient();
        var response = await client.GetAsync(url);
        var body = await response.Content.ReadAsStringAsync();
        var Productos = JsonSerializer.Deserialize<List<Productos>>(body);

        return View("Index", Productos);
    }

        public async Task<IActionResult> Men()
    {
        string url = "https://fakestoreapi.com/products";
        var client = new HttpClient();
        var response = await client.GetAsync(url);
        var body = await response.Content.ReadAsStringAsync();
        var Productos = JsonSerializer.Deserialize<List<Productos>>(body);

        return View("Men", Productos);
    }

        public async Task<IActionResult> Women()
    {
        string url = "https://fakestoreapi.com/products";
        var client = new HttpClient();
        var response = await client.GetAsync(url);
        var body = await response.Content.ReadAsStringAsync();
        var Productos = JsonSerializer.Deserialize<List<Productos>>(body);

        return View("Women", Productos);
    }

            public async Task<IActionResult> Electronics()
    {
        string url = "https://fakestoreapi.com/products";
        var client = new HttpClient();
        var response = await client.GetAsync(url);
        var body = await response.Content.ReadAsStringAsync();
        var Productos = JsonSerializer.Deserialize<List<Productos>>(body);

        return View("Electronics", Productos);
    }

            public async Task<IActionResult> Jewelery()
    {
        string url = "https://fakestoreapi.com/products";
        var client = new HttpClient();
        var response = await client.GetAsync(url);
        var body = await response.Content.ReadAsStringAsync();
        var Productos = JsonSerializer.Deserialize<List<Productos>>(body);

        return View("Jewelery", Productos);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
