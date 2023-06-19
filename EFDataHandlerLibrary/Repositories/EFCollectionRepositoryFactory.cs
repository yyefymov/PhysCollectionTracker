using DataModelLibrary.Interfaces;
using EFDataHandlerLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataHandlerLibrary.Repositories
{
    public class EFCollectionRepositoryFactory : ICollectionRepositoryFactory
    {
        private CollectionContext _dbContext;

        public EFCollectionRepositoryFactory(CollectionContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ICollectionRepository<T> Create<T>() where T : class
        {
            return new EFCollectionRepository<T>(_dbContext);
        }
    }
}
