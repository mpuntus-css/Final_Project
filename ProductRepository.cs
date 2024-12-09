namespace Final_Project
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();

        public IEnumerable<Product> GetAllProducts() => products;

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public Product GetProductById(int id) => products.FirstOrDefault(p => p.Id == id);

    }
}
