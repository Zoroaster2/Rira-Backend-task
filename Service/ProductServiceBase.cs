using Rira_Backend_task.Models;

namespace Rira_Backend_task.Service
{
    public abstract class ProductServiceBase
    {
        protected List<Product> _products;
        protected ProductServiceBase(List<Product> products) { _products = products; }

        //for task number 1
        public abstract IEnumerable<Product> GetProductByCategory(Categories category);

        //for task number 2
        public abstract Product GetMostExpensiveProduct();

        //for task number 3
        public abstract Decimal GetTotalPriceOfAllProduct();

        //for task number 4 
        public abstract Dictionary<Categories, List<Product>> GetProductsByCategory();

        //for task number 5
        public abstract Decimal AveragePriceOfAllProduct();

    }
}
