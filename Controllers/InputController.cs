using Microsoft.AspNetCore.Mvc;
using CollectibleAdderLibrary.Interfaces;

namespace PhysCollectionTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InputController : ControllerBase
    {
        private readonly ICollectibleAdder _collectibleAdder;

        public InputController(ICollectibleAdder collectibleAdder)
        {
            _collectibleAdder = collectibleAdder;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return NoContent();
        }

        [HttpPost]
        public IActionResult AddCollectible([FromBody] string barcode)
        {
            _collectibleAdder.AddCollectible(barcode);

            return CreatedAtAction(nameof(AddCollectible), barcode);
        }
    }
}
