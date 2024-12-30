using SecretSanta.Domain.Entities;

namespace SecretSanta.Domain.Interfaces;

public interface ICreateAccountService
{
    public bool CheckEmailAlreadyExist(string email);
    public bool CreateNewAccount(Client user);
}
