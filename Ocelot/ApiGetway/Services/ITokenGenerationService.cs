namespace ApiGetway.Services;

public interface ITokenGenerationService
{
    public string GenerateToken(string userName);
}