﻿using Entities.Entities;

namespace APIService.IService
{
    public interface IProductService
    {
        List<ProductItem> GetAllProducts();
        int InsertProduct(ProductItem productItem);
    }
}
