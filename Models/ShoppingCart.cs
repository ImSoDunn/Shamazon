namespace Shamazon.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public decimal ItemPrice { get; set; }
        public int ItemQuantity { get; set; }

        public ShoppingCart()
        {

        }
    }
}