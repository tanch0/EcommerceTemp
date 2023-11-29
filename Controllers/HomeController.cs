﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TempECommerce.Models;

namespace TempECommerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ShoppingCart()
    {
        return View();
    }

    public IActionResult BlogDetail()
    {
        return View("BlogDetail");
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Product()
    {
        return View();
    }

    public IActionResult Blog()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

