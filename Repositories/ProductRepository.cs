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
            return db.GetAll<Product>();
        }

        public Product GetProductById(int id)
        {
            using IDbConnection db = new NpgsqlConnection(ConnectionString);
            return db.Get<Product>(id);
        }

        public void InsertProduct(Product product)
        {
            using IDbConnection db = new NpgsqlConnection(ConnectionString);
            db.Insert(product);
        }

        public void UpdateProduct(Product product)
        {
            using IDbConnection db = new NpgsqlConnection(ConnectionString);
            db.Update(product);
        }

        public void DeleteProduct(int id)
        {
            using IDbConnection db = new NpgsqlConnection(ConnectionString);
            db.Delete(new Product { Id = id });
        }
    }
}