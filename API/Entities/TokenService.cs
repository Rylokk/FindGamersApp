namespace API.Entities
{
    public interface TokenService
    {
        string CreateToken(AppUser user);
        
    }
}