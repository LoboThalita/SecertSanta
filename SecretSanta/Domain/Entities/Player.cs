namespace SecretSanta.Domain.Entities;

public class Player : BaseEntity
{
    public string Email { get; set; }
    public int Phone { get; set; }
    public int IdFriend { get; set; }
    public int IdGame { get; set; }

}
