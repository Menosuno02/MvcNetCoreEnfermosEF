﻿using Microsoft.AspNetCore.Mvc;
using MvcNetCoreEnfermosEF.Models;
using MvcNetCoreEnfermosEF.Repositories;

namespace MvcNetCoreEnfermosEF.Controllers
{
    public class EnfermosController : Controller
    {
        private RepositoryEnfermos repo;

        public EnfermosController(RepositoryEnfermos repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Enfermo> enfermos = this.repo.GetEnfermos();
            return View(enfermos);
        }

        public IActionResult Details(int id)
        {
            Enfermo enfermo = this.repo.FindEnfermo(id);
            if (enfermo == null)
            {
                ViewData["MENSAJE"] = "No existe enfermo con inscripción " + id;
            }
            return View(enfermo);
        }
    }
}
