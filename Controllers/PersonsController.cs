using EntityFramework.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRUDExample.Controllers
{
    [Route("persons")]
    public class PersonsController : Controller
    {
        private readonly PersonsDbContext _db;

        public PersonsController(PersonsDbContext personDbContext)
        {
            _db = personDbContext;
        }
        // GET /persons or /persons/index
        [HttpGet("")]
        [HttpGet("index")]
        public IActionResult Index()
        {
            var persons = _db.Persons.ToList();
            return Json(persons);
        }
    }
}