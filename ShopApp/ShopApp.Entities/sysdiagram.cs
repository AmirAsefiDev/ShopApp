using System;

namespace ShopApp.Entities
{
    [DataLayer.Table("dbo","sysdiagrams")]
    public class sysdiagram
    {
        public string name { get; set; }
        public int principal_id { get; set; }
        [DataLayer.PrimaryKey]
        [DataLayer.ComputedColumn]
        public int diagram_id { get; set; }
        public int? version { get; set; }
        public object definition { get; set; }
    }
}
