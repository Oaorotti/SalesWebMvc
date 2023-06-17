﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _SellerService;

        public SellersController(SellerService context)
        {
            _SellerService = context;
        }

        public IActionResult Index()
        {
            var list = _SellerService.FindAll();

            return View(list);
        }
    }
}
