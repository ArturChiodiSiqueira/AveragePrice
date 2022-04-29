using System;

namespace PrecoMedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inform the quantity of products: ");

            int quantity = int.Parse(Console.ReadLine());

            Product[] vector = new Product[quantity];

            Console.WriteLine("\nEnter the product and price below!");
            for (int i = 0; i < quantity; i++)
            {
                Console.Write("#{0}: ", i);
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vector[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < quantity; i++)
            {
                sum += vector[i].Price;
            }

            double average = sum / quantity;
            Console.WriteLine("\nAverage price = " + average.ToString("F2"));
            Console.ReadKey();
        }
    }
}
