using ECommerceStore.DataTransferObjects;
using ECommerceStore.Interface.RepositoryInterfaces;
using UnitOfWork.Context;

namespace UnitOfWork.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private DBContext _context;

        public CategoryRepository(DBContext context)
        {
            _context = context;
        }

        public CategoryDTO FindCategoryById(int id)
        {
            CategoryDTO dto = new CategoryDTO();
            var result = _context.Category.Find(id);

            if(result != null)
            {
                dto = EFUtility.ToCategoryDTO(result);
            }
            return dto;
        }

        public CategoryDTO FindCategoryByName(string name)
        {
            throw new NotImplementedException();
            //var c = _context.Categories.Where(x => x.CategoryName == name).FirstOrDefault();
        }

        public List<CategoryDTO> GetAllCategories()
        {
            List<CategoryDTO> result = new List<CategoryDTO>();
            var entities = _context.Category.ToList();

            if(entities != null)
            {
                result = EFUtility.ToCategoryDTOList(entities);
            }

            return result;
        }
    }
}
