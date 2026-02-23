using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResourceManagement.Api.Models;

namespace ResourceManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Route("api/resources")]
    public class ResourcesController : ControllerBase
    {
        private static List<Resource> resources = new();

        [HttpGet]
        public IEnumerable<Resource> Get()
        {
            return resources;
        }

        [HttpPost]
        public void Post(Resource resource)
        {
            resources.Add(resource);
        }
    }
}
