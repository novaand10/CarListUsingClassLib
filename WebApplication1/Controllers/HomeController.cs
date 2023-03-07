using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Web.Mvc;
using BusinessLogic;
using BusinessLogic.Interface;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBContext _dbContext = new DBContext();
       
        //public Repository<Car> _carRepository = new Repository<Car>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CarListing()
        {
            IListingCar _iList = new ListingCar(_dbContext);
            var cars = _iList.GetListCar().ToList();
            
            return View(cars);
        }

        public ActionResult CarListingAbc()
        {
            IListingCarAbc _iList = new ListingCarAbc(_dbContext);
            var cars = _iList.GetListCarAbc().ToList();

            return View(cars);
        }
        //test222zz
    }
}