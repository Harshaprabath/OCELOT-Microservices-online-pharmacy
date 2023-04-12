using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Supplier.Servces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Supplier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;
        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService ?? throw new ArgumentNullException(nameof(supplierService));
        }

        // GET: api/<SupplierController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_supplierService.GetSuppliers());
        }

        // GET api/<SupplierController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            return _supplierService.GetSupplier(id) != null ? Ok(_supplierService.GetSupplier(id)) : NoContent();

        }


    }
}
