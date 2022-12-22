using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBachelorAzure.Data;

namespace TestBachelorAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DB _db;
        public ValuesController(DB db)
        {
            _db = db;
        }

        [HttpPost]
        [Route("lagre")]
        public bool lagre(Person p)
        {
            _db.personer.Add(p);
            _db.SaveChanges();
            return true;
        }
        [HttpGet]
        [Route("retur")]
        public string retur()
        {
            return "HEI";
        }
        [HttpGet]
        [Route("hent")]
        public List<Person> hent()
        {
            var liste = _db.personer.ToList();
            return liste;
        }
    }
}
