using SecretSanta.Domain.Entities;
using SecretSanta.Domain.Interfaces;

namespace SecretSanta.Service;

public class CreateAccountService : ICreateAccountService
{
    public bool CheckEmailAlreadyExist(string email)
    {
        throw new NotImplementedException();
    }

    public bool CreateNewAccount(Client user)
    {
        throw new NotImplementedException();
    }
}
