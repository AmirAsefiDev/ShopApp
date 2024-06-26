using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","ProductCategories")]

    public class ProductCategory
    {
        [DataLayer.PrimaryKey]
        [DataLayer.ComputedColumn]

        public int Id { get; set; }

        public int InventoryId { get; set; }

        public int? ParentCategoryId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool Deleted { get; set; }

        public DateTime? DeletedDate { get; set; }

        public int? DeletedByUserId { get; set; }
    }
}
