using DataModelLibrary.Models;
using DataModelLibrary.Interfaces;

namespace PhysCollectionTracker.Controllers
{
    public class CDController : CollectionControllerBase<CD>
    {
        public CDController(ICollectionRepository<CD> service) : base(service) { }
    }
}
