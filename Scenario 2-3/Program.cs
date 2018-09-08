using System;

namespace Scenario_2_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Product p = new Product
            {
                Name = "IPhone",
                Price = 1299
            };
            Console.WriteLine(p.ToString());
        }
    }
}
