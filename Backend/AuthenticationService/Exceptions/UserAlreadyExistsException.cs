using System;

namespace AuthenticationService.Exceptions
{
    #region Exception
    public class UserAlreadyExistsException : ApplicationException
    {
        public UserAlreadyExistsException() : base() { }
        public UserAlreadyExistsException(string message) : base(message) { }
    }
    #endregion
}
