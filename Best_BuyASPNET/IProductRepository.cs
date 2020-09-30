﻿using System;
using System.Collections.Generic;
using Best_BuyASPNET.Models;

namespace Best_BuyASPNET
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
    }
    

}
