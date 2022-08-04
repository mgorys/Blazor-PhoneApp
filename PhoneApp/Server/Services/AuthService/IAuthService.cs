namespace PhoneApp.Server.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword);
        Task<ServiceResponse<string>> Login(string email, string password);
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<bool> UserExists(string email);
        int GetUserId();
    }
}