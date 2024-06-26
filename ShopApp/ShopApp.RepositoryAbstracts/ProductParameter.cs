using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IProductParametersRepository : DataLayer.IRepository<Entities.ProductParameter>
    {
        List<Entities.ProductParameter> GetById(int value);
        List<Entities.ProductParameter> GetByProductCategoryId(int value);
        List<Entities.ProductParameter> GetByKey(string value);
        List<Entities.ProductParameter> GetByTitle(string value);
        List<Entities.ProductParameter> GetByDescription(string value);
        List<Entities.ProductParameter> GetByData(string value);
        List<Entities.ProductParameter> GetByDeleted(bool value);
        List<Entities.ProductParameter> GetByDeletedDate(DateTime? value);
        List<Entities.ProductParameter> GetByDeletedByUserId(int? value);
    }
}
