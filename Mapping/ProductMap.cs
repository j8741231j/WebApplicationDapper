using Dapper.FluentMap.Mapping;
using WebApplicationDapper.Models;

namespace WebApplicationDapper.Mapping
{
    public class ProductMap : EntityMap<Product>
    {
        public ProductMap()
        {
            Map(p => p.Id).ToColumn("Id"); // 映射 Id 屬性到資料庫列 "Id"
            Map(p => p.Name).ToColumn("Name"); // 映射 Name 屬性到資料庫列 "Name"
            Map(p => p.Price).ToColumn("Price"); // 映射 Price 屬性到資料庫列 "Price"

            // 如果資料庫表名稱和模型類名稱不同，還可以指定表名
             //TableName("Product");
        }
    }
}
