using Rira_Backend_task.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace Rira_Backend_task.Service
{
    public class ProductService : ProductServiceBase
    {
        public ProductService(List<Product> products) : base(products) { }

        //LINQ Query to get average price of all products
        public override decimal AveragePriceOfAllProduct()
        {
            //This goes through every Product in the _products list.
            //It takes each p.Price and calculates the average value.

            return _products.Average(p => p.Price);
        }

        //LINQ Query to get product with highest price
        public override Product GetMostExpensiveProduct()
        {
            //OrderByDescending(p => p.Price) sorts the list from highest to lowest price.
            //FirstOrDefault() gets the first item from the sorted list
            //FirstOrDefault() also makes sure it doesn’t crash if the list is empty

            return _products.OrderByDescending(p => p.Price).FirstOrDefault();
        }

        // LINQ Query to filter by category
        public override IEnumerable<Product> GetProductByCategory(Categories category)
        {
            //This LINQ query filters the _products list and returns only the products where Category == category.
            //In this case, it returns all products in Category1.

            return _products.Where(p => p.Category == category);
        }

        //Its for Getting the products by category
        public override Dictionary<Categories, List<Product>> GetProductsByCategory()
        {
            //GroupBy(p => p.Category) groups all products based on their category
            //ToDictionary converts the group into a Dictionary<Categories, List<Product>>
            //The key is the category, and the value is the list of products in that category

            return _products.GroupBy(p => p.Category).ToDictionary(g => g.Key, g => g.ToList());
        }

        //Total price of all products
        public override decimal GetTotalPriceOfAllProduct()
        {

            //It adds up the value from every item in the collection.
            //p => p.Price tells it to sum only the prices.

            return _products.Sum(p => p.Price);
        }
    }
}
