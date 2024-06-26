using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class ProductCategoriesRepository : DataLayer.GenericRepository<Entities.ProductCategory>,RepositoryAbstracts.IProductCategoriesRepository
    {
        public ProductCategoriesRepository() : base("name=DbConnectionString") { }
        public List<Entities.ProductCategory> GetById(int value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductCategories] WHERE [Id] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductCategory> GetByInventoryId(int value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductCategories] WHERE [InvertoryId] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductCategory> GetByParentCategoryId(int? value)
        {
            if (value.HasValue)
                return RunQuery("SELECT * FROM [dbo].[ProductCategories] WHERE [ParentCategoryId] = @Value", new SqlParameter("@Value", value));
            else
                return RunQuery("SELECT * FROM [dbo].[ProductCategories] WHERE [ParentCategoryId] IS NULL");
        }
        public List<Entities.ProductCategory> GetByTitle(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductCategories] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductCategory> GetByDescription(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductCategories] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductCategory> GetByDeleted(bool value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductCategories] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductCategory> GetByDeletedDate(DateTime? value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductCategories] WHERE [DeletedDate] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductCategory> GetByDeletedByUserId(int? value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductCategories] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
        }
    }
}
