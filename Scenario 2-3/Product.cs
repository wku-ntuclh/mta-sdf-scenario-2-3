
namespace Scenario_2_3
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "\t Price: $" + Price.ToString("0.##");
        }
    }
}
