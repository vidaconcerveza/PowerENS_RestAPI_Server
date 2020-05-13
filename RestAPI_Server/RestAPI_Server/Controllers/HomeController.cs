using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestAPI_Server.Data.Repositories;
using RestAPI_Server.ViewModels;

namespace RestAPI_Server.Controllers
{
    public class HomeController : Controller
    {
        private readonly IChartRepository _repository;

        public HomeController(IChartRepository repository)
        {
            _repository = repository;
        }
        
        public IActionResult Index()
        {
            var charts = _repository.GetAllCharts();
            var viewModel = new ChartViewModel()
            {
                Charts = charts
            };
            return View(viewModel);
        }

        public IActionResult Detail(int id)
        {
            var chart = _repository.GetChart(id);
            return View(chart);
        }

        public IActionResult TestPage()
        {
            return View();
        }
    }
}