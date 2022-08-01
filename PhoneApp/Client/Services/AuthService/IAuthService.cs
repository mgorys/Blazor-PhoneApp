namespace PhoneApp.Client.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request);
        Task<ServiceResponse<string>> Login(UserLogin request);
        Task<ServiceResponse<int>> Register(UserRegister request);
    }
}