using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Inventory.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;
        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService ?? throw new ArgumentNullException(nameof(inventoryService));
        }

        // GET: api/<SupplierController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_inventoryService.GetInventories());
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            return _inventoryService.GetInventory(id) != null ? Ok(_inventoryService.GetInventory(id)) : NoContent();

        }
    }
}
