using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Mvc.Context;
using Charity.Mvc.Models;
using Charity.Mvc.Services;
using Charity.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Charity.Mvc.Controllers
{
    public class DonationController : Controller
    {
        private DonationService Service { get; }
        public EFContext Context { get; }
        public DonationController(EFContext context, DonationService service)
        {
            Context = context;
            Service = service;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add([FromForm]DonationViewModel donationView)
        {
            Service.Add(donationView);
            return View("Confirmation");
            
            // alternatywne podejscie:
            // zbierasz dane za pomoca ajaxa i zamiast przesylas modelu do widoku
            // ajax za pomoca inputow przesyla dane
        }
        public IActionResult Confirmation()
        {
            return View();
        }
    }
}