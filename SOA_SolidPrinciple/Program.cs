using System;

namespace SOA_SolidPrinciple
{
    public class OrderProcessor
    {
        public void PlaceOrder(string productName, double price)
        {
            Console.WriteLine($"Order placed successfully for: {productName} at ${price}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Available Products:");
            Console.WriteLine("1. Laptop - $1000");
            Console.WriteLine("2. Smartphone - $700");
            Console.WriteLine("3. Headphones - $150");
            Console.WriteLine("4. Smartwatch - $250");
            Console.WriteLine("5. Tablet - $500");

            Console.Write("Enter the number of the product you want to buy: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            string productName = "";
            double price = 0;

            switch (choice)
            {
                case 1:
                    productName = "Laptop";
                    price = 1000;
                    break;
                case 2:
                    productName = "Smartphone";
                    price = 700;
                    break;
                case 3:
                    productName = "Headphones";
                    price = 150;
                    break;
                case 4:
                    productName = "Smartwatch";
                    price = 250;
                    break;
                case 5:
                    productName = "Tablet";
                    price = 500;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            OrderProcessor orderProcessor = new OrderProcessor();
            orderProcessor.PlaceOrder(productName, price);
        }
    }
}
