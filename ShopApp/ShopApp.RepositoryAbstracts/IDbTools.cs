﻿using System.Threading.Tasks;

namespace ShopApp.RepositoryAbstracts
{
    public interface IDbTools
    {
        Task<bool> CheckDbConnection();
        Task<bool> CheckDatabaseExists();
        Task<bool> CreateDatabase(string dbScript);

        void RefreshConnetionString();
    }
}
