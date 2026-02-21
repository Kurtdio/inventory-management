using System;
using InventoryManagement.Services;

namespace InventoryManagement.Views
{
    public class InventoryView
    {
        private InventoryService service = new InventoryService();

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== Inventory Menu ===");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. Reset Inventory");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayInventory();
                        break;

                    case "2":
                        UpdateStock();
                        break;

                    case "3":
                        service.ResetInventory();
                        Console.WriteLine("Inventory has been reset.");
                        break;

                    case "4":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        private void DisplayInventory()
        {
            var products = service.GetInventory();

            Console.WriteLine("\nCurrent Inventory:");
            for (int i = 0; i < products.GetLength(1); i++)
            {
                Console.WriteLine($"{i + 1}. {products[0, i]} - Stock: {products[1, i]}");
            }
        }

        private void UpdateStock()
        {
            DisplayInventory();

            Console.Write("Select product number to update: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Enter new stock quantity: ");
            string newStock = Console.ReadLine();

            service.UpdateStock(index, newStock);
            Console.WriteLine("Stock updated successfully.");
        }
    }
}
