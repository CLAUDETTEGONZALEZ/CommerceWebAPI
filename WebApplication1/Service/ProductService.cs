using APIService.IService;
using Entities.Entities;
using Logic.ILogic;

namespace APIService.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }
        public List<ProductItem> GetAllProducts()
        {
            return _productLogic.GetAllProducts();
        }
        public int InsertProduct(ProductItem productItem)
        {
            _productLogic.InsertProductItem(productItem);
            return productItem.Id;
        }
        public void UpdateProduct(ProductItem productItem) 
        {
            _productLogic.UpdateProduct(productItem);
        }
        public void DeleteProduct(int productId)
        {
            _productLogic.DeleteProductItem(productId);
        }
    }
}
