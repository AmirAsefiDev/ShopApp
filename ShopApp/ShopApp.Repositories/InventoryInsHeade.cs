using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class InventoryInsHeaderRepository : DataLayer.GenericRepository<Entities.InventoryInsHeader>,RepositoryAbstracts.IInventoryInsHeaderRepository
    {
        public InventoryInsHeaderRepository() : base("name=DbConnectionString") { }
        public List<Entities.InventoryInsHeader> GetById(long value)
        {
            return RunQuery("SELECT * FROM [dbo].[InventoryInsheader] WHERE [Id] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.InventoryInsHeader> GetByInventoryId(int value)
        {
            return RunQuery("SELECT * FROM [dbo].[InventoryInsHeader] WHERE [InventoryId] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.InventoryInsHeader> GetByTypeId(int value)
        {
            return RunQuery("SELECT * FROM [dbo].[InventoryInsHeader] WHERE [TypeId] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.InventoryInsHeader> GetByTitle(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[InventoryInsHeader] WHERE [Title] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.InventoryInsHeader> GetByDescription(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[InventoryInsHeader] WHERE [Description] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.InventoryInsHeader> GetByDate(DateTime value)
        {
            return RunQuery("SELECT * FROM [dbo].[InventoryInsHeader] WHERE [Date] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.InventoryInsHeader> GetByAccepted(bool value)
        {
            return RunQuery("SELECT * FROM [dbo].[InventoryInsHeader] WHERE [Accepted] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.InventoryInsHeader> GetByAcceptedDate(DateTime? value)
        {
            return RunQuery("SELECT * FROM [dbo].[InventoryInsHeader] WHERE [AcceptedDate] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.InventoryInsHeader> GetByAcceptedByUserId(int? value)
        {
            return RunQuery("SELECT * FROM [dbo].[InventoryInsHeader] WHERE [AcceptedByUserId] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.InventoryInsHeader> GetByDeleted(bool value)
        {
            return RunQuery("SELECT * FROM [dbo].[InventoryInsHeader] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.InventoryInsHeader> GetByDeletedDate(DateTime? value)
        {
            return RunQuery("SELECT * FROM [dbo].[InventoryInsHeader] WHERE [DeletedDate] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.InventoryInsHeader> GetByDeletedByUserId(int? value)
        {
            return RunQuery("SELECT * FROM [dbo].[InventoryInsHeader] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
        }
    }
}
