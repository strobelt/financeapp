using System;

namespace WebApi.Models
{
    public class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public long CategoryId { get; set; }
        public Category Category {get; set; }
        public string Description { get; set; }
    }
}