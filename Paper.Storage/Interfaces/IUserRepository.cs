namespace Paper.Storage.Interfaces
{
    internal interface IUserRepository
    {
        public Task<bool> RegisterNewUser();
    }
}