using Greater.Greater;
using Greater.Greater.Interfaces;
using Greater.Models;
using System.Web.Http;

namespace Greater.Controllers
{
    public class HiController : ApiController
    {
        private IGreater<Hi> _greater;

        public HiController()
        {
            _greater = new Greater<Hi>();
        }
        [Route("Hi")]
        public string Get()
        {
            return _greater.SayHello();
        }

    }
}
