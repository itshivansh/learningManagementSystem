using AuthenticationService.models;

namespace AuthenticationService.Services
{
    #region Service_Interface
    public interface IAuthService
    {
        bool LoginUser(User user);
        bool RegisterUser(User user);
    }
    #endregion
}
