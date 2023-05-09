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

        [HttpPost]
        public IActionResult Post([FromBody] Models.Inventory inventory)
        {
            return Ok(_inventoryService.AddInventory(inventory));
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Models.Inventory inventory)
        {
            return Ok(_inventoryService.UpdateInventory(inventory));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _inventoryService.DeleteInventory(id);
            return result.HasValue & result == true ? Ok($"inventory with ID: {id} got deleted successfully.")
                : BadRequest($"Unable to delete the inventory with ID: {id}.");
        }
    }
}
