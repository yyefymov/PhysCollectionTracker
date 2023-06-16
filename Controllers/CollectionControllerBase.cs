using Microsoft.AspNetCore.Mvc;
using DataModelLibrary.Interfaces;

namespace PhysCollectionTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CollectionControllerBase<T> : ControllerBase where T : class
    {
        private readonly ICollectionRepository<T> _repository;

        public CollectionControllerBase(ICollectionRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);

            return NoContent();
        }
    } 
}
