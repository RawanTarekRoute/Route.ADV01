namespace Route.ADV01._2_GenericInterfaces
{
    internal class Product : IComparable<Product>
    {
        public Product()
        {

        }
        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Product? other)
        {
            //if (Price > other.Price)
            //    return 1;
            //else if (Price < other.Price)
            //    return -1;
            //else
            //    return 0;

            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Price}";
        }
    }
}
