using APIService.IService;
using Entities.Entities;
using Entities.SearchFilters;
using Microsoft.AspNetCore.Mvc;

namespace APIService.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpPost(Name = "InsertProduct")]
        public int Post([FromBody]ProductItem productItem)
        {
            return _productService.InsertProduct(productItem);
        }
        [HttpGet(Name = "GetProductsByCriteria")]
        public List<ProductItem> GetByCriteria(bool isActive)
        {
            var productFilter = new ProductFilter();
            productFilter.IsActive = isActive;
            return _productService.GetProductsByCriteria(productFilter);
        }
        [HttpGet(Name = "GetAllProducts")]
        public List<ProductItem> GetAll()
        {
            return _productService.GetAllProducts();
        }
        [HttpPatch(Name = "ModifyProduct")]
        public void Patch([FromBody]ProductItem productItem)
        {
            _productService.UpdateProduct(productItem);
        }
        [HttpDelete(Name = "DeleteProduct")]
        public void Delete([FromQuery] int id) 
        {
            _productService.DeleteProduct(id);
        }
    }
}
