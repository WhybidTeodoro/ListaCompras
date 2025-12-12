namespace ListaCompras.Models;

public class ShoppingItem
{
    //Identificador unico do item
    public int Id { get; set; }
    //Diz a qual lista o item pertence 
    public int ShoppingListId { get; set; }
    //Nome do produto
    public string Name { get; set; } = string.Empty;
    //Preço unitario do item
    public decimal UnitPrice { get; set; }
    //Quantidade de item comprados
    public int Quantity { get; set; }
    //valor final do item
    public decimal TotalPrice { get; set; }
    //Possibilida verificar se o item da lista ja foi comprado
    public bool Isbought { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ShoppingList? ShoppingList { get; set; }

}
