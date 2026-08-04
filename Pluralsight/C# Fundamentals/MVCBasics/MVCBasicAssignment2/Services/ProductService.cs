using MVCBasicAssignment2.Models;
using MVCBasicAssignment2.Data;

namespace MVCBasicAssignment2.Services
{
    public class ProductService : IProductService
    {
       private readonly AppDBContext _dbContext;
        public ProductService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }
        public Product GetProductById(int id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }
        public void UpdateProduct(Product product)
        {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
        }
        public void deleteProduct(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                _dbContext.SaveChanges();
            }
        }
    }
}
