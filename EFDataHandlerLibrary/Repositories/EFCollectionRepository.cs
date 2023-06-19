using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EFDataHandlerLibrary.Data;
using DataModelLibrary.Models;
using System.Collections;
using DataModelLibrary.Interfaces;

namespace EFDataHandlerLibrary.Repositories
{
    public class EFCollectionRepository<T> : ICollectionRepository<T> where T : class // indicates that T must be a reference type (class, interface, delegate or array)
    {
        private readonly CollectionContext _dbContext;

        public EFCollectionRepository(CollectionContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<T> GetAll()
        {
            // Set<T> can be use to query or add entries
            return _dbContext.Set<T>()
                .AsNoTracking()
                .ToList();
        }

        public void Add(T collectible)
        {
            _dbContext.Set<T>().Add(collectible);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var collectible = _dbContext.Set<T>().Find(id);

            if (collectible == null)
                return;

            _dbContext.Set<T>().Remove(collectible);
            _dbContext.SaveChanges();
        }
    }
}
