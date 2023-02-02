using Data;
using Entities.Entities;
using Entities.SearchFilters;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IProductLogic
    {
        List<ProductItem> GetAllProducts();
        void DeleteProductItem(int productId);
        void UpdateProduct(ProductItem productItem);
        int InsertProductItem(ProductItem productItem);
        List<ProductItem> GetProductsByCriteria(ProductFilter productFilter);

    }
}
