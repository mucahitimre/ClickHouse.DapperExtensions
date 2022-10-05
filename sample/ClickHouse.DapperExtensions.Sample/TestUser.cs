using System;

namespace ClickHouse.DapperExtensions.Sample
{
    [Table("TestUser")]
    public class TestUser
    {
        [Date]
        public DateTime ResisterDate { get; set; }

        public DateTime ResisterTime { get; set; }

        [Key]
        public string Name { get; set; }

        public int Age { get; set; }
    }
}