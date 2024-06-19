using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class ProductParametersRepository : DataLayer.GenericRepository<Entities.ProductParameter>,RepositoryAbstracts.IProductParametersRepository
    {
        public ProductParametersRepository() : base("name=DbConnectionString") { }
        public List<Entities.ProductParameter> GetById(int value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductParameters] WHERE [Id] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductParameter> GetByProductCategoryId(int value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductParameters] WHERE [ProductCategoryId] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductParameter> GetByKey(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductParameters] WHERE [Key] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductParameter> GetByTitle(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductParameters] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductParameter> GetByDescription(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductParameters] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductParameter> GetByData(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductParameters] WHERE [Data] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductParameter> GetByDeleted(bool value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductParameters] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductParameter> GetByDeletedDate(DateTime? value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductParameters] WHERE [DeletedDate] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductParameter> GetByDeletedByUserId(int? value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductParameters] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
        }
    }
}