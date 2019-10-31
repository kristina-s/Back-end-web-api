using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FlowersController : ControllerBase
    {
        private readonly IFlowerService _flowerService;
        public FlowersController(IFlowerService flowerService)
        {
            _flowerService = flowerService;
        }

        // GET: api/Flowers
        [HttpGet]
        public IEnumerable<FlowerModel> Get()
        {
            return _flowerService.GetFlowers();
        }

        // GET: api/Flowers/5
        [HttpGet("{type}")]
        public IEnumerable<FlowerModel> Get(string type)
        {
            FlowerType typeEnum = (FlowerType)Enum.Parse(typeof(FlowerType), type, true);
            return _flowerService.GetFlowersByType(typeEnum);
        }

    }
}
