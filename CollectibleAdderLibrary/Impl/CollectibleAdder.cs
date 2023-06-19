using CollectibleAdderLibrary.Interfaces;
using DataModelLibrary.Interfaces;
using DataModelLibrary.Models;
using EFDataHandlerLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CollectibleAdderLibrary.Impl
{
    public class CollectibleAdder : ICollectibleAdder
    {
        private readonly ICollectionRepositoryFactory _repositoryFactory;

        public CollectibleAdder(ICollectionRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        /// <summary>
        /// Add the collectible that the given barcode is assigned to to the database
        /// </summary>
        /// <param name="barcode"></param>
        public void AddCollectible(string barcode)
        {
            var game = new SwitchGame();
            var repo = _repositoryFactory.Create<SwitchGame>();
            repo.Add(game);
        }
    }
}
