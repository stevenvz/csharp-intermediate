using System;

namespace L33_Interfaces_and_Testability
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public Shipment Shipment { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }
}