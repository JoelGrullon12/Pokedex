﻿using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Controllers
{
    public class PokemonsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}