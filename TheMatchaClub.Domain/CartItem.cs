namespace TheMatchaClub.Domain;

public class CartItem
{
    public int ItemId { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
