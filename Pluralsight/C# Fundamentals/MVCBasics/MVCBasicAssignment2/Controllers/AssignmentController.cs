using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using MVCBasicAssignment2.Models;
using MVCBasicAssignment2.Data;
using MVCBasicAssignment2.Services;


namespace MVCBasicAssignment2.Controllers
{
    public class AssignmentController : Controller
    {
        private static List<Customer>? Customers;

        private static List<Product>? Products;

        //private readonly AppDBContext _dbContext;
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;

        public AssignmentController(IProductService productService, ICustomerService customerService)
        {
            _productService = productService;
            _customerService = customerService;
        }



        //public AssignmentController(AppDBContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public IActionResult Index()
        {
            //var products = _dbContext.Products.ToList();
            var products = _productService.GetAllProducts();
            return View(products);
        }

        public IActionResult CustomerIndex()
        {
            //var customers = _dbContext.Customers.ToList();
            var customers = _customerService.GetAllCustomers();
            return View(customers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            
            if (ModelState.IsValid)
            {
                _productService.AddProduct(product);
                //_dbContext.Products.Add(product);
                //_dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

       

        public IActionResult Edit(int id) 
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                //var product = _productService.GetProductById(id);
                var existingProduct = _productService.GetProductById(product.Id);
                //var existingProduct = _productService.GetProductById(product.Id);
                if (existingProduct != null) 
                {
                    //_productService.UpdateProduct(existingProduct);
                    existingProduct.Name = product.Name;
                    existingProduct.Price = product.Price;
                    existingProduct.Description = product.Description;
                    existingProduct.Stock = product.Stock;
                    _productService.UpdateProduct(existingProduct);
                    //return View(product);
                    //return RedirectToAction("Index");
                }
                
                return RedirectToAction("Index");
            }
            return View(product);
        }


        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCustomer(Customer customer) 
        {
            if (ModelState.IsValid)
            {
                _customerService.AddCustomer(customer);
                return RedirectToAction("CustomerIndex");
            }
            return View(customer);
        }

        public IActionResult EditCustomer(int id)
        {
            if (ModelState.IsValid)
            {
                var customer = _customerService.GetCustomerById(id);
                return View(customer);
            }
            return View();
        }

        [HttpPost]
        public IActionResult EditCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                var existingCustomer = _customerService.GetCustomerById(customer.Id);
                if (existingCustomer != null)
                {
                    existingCustomer.FirstName = customer.FirstName;
                    existingCustomer.LastName = customer.LastName;
                    existingCustomer.Email = customer.Email;
                    existingCustomer.Phone = customer.Phone;
                    _customerService.UpdateCustomer(existingCustomer);
                }
                return RedirectToAction("CustomerIndex");
            }
            return View(customer);
        }



        public IActionResult CustomerDetails(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            return View(customer);
        }

        public IActionResult ProductDetails(int id)
        {
            var product = _productService.GetProductById(id);
            return View(product);
        }

        public IActionResult _CustomerPartial() 
        {
            return PartialView();
        }

        public IActionResult DisplayCustomerProducts()
        {
            return PartialView();
        }

        public IActionResult DeleteProduct(int id)
        {
            var product = _productService.GetProductById(id);
            if (product != null)
            {
                _productService.deleteProduct(id);
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult DeleteCustomer(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            if (customer != null)
            {
                _customerService.DeleteCustomer(id);
                return RedirectToAction("CustomerIndex");
            }
            return NotFound();
        }

        //[HttpPost]
        //public IActionResult Create(CreateCustomerVM customerVM)
        //{
        //    var customerID = HttpContext.Session.GetInt32("CustomerID") ?? 0;
        //    if(ModelState.IsValid)
        //    {
        //        customerID++;
        //        var customer = new Customer
        //        {
        //            Id = customerID,
        //            FirstName = customerVM.FirstName,
        //            LastName = customerVM.LastName,
        //            Email = customerVM.Email,
        //            Phone = customerVM.Phone

        //        };
        //        Customers ??= new List<Customer>();
        //        Customers.Add(customer);
        //        HttpContext.Session.SetInt32("CustomerID", customerID);
        //        var successMessage = $"Customer {customer.FirstName} {customer.LastName} with ID {customer.Id} created successfully!";
        //        TempData["CustomerSuccess"] = successMessage;
        //        return RedirectToAction("Index");
        //    }



        //    return View(customerVM);
        //}

        //[HttpPost]
        //public IActionResult Create(CreateProductVM productVM) {
        //    var productID = HttpContext.Session.GetInt32("ProductID") ?? 0;
        //    if (ModelState.IsValid){
        //        productID++;
        //        var product = new Product
        //        {
        //            Id = productID,
        //            Name = productVM.Name,
        //            Price = productVM.Price,
        //            Description = productVM.Description,
        //            Stock = productVM.Stock
        //        };
        //        Products ??= new List<Product>();
        //        Products.Add(product);
        //        HttpContext.Session.SetInt32("ProductID", productID);
        //        var successMessage = $"Product {product.Name} with ID {product.Id} created successfully!";
        //        TempData["ProductSuccess"] = successMessage;
        //        return View(productVM);
        //    }
        //    return RedirectToAction("Index");
        //}

        //[HttpPost]
        //public void AddCustomer(Customer customer)
        //{
        //    Customers ??= new List<Customer>();
        //    //if(customer == null)
        //    //{
        //    //    throw new ArgumentNullException(nameof(customer));
        //    //}
        //    if(!Customers.Contains(customer))
        //    {
        //        Customers.Add(customer);
        //    }
        //}

        //[HttpPost]
        //public void AddProductToCustomer(int customerId, Product product)
        //{
        //    var customer = Customers?.FirstOrDefault(c => c.Id == customerId);
        //    if (customer != null)
        //    {
        //        customer.AddProduct(product);
        //    }
        //}

    }
}
