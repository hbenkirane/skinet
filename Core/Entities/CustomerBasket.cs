using System.Collections.Specialized;

namespace Core.Entities;

public class CustomerBasket
{
    public CustomerBasket()
    {
    }

    public CustomerBasket(string id)
    {
        Id = id;
    }

    public string Id { get; set; }
    public List<BasketItem> Items { get; set; } = new List<BasketItem>();

    public int? DeliveryMethod { get; set; }

    public string ClientSecret { get; set; }

    public string PaymentIntentId { get; set; }

    public decimal ShippingPrice { get; set; }
}