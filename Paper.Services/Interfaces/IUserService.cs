using Paper.Models.EndpointModels;

namespace Paper.Services.Interfaces
{
    public interface IUserService
    {
        public Task<bool> RegisterNewUser(string appleSubId, NewUser newUser);
    }
}
