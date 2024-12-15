namespace Final_Project
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products = new List<Product>();

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
        public Product GetProduct(int id)
        {
            return products[id];
        }
        


        public Product GetProductById(int id)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }



    }
}
