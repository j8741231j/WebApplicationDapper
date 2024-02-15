using Dapper.Contrib.Extensions; //增加此行

namespace WebApplicationDapper.Models
{
    [Table("Product")] // 指定模型對應的資料庫表名稱  //增加此行
    public class Product
    {
        [Key] // 指定模型的主鍵屬性  //增加此行
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
