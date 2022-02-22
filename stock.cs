namespace Warehouse
{
    public class Stock
    {
        public Item Item { get; set;}
        public int Amount { get; set;}
        public int SellIn { get; set;}
        public int Price { get; set;}

        public Stock(Item item, int amount , int price, int sellin)
        {
            Item = item;
            Amount = amount;
            Price = price;
            SellIn = sellin;
        }

    }
}