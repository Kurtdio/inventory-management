using System;

namespace InventoryManagement.Services
{
    public class InventoryService
    {
        private string[,] products =
        { { "Apples", "Milk", "Bread" },
            { "10", "5", "20" }};

        private string[] initialStock = { "10", "5", "20" };

       
        public string[,] GetInventory()
        {
            return products;
        }

       
        public void UpdateStock(int index, string newStock)
        {
            if (index >= 0 && index < products.GetLength(1))
            {
                products[1, index] = newStock;
            }
        }

       
        public void ResetInventory()
        {
            for (int i = 0; i < initialStock.Length; i++)
            {
                products[1, i] = initialStock[i];
            }
        }
    }
}
