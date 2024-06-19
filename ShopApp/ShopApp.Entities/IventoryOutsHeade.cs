using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","IventoryOutsHeader")]
    public class IventoryOutsHeade
    {
        [DataLayer.PrimaryKey]
        public long Id { get; set; }
        public int InventoryId { get; set; }
        public int TypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Accepted { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public int? AcceptedByUserId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedByUserId { get; set; }
    }
}
