﻿namespace GetBestPossibleOrders
{
    public class Order
    {
        public enum OrderType
        {
            Buy,
            Sell
        }
        
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string Type { get; set; }
        public string Kind { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
    }
}
