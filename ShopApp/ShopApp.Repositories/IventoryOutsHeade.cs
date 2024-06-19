using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class IventoryOutsHeaderRepository : DataLayer.GenericRepository<Entities.IventoryOutsHeade>,RepositoryAbstracts.IIventoryOutsHeaderRepository
    {
        public IventoryOutsHeaderRepository() : base("name=DbConnectionString") { }
        public List<Entities.IventoryOutsHeade> GetById(long value)
        {
            return RunQuery("SELECT * FROM [dbo].[IventoryOutsHeader] WHERE [Id] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.IventoryOutsHeade> GetByInventoryId(int value)
        {
            return RunQuery("SELECT * FROM [dbo].[IventoryOutsHeader] WHERE [InventoryId] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.IventoryOutsHeade> GetByTypeId(int value)
        {
            return RunQuery("SELECT * FROM [dbo].[IventoryOutsHeader] WHERE [TypeId] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.IventoryOutsHeade> GetByTitle(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[IventoryOutsHeader] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.IventoryOutsHeade> GetByDescription(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[IventoryOutsHeader] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.IventoryOutsHeade> GetByDate(DateTime value)
        {
            return RunQuery("SELECT * FROM [dbo].[IventoryOutsHeader] WHERE [Date] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.IventoryOutsHeade> GetByAccepted(bool value)
        {
            return RunQuery("SELECT * FROM [dbo].[IventoryOutsHeader] WHERE [Accepted] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.IventoryOutsHeade> GetByAcceptedDate(DateTime? value)
        {
            return RunQuery("SELECT * FROM [dbo].[IventoryOutsHeader] WHERE [AcceptedDate] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.IventoryOutsHeade> GetByAcceptedByUserId(int? value)
        {
            return RunQuery("SELECT * FROM [dbo].[IventoryOutsHeader] WHERE [AcceptedByUserId] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.IventoryOutsHeade> GetByDeleted(bool value)
        {
            return RunQuery("SELECT * FROM [dbo].[IventoryOutsHeader] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.IventoryOutsHeade> GetByDeletedDate(DateTime? value)
        {
            return RunQuery("SELECT * FROM [dbo].[IventoryOutsHeader] WHERE [DeletedDate] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.IventoryOutsHeade> GetByDeletedByUserId(int? value)
        {
            return RunQuery("SELECT * FROM [dbo].[IventoryOutsHeader] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
        }
    }
}
