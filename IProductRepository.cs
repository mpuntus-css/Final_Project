namespace Final_Project
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);
        Product GetProductById(int id);
    }
}
