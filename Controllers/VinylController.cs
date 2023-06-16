using DataModelLibrary.Models;
using DataModelLibrary.Interfaces;

namespace PhysCollectionTracker.Controllers
{
    public class VinylController : CollectionControllerBase<Vinyl>
    {
        public VinylController(ICollectionRepository<Vinyl> service) : base(service) { }
    }
}
