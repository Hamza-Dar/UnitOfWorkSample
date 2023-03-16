using ECommerceStore.DataTransferObjects;
using UnitOfWork.EFModels;

namespace UnitOfWork.Services
{
    public class EFUtility
    {
        public static CategoryDTO ToCategoryDTO(Category entity)
        {
            CategoryDTO dto = new CategoryDTO();
            dto.CategoryID = entity.CategoryId;
            dto.CategoryName = entity.CategoryName;
            dto.CategoryDescription = entity.CategoryDescription;

            return dto;
        }

        public static List<CategoryDTO> ToCategoryDTOList(List<Category> entities)
        {
            List<CategoryDTO> categoryDTOs= new List<CategoryDTO>();
            foreach (Category entity in entities)
            {
                categoryDTOs.Add(ToCategoryDTO(entity));
            }

            return categoryDTOs;
        }
    }
}
