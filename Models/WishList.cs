namespace Shamazon.Models
{
    public class WishList
    {   
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public decimal ItemPrice { get; set; }
        public string ItemExtendedDescription { get; set; }
        public int ItemQuantity { get; set; }
        

        public WishList()
        {

        }
    }
}