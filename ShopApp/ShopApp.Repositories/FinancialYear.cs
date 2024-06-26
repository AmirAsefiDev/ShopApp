using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class FinancialYearsRepository : DataLayer.GenericRepository<Entities.FinancialYear>,RepositoryAbstracts.IFinancialYearsRepository
    {
        public FinancialYearsRepository() : base("name=DbConnectionString") { }
        public List<Entities.FinancialYear> GetById(int value)
        {
            return RunQuery("SELECT * FROM [dbo].[FinancialYears] WHERE [Id] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.FinancialYear> GetByCorporationId(int value)
        {
            return RunQuery("SELECT * FROM [dbo].[FinancialYears] WHERE [CorporationId] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.FinancialYear> GetByTitle(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[FinancialYears] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.FinancialYear> GetByDescription(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[FinancialYears] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.FinancialYear> GetByStartDate(DateTime value)
        {
            return RunQuery("SELECT * FROM [dbo].[FinancialYears] WHERE [StartDate] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.FinancialYear> GetByFinishDate(DateTime value)
        {
            return RunQuery("SELECT * FROM [dbo].[FinancialYears] WHERE [FinishDate] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.FinancialYear> GetByIsClosed(bool value)
        {
            return RunQuery("SELECT * FROM [dbo].[FinancialYears] WHERE [IsClosed] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.FinancialYear> GetByCloseDate(DateTime? value)
        {
            return RunQuery("SELECT * FROM [dbo].[FinancialYears] WHERE [CloseDate] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.FinancialYear> GetByClosedByUserId(int? value)
        {
            return RunQuery("SELECT * FROM [dbo].[FinancialYears] WHERE [ClosedByUserId] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.FinancialYear> GetByDeleted(bool value)
        {
            return RunQuery("SELECT * FROM [dbo].[FinancialYears] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.FinancialYear> GetByDeletedDate(DateTime? value)
        {
            return RunQuery("SELECT * FROM [dbo].[FinancialYears] WHERE [DeletedDate] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.FinancialYear> GetByDeletedByUserId(int? value)
        {
            return RunQuery("SELECT * FROM [dbo].[FinancialYears] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
        }
    }
}
