using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","InventoryOutsTypes")]
    public class InventoryOutsType
    {
        [DataLayer.PrimaryKey]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedByUserId { get; set; }
    }
}
