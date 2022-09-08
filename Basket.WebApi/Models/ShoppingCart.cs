namespace Basket.WebApi.Models;

public class ShoppingCart
{
    public string UserName { get; set; } = string.Empty;

    public ICollection<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

    public decimal TotalPrice
    {
        get
        {
            return Items.Sum(x => x.Price * x.Quantity);
        }
    }

    public ShoppingCart(string userName)
    {
        UserName = userName;
    }
}