using Microsoft.AspNetCore.Mvc;
using OganiMasterMVC.DataAccessLayer;
using OganiMasterMVC.ViewModels;

namespace OganiMasterMVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ShopController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var categories = _dbContext.Categories.ToList();
            var products = _dbContext.Products.Skip(8).ToList();

            var viewModel = new ShopViewModel
            {
                Categories = categories,
                Products = products,
            };

            return View(viewModel);
        }
    }
}
