using Microsoft.AspNetCore.Mvc;
using MyWebServiceREST.Services.Interfaces;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebServiceREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly IHelloWorldServices _HelloWorldServices;
        private readonly IConfiguration configuration;

        public HelloWorldController(IHelloWorldServices _hello, IConfiguration config)
        {
            _HelloWorldServices = _hello;
            configuration = config;
        }

        // GET: api/<HelloWorldController>
        [HttpGet]
        public string Get()
        {
            return _HelloWorldServices.GetMessage();
        }

        // GET api/<HelloWorldController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HelloWorldController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
