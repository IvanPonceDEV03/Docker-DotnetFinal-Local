using System.Security.Authentication;

namespace Dotnetfinal.Crosscutting.Exceptions;

public class UserNotActivatedException : AuthenticationException
{
    public UserNotActivatedException(string message) : base(message)
    {
    }
}
