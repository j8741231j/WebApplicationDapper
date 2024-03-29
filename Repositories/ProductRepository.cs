using Dapper;
using System.Data;
using Npgsql;
using WebApplicationDapper.Models;
using Dapper.Contrib.Extensions;

namespace WebApplicationDapper.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IConfiguration config) : base(config) { }

        public IEnumerable<Product> GetAllProducts()
        {
            using IDbConnection db = new NpgsqlConnection(ConnectionString);
            //return db.Query<Product>("SELECT * FROM Product");
            return db.GetAll<Product>();
        }

        public Product GetProductById(int id)
        {
            using IDbConnection db = new NpgsqlConnection(ConnectionString);
            return db.QueryFirstOrDefault<Product>("SELECT * FROM \"Product\" WHERE \"Id\" = @Id", new { Id = id });
        }

        public void InsertProduct(Product product)
        {
            using IDbConnection db = new NpgsqlConnection(ConnectionString);
            db.Execute("INSERT INTO \"Product\" (\"Name\", \"Price\") VALUES (@Name, @Price)", product);
        }

        public void UpdateProduct(Product product)
        {
            using IDbConnection db = new NpgsqlConnection(ConnectionString);
            db.Execute("UPDATE \"Product\" SET \"Name\" = @Name, \"Price\" = @Price WHERE \"Id\" = @Id", product);
        }

        public void DeleteProduct(int id)
        {
            using IDbConnection db = new NpgsqlConnection(ConnectionString);
            db.Execute("DELETE FROM \"Product\" WHERE \"Id\" = @Id", new { Id = id });
        }
    }
}