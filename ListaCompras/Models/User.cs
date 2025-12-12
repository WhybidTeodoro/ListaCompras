namespace ListaCompras.Models;

//Classe para guardar os dados do usuario
public class User
{
    //Primary key
    public int Id { get; set; }
    //Nome do usuario
    public string Name { get; set; } = string.Empty;
    //Email do usuario
    public string Email { get; set; } = string.Empty;
    //Senha do usuario
    public string Password { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<ShoppingList> ShoppingLists { get; set; } = null!;
}
