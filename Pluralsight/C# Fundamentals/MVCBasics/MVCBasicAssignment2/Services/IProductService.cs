using MVCBasicAssignment2.Models;

namespace MVCBasicAssignment2.Services
{
    public interface IProductService
    {
        void AddProduct(Product product);
        Product GetProductById(int id);
        public IEnumerable<Product> GetAllProducts();

        public void UpdateProduct(Product product);
        void deleteProduct(int id);

    }
}
