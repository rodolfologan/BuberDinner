namespace BuberDinner.Aplication.Services.Authentication;

public interface IAuthenticaionService
{
    AuthenticationResult Login(string email, string password);
    AuthenticationResult Register(string firstName, string lastName, string email, string password);
}