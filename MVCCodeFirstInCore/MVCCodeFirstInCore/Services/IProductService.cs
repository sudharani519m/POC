using MVCCodeFirstInCore.Models;

namespace MVCCodeFirstInCore.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();

        Product? GetProductById(int id);

        void createProduct(Product product);
    }

}
