using System;
using FinalTask7;

DateTime today = DateTime.Now;

Console.WriteLine("Выберите вариант получения заказа:\n1.Самовывоз из магазина\n2.Доставка на дом");
var chooseNumber = Console.ReadLine();

Console.WriteLine();

switch (chooseNumber)
{
    case "1":
        {
            ShopDelivery shopDelivery = new(today.AddDays(2));

            Order<ShopDelivery, string> shopOrder = new(shopDelivery, "SH-00000001");

            shopOrder.DisplayOrderInfo();

            break;
        }

    case "2":
        {
            Console.WriteLine("Введите адресс доставки заказа: ");
            string address = Console.ReadLine();

            Console.WriteLine("Введите имя получателя заказа: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию получателя заказа: ");
            string surname = Console.ReadLine();

            Customer customer = new(name, surname);

            HomeDelivery homeDelivery = new(customer, address, today.AddDays(3));

            Order<HomeDelivery, string> homeOrder = new(homeDelivery, "HM-00000001");

            homeOrder.DisplayOrderInfo();

            break;
        }

    default:
        {
            Console.WriteLine("Введен некорректный вариант");
            break;
        }
}

class Order<TDelivery, TNumb> where TDelivery : Delivery
{
    public TDelivery Delivery;
    public TNumb Id;

    public Order(TDelivery delivery, TNumb orderNumber)
    {
        Delivery = delivery;
        Id = orderNumber;
    }

    public void DisplayOrderInfo()
    {
        Console.WriteLine();

        if (Delivery is HomeDelivery)
        {
            Console.WriteLine($"Номер вашего заказа: {Id}");
            Delivery.Deliver();
        }
        if (Delivery is ShopDelivery)
        {
            Console.WriteLine($"Номер вашего заказа: {Id}");
            Delivery.Deliver();
        }
    }
}
