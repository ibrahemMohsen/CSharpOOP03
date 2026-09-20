using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDeliveryManagementSystem
{
    internal class PriorityInternationalShipment: InternationalShipment
    {
        public PriorityInternationalShipment(
    string trackingCode,
    string destinationCountry,
    decimal customsFee)
    : base(trackingCode,destinationCountry, customsFee)
        {
        }
        public PriorityInternationalShipment(
                string trackingCode,
                string description,
                double weight,
                decimal deliveryFee,
                DeliveryAddress destination,
                string destinationCountry,
                decimal customsFee
            ) : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        public override sealed void GenerateCustomsReport()
        {
            Console.WriteLine("This is the Priority International Shipment customs report");
        }
    }
}
