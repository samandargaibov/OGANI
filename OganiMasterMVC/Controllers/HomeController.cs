using Microsoft.AspNetCore.Mvc;
using OganiMasterMVC.DataAccessLayer;
using OganiMasterMVC.DataAccessLayer.Entities;
using OganiMasterMVC.ViewModels;

namespace OganiMasterMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }


        public IActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();
            var products = _dbContext.Products.Take(8).ToList();
            var banners = _dbContext.Banners.ToList();
            var sliderCategories = _dbContext.SliderCategories.ToList();
            var blogs = _dbContext.Blogs.ToList();
            var featuredCategories = _dbContext.FeaturedCategories.ToList();

            var viewModel = new HomeViewModel
            {
                Categories = categories,
                Products = products,
                Banners = banners,
                SliderCategories = sliderCategories,
                Blogs = blogs,
                FeaturedCategories = featuredCategories,
            };

            return View(viewModel);
        }
    }
}
