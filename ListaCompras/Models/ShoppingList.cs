namespace ListaCompras.Models;

//Classe para representar uma lista de compras
public class ShoppingList
{
    //Chave primaria
    public int Id { get; set; }
    //Chave secundaria(Diz a que usuario a lista pertence)
    public int UserId { get; set; }
    //Nome da lista de compras, Ex: Compra do mes, Churrasco, etc...
    public string Title { get; set; } = string.Empty;
    //Data da criação da lista
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public User? User { get; set; }
    //Relacionamento 1 pra muitos(Uma Lista possui varios items)
    public ICollection<ShoppingItem> Items { get; set; } = null!;
}
