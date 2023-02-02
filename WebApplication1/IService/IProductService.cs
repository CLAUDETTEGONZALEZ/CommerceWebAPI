using Entities.Entities;
using Entities.SearchFilters;

namespace APIService.IService
{
    public interface IProductService
    {
        List<ProductItem> GetAllProducts();
        int InsertProduct(ProductItem productItem);
        List<ProductItem> GetProductsByCriteria(ProductFilter productFilter);
        void UpdateProduct(ProductItem productItem);
        void DeleteProduct(int id);
    }
}
