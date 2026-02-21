using InventoryManagement.Views;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryView view = new InventoryView();
            view.Run();
        }
    }
}
