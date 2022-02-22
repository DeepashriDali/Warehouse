namespace Warehouse
{
    class Program
    {
        public static void Main(string[] args)
        {
            Warehouse warehouse1 = new Warehouse("London");
            Warehouse warehouse2 = new Warehouse("Edinburgh");
        

            Item bread = new Item("Bread");
            Item yogurt = new Item("Yogurt" );
            Item mushrooms = new Item("Mushrooms");
            warehouse1.AddStock(bread, 12,1,5);
            warehouse1.AddStock(yogurt, 25,1,9);
            warehouse1.AddStock(mushrooms, 34,3,7);
       
            warehouse2.AddStock(bread, 32,1,5);
            warehouse2.AddStock(yogurt, 65,1,9);
            warehouse2.AddStock(mushrooms, 74,3,7);

            warehouse1.PrintInventory();
            warehouse2.PrintInventory();

        }
    }
}