using System;
using System.Collections.Generic;

namespace ShopApp.RepositoryAbstracts
{
    public interface IIventoryOutsHeaderRepository : DataLayer.IRepository<Entities.IventoryOutsHeade>
    {
        List<Entities.IventoryOutsHeade> GetById(long value);
        List<Entities.IventoryOutsHeade> GetByInventoryId(int value);
        List<Entities.IventoryOutsHeade> GetByTypeId(int value);
        List<Entities.IventoryOutsHeade> GetByTitle(string value);
        List<Entities.IventoryOutsHeade> GetByDescription(string value);
        List<Entities.IventoryOutsHeade> GetByDate(DateTime value);
        List<Entities.IventoryOutsHeade> GetByAccepted(bool value);
        List<Entities.IventoryOutsHeade> GetByAcceptedDate(DateTime? value);
        List<Entities.IventoryOutsHeade> GetByAcceptedByUserId(int? value);
        List<Entities.IventoryOutsHeade> GetByDeleted(bool value);
        List<Entities.IventoryOutsHeade> GetByDeletedDate(DateTime? value);
        List<Entities.IventoryOutsHeade> GetByDeletedByUserId(int? value);
    }
}
