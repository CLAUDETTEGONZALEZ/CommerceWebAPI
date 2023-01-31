using APIService.IService;
using Entities.Entities;

namespace APIService.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductService _productLogic;
        public ProductService(IProductService productLogic)
        {
            _productLogic = productLogic;
        }
        public int InsertProduct(ProductItem productItem)
        {
            _productLogic.InsertProduct(productItem);
            return productItem.Id;
        }
    }
}
