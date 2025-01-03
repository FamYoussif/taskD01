namespace taskD01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallCarpets, largeCarpets;
            int priceSmallCarpet = 25;
            int priceLargeCarpet = 35;
            int cost = 0;
            double totalCost = 0;
            double tax = 0.06;
            Console.WriteLine("==== Welcome to Islam's Carpet Cleaning Service =====");
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.Write("Number of small carpets: ");
            smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets: ");
            largeCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Price per small carpet:{priceSmallCarpet:C} ");
            Console.WriteLine($"Price per large carpet:{priceLargeCarpet:C}");
            cost = smallCarpets * priceSmallCarpet + largeCarpets * priceLargeCarpet;
            tax = tax * cost;
            totalCost = cost + tax;
            Console.WriteLine($"Cost:{cost:C}");
            Console.WriteLine($"Tax:{tax:C}");
            Console.WriteLine("=============================");
            Console.WriteLine($"Total Estimate:{totalCost:C}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
