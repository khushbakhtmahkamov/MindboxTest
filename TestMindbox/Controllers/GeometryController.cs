using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestMindbox.Repositorys;

namespace TestMindbox.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeometryController : ControllerBase
    {

        private readonly ILogger<GeometryController> logger;
        private readonly IGeometryRepository geometryRepository;

        public GeometryController(ILogger<GeometryController> logger, IGeometryRepository geometryRepository)
        {
            this.logger = logger;
            this.geometryRepository = geometryRepository;
        }

        [HttpGet("getAteaCircle/{radius}")]
        public JsonResult GetAteaCircle(double radius)
        {
            return new JsonResult(geometryRepository.GetAteaCircle(radius));
        }

        [HttpGet("getAteaTriangle/{a}/{b}/{c}")]
        public JsonResult GetAteaTriangle(double a, double b, double c)
        {
            return new JsonResult(geometryRepository.GetAteaTriangle(a,b,c));
        }

        [HttpGet("isRightTriangle/{a}/{b}/{c}")]
        public JsonResult IsRightTriangle(double a, double b, double c)
        {
            return new JsonResult(geometryRepository.IsRightTriangle(a,b,c));
        }
    }
}
