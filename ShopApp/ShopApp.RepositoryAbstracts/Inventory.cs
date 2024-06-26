using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IInventoriesRepository : DataLayer.IRepository<Entities.Inventory>
    {
        List<Entities.Inventory> GetById(int value);
        List<Entities.Inventory> GetByCorporationId(int value);
        List<Entities.Inventory> GetByTitle(string value);
        List<Entities.Inventory> GetByDescription(string value);
        List<Entities.Inventory> GetByDeleted(bool value);
        List<Entities.Inventory> GetByDeletedDate(DateTime? value);
        List<Entities.Inventory> GetByDeletedByUserId(int? value);
    }
}
