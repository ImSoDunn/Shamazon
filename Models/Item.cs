﻿namespace Shamazon.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemExtendedDescription { get; set; }
        public decimal ItemPrice { get; set; }
        public int ItemQuantity { get; set; }

        public Item()
        {
           
        }
    }
}