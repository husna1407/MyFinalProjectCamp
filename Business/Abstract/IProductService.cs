using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetAllByCategoryId(int id);//category id ye göre tüm ürünleri getir.
        IDataResult<Product> GetByUnitPrice(decimal min, decimal max);
        IDataResult<ProductDetailDto> GetProductDetails();
        Product GetById(int productId);

        IResult Add(Product product);

    }
}
