using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class ProductUnitsRepository : DataLayer.GenericRepository<Entities.ProductUnit>,RepositoryAbstracts.IProductUnitsRepository
    {
        public ProductUnitsRepository() : base("name=DbConnectionString") { }
        public List<Entities.ProductUnit> GetById(int value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductUnits] WHERE [Id] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductUnit> GetByTitle(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductUnits] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductUnit> GetByDescription(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductUnits] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductUnit> GetByDeleted(bool value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductUnits] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductUnit> GetByDeletedDate(DateTime? value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductUnits] WHERE [DeletedDate] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.ProductUnit> GetByDeletedByUserId(int? value)
        {
            return RunQuery("SELECT * FROM [dbo].[ProductUnits] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
        }
    }
}
