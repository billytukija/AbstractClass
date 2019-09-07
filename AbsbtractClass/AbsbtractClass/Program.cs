using System;

namespace AbsbtractClass
{

    public abstract class Entity
    {
        public string Name { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// Implementing the class Entity, we gonna have all Entity properties in Product class
    /// </summary>
    public class Product : Entity
    {
        public double Price { get; set; }
        public long ProductId { get; set; }
        public DateTime ValidationDate { get; set; }
    }


    /// <summary>
    /// Implementing the class Entity, we gonna have all Entity properties in Market class
    /// </summary>
    public class Market : Entity
    {
        public long MarketId { get; set; }
        public string Type { get; set; }
        public string Style { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product
            {
                Price = 15.8,
                Name = "Coca-Cola",  // Notice that the property 'Name' is not dclared directly in the prodct class
                Description = "American drinking product", // Notice that the property 'Description' is not dclared directly in the prodct class
                Created = DateTime.Now.AddYears(-30), // Notice that the property 'Created' is not dclared directly in the prodct class
                CreatedBy = 1, // Notice that the property 'CreatedBy' is not dclared directly in the prodct class
                ValidationDate = DateTime.Now.AddYears(3)
            };


            var market = new Market
            {
                Name = "Assaí",  // Notice that the property 'Name' is not dclared directly in the prodct class
                // ...
            };
        }
    }
}
