using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignmentDataBaseMKJ.Shop
{
    public static class Handler
    {
        /// <summary>
        /// Shows all the categorys and lets the user pick one
        /// </summary>
        /// <returns>int of the chosen category</returns>
        public static int Categories()
        {
            var categories = Databasedapper.ShowAllCategories();

            Console.WriteLine("Number\t Name");
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.Id}\t{category.Name}");
            }
            Console.WriteLine("\nChose a Category Number: ");
            return Program.MenuReader(categories.Count());
        }       





        public static int ShowAndPickProduct(int num)
        {
            var products = Databasedapper.ShowSpecificProducts(num);

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id}\t{product.Name}\t{product.Price}");
            }
            Console.WriteLine("\nChose a Product Number: ");
            return Program.MenuReader(products.Count());
        }
    }
}
