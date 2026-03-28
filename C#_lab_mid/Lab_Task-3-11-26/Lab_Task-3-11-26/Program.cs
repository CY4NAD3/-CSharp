using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_3_11_26
{
    class FoodItem
    {
        public string Name;
        public double Price;
        public int Quantity;

        // Virtual method
        public virtual double CalculateBill()
        {
            return Price * Quantity;
        }

        public void DisplayItem()
        {
            Console.WriteLine("Food Item: " + Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Quantity);
        }
    }

    class Pizza : FoodItem
    {
        public override double CalculateBill()
        {
            double total = (Price * Quantity) + 50; // service charge
            return total;
        }
    }

    class Pasta : FoodItem
    {
        public override double CalculateBill()
        {
            double total = (Price * Quantity) + 30; // packaging charge

            if (Quantity > 20)
            {
                total = total - (total * 0.05); // 5% discount
            }

            return total;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Select Food Item:");
            Console.WriteLine("1. Pizza");
            Console.WriteLine("2. Pasta");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            FoodItem item;

            if (choice == 1)
            {
                item = new Pizza();
                item.Name = "Pizza";
            }
            else
            {
                item = new Pasta();
                item.Name = "Pasta";
            }

            item.Price = price;
            item.Quantity = quantity;

            Console.WriteLine("\nOrder Details:");
            item.DisplayItem();

            double totalBill = item.CalculateBill();

            Console.WriteLine("Total Bill: " + totalBill);
        }
    }
}