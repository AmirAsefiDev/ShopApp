using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","ProductParameters")]
    public class ProductParameter
    {
        [DataLayer.PrimaryKey]
        [DataLayer.ComputedColumn]
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public string Key { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedByUserId { get; set; }
    }
}
