using AutoMapper;
using automapperMVC.Models;
using AutoMappersMVCExample.Models;
using AutoMappersMVCExample.Models.Interfaces;
using AutoMappersMVCExample.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace automapperMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper mapper;
        private readonly IUser _userRepo;

        public HomeController(ILogger<HomeController> logger,IMapper m,IUser u)
        {
            _logger = logger;
            mapper = m;_userRepo = u;
        }

        public IActionResult Index()
        {
            User user = _userRepo.GetUserDetails();
            UserViewModel userViewModel = mapper.Map<UserViewModel>(user);
            return View();
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
}