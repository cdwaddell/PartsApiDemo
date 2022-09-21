using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyNewAPI.Models;

namespace MyNewAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly ILogger<InventoryController> _logger;
        private readonly IPartsRepository _partsRepository;

        public InventoryController(ILogger<InventoryController> logger, IPartsRepository partsRepository)
        {
            _logger = logger;
            _partsRepository = partsRepository;
        }

        [HttpGet]
        public IEnumerable<Part> Get()
        {
            var parts = _partsRepository.GetAllParts();
            return parts;
        }

        [HttpPost]
        public Part Post(Part newPart)
        {
            return _partsRepository.AddPart(newPart);
        }
    }
}
