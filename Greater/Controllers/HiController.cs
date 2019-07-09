using Greater.Greater;
using Greater.Greater.Interfaces;
using Greater.Models;
using System.Web.Http;

namespace Greater.Controllers
{
    public class HiController : ApiController
    {
        private IGreater<Hi> _greater;

        public HiController(IGreater<Hi> greater)
        {
            _greater = greater;
        }
        [Route("Hi")]
        public string Get()
        {
            return _greater.SayHello();
        }

    }
}
