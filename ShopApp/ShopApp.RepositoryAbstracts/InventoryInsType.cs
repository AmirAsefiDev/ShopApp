using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IInventoryInsTypesRepository : DataLayer.IRepository<Entities.InventoryInsType>
    {
        List<Entities.InventoryInsType> GetById(int value);
        List<Entities.InventoryInsType> GetByTitle(string value);
        List<Entities.InventoryInsType> GetByDescription(string value);
        List<Entities.InventoryInsType> GetByDeleted(bool value);
        List<Entities.InventoryInsType> GetByDeletedDate(DateTime? value);
        List<Entities.InventoryInsType> GetByDeletedByUserId(int? value);
    }
}
