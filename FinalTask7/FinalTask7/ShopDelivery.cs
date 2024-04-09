namespace FinalTask7
{
    class ShopDelivery : Delivery
    {
        DateTime dateOrder;

        public ShopDelivery(DateTime dateOrderReady)
        {
            Address = "ул. Москва, д. 13";
            dateOrder = dateOrderReady;
        }

        internal override void Deliver()
        {
            Console.WriteLine($"Заказ будет ожидать с {dateOrder.ToShortDateString()} до {dateOrder.AddDays(14).ToShortDateString()} по адресу: {Address}");
        }
    }
}

