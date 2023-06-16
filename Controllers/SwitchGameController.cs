using Microsoft.AspNetCore.Mvc;
using DataModelLibrary.Models;
using DataModelLibrary.Interfaces;

namespace PhysCollectionTracker.Controllers
{
    public class SwitchGameController : CollectionControllerBase<SwitchGame>
    {
        public SwitchGameController(ICollectionRepository<SwitchGame> service) : base(service) { }
    }
}
