namespace Paper
{
    public interface ITokenService
    {
        public string GenerateToken(string userId);

        public bool Validate(string token, out string UserId);

    }
}