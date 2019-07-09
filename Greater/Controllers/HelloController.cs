using Greater.Greater;
using Greater.Greater.Interfaces;
using Greater.Models;
using System.Web.Http;

namespace Greater.Controllers
{
    public class HelloController : ApiController
    {
        private IGreater<Hello> _greater;

        public HelloController()
        {
            _greater = new Greater<Hello>();
        }
        [Route("Hello")]
        public string Get()
        {
            return _greater.SayHello();
        }
    }
}
