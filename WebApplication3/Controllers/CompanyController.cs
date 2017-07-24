﻿using System;
using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CompanyController : Controller
    {
        ApplicationDbContext _context;
        public CompanyController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: DropDown
        public ActionResult Index()
        {
            var viewModel = new Company();
            viewModel.Parkings = _context.Parkings.ToList();
            viewModel.date = DateTime.Now;
            viewModel.Name = "My Company";
            return View(viewModel);
        }

        [HttpPost]
        public string Index(Company viewModel)
        {
            return viewModel.selectedRadio;
        }

        // GET: DropDown
        public ActionResult Display()
        {
            var viewModel = new Company();
            viewModel = _context.Companies.Where(c => c.Id == 1).Single();

            return View(viewModel);
        }

        // GET: DropDown
        public ActionResult Edit()
        {
            var viewModel = new Company();
            viewModel.Parkings = _context.Parkings.ToList();
            viewModel.date = DateTime.Now;
            viewModel.Name = "My Company";
            return View(viewModel);
        }

    }
}