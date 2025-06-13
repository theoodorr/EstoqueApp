namespace EstoqueApp.Models;

public class Produto
{
    public string Name;

    public string Code;

    public float Price;

    public int Quantity;

    public Produto(string name)
    {
        Name = name;
        Code = "0";
        Price = 0;
        Quantity = 1;
    }
}
