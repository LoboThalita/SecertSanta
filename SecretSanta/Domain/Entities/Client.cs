namespace SecretSanta.Domain.Entities;

public class Client : BaseEntity
{
    public string Email { get; set; }
    public string Password { get; set; }
}
