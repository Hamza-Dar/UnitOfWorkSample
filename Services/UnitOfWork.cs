using ECommerceStore.Interface.RepositoryInterfaces;
using UnitOfWork.Context;

namespace UnitOfWork.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private DBContext _context;
        private ICategoryRepository _categoryRepository;

        public UnitOfWork(DBContext context)
        {
            _context = context;
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if(_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_context);
                }
                return _categoryRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
