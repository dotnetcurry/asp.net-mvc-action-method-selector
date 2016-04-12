using System.Collections.Generic;

namespace MVC_CustomActionMethodSelector.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
    }

    public class ElectronicsProductsDatabase : List<Product>
    {
        public ElectronicsProductsDatabase()
        {
            Add(new Product() { ProductId = 1, ProductName = "Desktop", Price = 34000, Category = "Electronics" });
            Add(new Product() { ProductId = 2, ProductName = "Laptop",  Price = 34000, Category = "Electronics" });
            Add(new Product() { ProductId = 3, ProductName = "Router",  Price = 34000, Category = "Electronics" });
            Add(new Product() { ProductId = 4, ProductName = "Mouse",   Price = 34000, Category = "Electronics" });
            Add(new Product() { ProductId = 5, ProductName = "USB HDD", Price = 34000, Category = "Electronics" });
            Add(new Product() { ProductId = 6, ProductName = "LCD",     Price = 34000, Category = "Electronics" });
        }
    }

    public class DataAccessElectronics
    {
        public List<Product> GetDataElectronics()
        {
            return new ElectronicsProductsDatabase();
        }
    }

    public class MechanicalProductsDatabase : List<Product>
    {
        public MechanicalProductsDatabase()
        {
            Add(new Product() { ProductId = 1, ProductName = "JCB", Price = 314000, Category = "Mechanical" });
            Add(new Product() { ProductId = 2, ProductName = "Tractor", Price = 134000, Category = "Mechanical" });
            Add(new Product() { ProductId = 3, ProductName = "Leath Machine", Price = 74000, Category = "Mechanical" });
            Add(new Product() { ProductId = 4, ProductName = "Crusher", Price = 104000, Category = "Mechanical" });
            Add(new Product() { ProductId = 5, ProductName = "Mixer", Price = 143000, Category = "Mechanical" });
        }
    }

    public class DataAccessMechanical
    {
        public List<Product> GetDataMechanical()
        {
            return new MechanicalProductsDatabase();
        }
    }
}