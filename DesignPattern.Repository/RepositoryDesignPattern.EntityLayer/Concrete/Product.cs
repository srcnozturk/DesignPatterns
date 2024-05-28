﻿namespace RepositoryDesignPattern.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public int ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
