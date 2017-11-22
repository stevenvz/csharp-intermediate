using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            Console.WriteLine(rating == 0 ? "Promoted to Level 1" : "Promoted to Level 2");
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}