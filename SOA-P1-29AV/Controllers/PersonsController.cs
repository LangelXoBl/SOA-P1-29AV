using Microsoft.AspNetCore.Mvc;
using Service.IServices;

namespace SOA_P1_29AV.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : Controller
    {
        private readonly IPerson _persona;

        public PersonsController( IPerson person)
        {
            _persona = person;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //return View();
            return Ok(_persona.GetPeople());
        }
    }
}
