using DemoPatron.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatron.TestConsoloAppNF
{
    class Program
    {
        static void Main(string[] args)
        {
            var Categories = new CategoryManager().
                GetCategories();
            foreach (var category in Categories)
            {
                Console.WriteLine($"Id: { category.CategoryID}, Name: { category.CategoryName} ");
            }
            Console.ReadLine();
        }
    }
}
