using Microsoft.AspNetCore.Mvc;
using OganiMasterMVC.DataAccessLayer;

namespace OganiMasterMVC.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ContactController(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var contacts = _dbContext.Contacts.FirstOrDefault();

            return View(contacts);
        }
    }
}
