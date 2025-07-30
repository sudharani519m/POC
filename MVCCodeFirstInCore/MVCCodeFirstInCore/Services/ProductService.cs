using MVCCodeFirstInCore.Models;

namespace MVCCodeFirstInCore.Services
{
    public class ProductService : IProductService
    {
        private readonly DotnetCoreDBContext _context;
         
        public ProductService(DotnetCoreDBContext context)
        {
            _context = context;
        }
        public void createProduct(Product product)
        {
           _context.Products.Add(product);
           _context.SaveChanges();

        }

        public List<Product> GetAllProducts()
        {
          var ProductList =   _context.Products.OrderBy(x => x.Name).ToList();
            return ProductList;
        }

        public Product? GetProductById(int id)
        {
            return _context.Products.Find(id);
        }
    }
}
