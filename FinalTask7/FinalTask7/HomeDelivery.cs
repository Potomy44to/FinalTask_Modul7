namespace FinalTask7
{
    class HomeDelivery : Delivery
    {
        DateTime deliveryDate;
        Customer customer;

        public HomeDelivery(Customer orderCustomer, string deliveryAddress, DateTime planeDeliveryDate)
        {
            Address = deliveryAddress;
            deliveryDate = planeDeliveryDate;
            customer = orderCustomer;

        }

        internal override void Deliver()
        {
            Console.WriteLine($"Ожидайте курьера {deliveryDate.ToShortDateString()} по адресу: {Address} \nПолучатель: {customer.lastName} {customer.firstName}");
        }
    }
}

