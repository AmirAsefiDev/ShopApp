using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IProductCategoriesRepository : DataLayer.IRepository<Entities.ProductCategory>
    {
        List<Entities.ProductCategory> GetById(int value);
        List<Entities.ProductCategory> GetByInventoryId(int value);
        List<Entities.ProductCategory> GetByParentCategoryId(int? value);
        List<Entities.ProductCategory> GetByTitle(string value);
        List<Entities.ProductCategory> GetByDescription(string value);
        List<Entities.ProductCategory> GetByDeleted(bool value);
        List<Entities.ProductCategory> GetByDeletedDate(DateTime? value);
        List<Entities.ProductCategory> GetByDeletedByUserId(int? value);
    }
}
