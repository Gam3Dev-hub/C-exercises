namespace MVCBasicAssignment2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        //private List<Product> _purchasedProducts = new List<Product>();

        //public void AddProduct(Product product)
        //{
        //    _purchasedProducts.Add(product);
        //}
    }
}
