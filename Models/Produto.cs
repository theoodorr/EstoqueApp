namespace EstoqueApp.Models;

public class Produto
{
    public string Name { get; set; }

    public string Code { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public Produto(string name)
    {
        Name = name;
        Code = "0";
        Price = 0;
        Quantity = 1;
    }
}
