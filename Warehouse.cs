namespace Warehouse
{
    public class Warehouse
    {
        public string Name { get; set;}
        
   

        public List<Stock> Stock { get; set;}

        public Warehouse( string name)

        {
            Name = name;
            Stock = new List<Stock>();
        }

        public void AddStock(Item item, int amount, int price, int sellIn){

        Stock.Add(new Stock(item, amount, price, sellIn));
        }

        public void PrintInventory()
        
        {
            Console.WriteLine($"Inventory of the warehouse: {Name}");
            foreach(Stock stockItem in Stock)
            {
                Console.WriteLine($"     {stockItem.Item.Name}: Price: £{stockItem.Price} Amount:{stockItem.Amount} Sell in {stockItem.SellIn}days");
            }
        }

    }
}