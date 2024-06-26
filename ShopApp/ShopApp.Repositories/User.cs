using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ShopApp.Repositories
{
    public class UsersRepository : DataLayer.GenericRepository<Entities.User>,RepositoryAbstracts.IUsersRepository
    {
        public UsersRepository() : base("name=DbConnectionString") { }
        public List<Entities.User> GetById(int value)
        {
            return RunQuery("SELECT * FROM [dbo].[Users] WHERE [Id] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.User> GetByUsername(string value)
        {
            return RunQuery("SELECT * FROM [dbo].[Users] WHERE [Username] LIKE @Value", new SqlParameter("Value", value));
        }
        public List<Entities.User> GetByDeleted(bool value)
        {
            return RunQuery("SELECT * FROM [dbo].[Users] WHERE [Deleted] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.User> GetByDeletedDate(DateTime? value)
        {
            return RunQuery("SELECT * FROM [dbo].[Users] WHERE [DeletedDate] = @Value", new SqlParameter("Value", value));
        }
        public List<Entities.User> GetByDeletedByUserId(int? value)
        {
            return RunQuery("SELECT * FROM [dbo].[Users] WHERE [DeletedByUserId] = @Value", new SqlParameter("Value", value));
        }
    }
}
