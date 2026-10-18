namespace Route.ADV01._2_GenericInterfaces
{
    internal class ProductRepository : IRepository<Product>
    {
        private List<Product> products = [];
        public void Create(Product entity)
        {
            Product product = new Product(entity.Id, entity.Name, entity.Price);
            products.Add(product);
        }

        public void Delete(int id)
        {
            Product? productToDelete = GetById(id);
            products.Remove(productToDelete!);
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                    return product;       
            }

            return new Product(-1, "NA", 0);
        }

        public void Update(int id, Product entity)
        {
            Product? productToUpdate = GetById(id);

            if (productToUpdate != null)
            {
                productToUpdate.Name = entity.Name;
                productToUpdate.Price = entity.Price;
            }
            
        }
    }
}
