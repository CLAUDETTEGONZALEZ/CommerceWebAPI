using Data;
using Entities.Entities;
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
        void DeleteProductItem(int productId);
        List<ProductItem> GetAllProducts();
        int InsertProductItem(ProductItem productItem);

    }
}
