using BrapShop.Data.models;

namespace BrapShop.Data.Interfaces
{
    public interface IUserRepository
    {
        ApplicationUser GetUserById(string id);
    }
}
