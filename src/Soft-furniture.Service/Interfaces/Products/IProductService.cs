﻿using Soft_furniture.DataAccess.Utils;
using Soft_furniture.Domain.Entities.Furniture_Catalog;
using Soft_furniture.Domain.Entities.Products;
using Soft_furniture.Service.Dtos.Catalogs;
using Soft_furniture.Service.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_furniture.Service.Interfaces.Products;

public interface IProductService
{
    public Task<long> CountAsync();

    public Task<bool> CreateAsync(ProductsCreateDto dto);

    public Task<bool> DeleteAsync(long productId);

    public Task<IList<Product>> GetAllByTypeIdAsync(long productId, PaginationParams @params);

    public Task<bool> UpdateAsync(long id, ProductsUpdateDto dto);

    public Task<(int ItemsCount, IList<Product>)> SearchAsync(string search, PaginationParams @params);

    public Task<Product> GetByIdAsync(long productId);
}
