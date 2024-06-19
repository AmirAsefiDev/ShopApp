using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IInventoryInsHeaderRepository : DataLayer.IRepository<Entities.InventoryInsHeader>
    {
        List<Entities.InventoryInsHeader> GetById(long value);
        List<Entities.InventoryInsHeader> GetByInventoryId(int value);
        List<Entities.InventoryInsHeader> GetByTypeId(int value);
        List<Entities.InventoryInsHeader> GetByTitle(string value);
        List<Entities.InventoryInsHeader> GetByDescription(string value);
        List<Entities.InventoryInsHeader> GetByDate(DateTime value);
        List<Entities.InventoryInsHeader> GetByAccepted(bool value);
        List<Entities.InventoryInsHeader> GetByAcceptedDate(DateTime? value);
        List<Entities.InventoryInsHeader> GetByAcceptedByUserId(int? value);
        List<Entities.InventoryInsHeader> GetByDeleted(bool value);
        List<Entities.InventoryInsHeader> GetByDeletedDate(DateTime? value);
        List<Entities.InventoryInsHeader> GetByDeletedByUserId(int? value);
    }
}
