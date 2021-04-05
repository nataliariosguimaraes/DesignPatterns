namespace RedeSocialLoginFacade
{
    public class LoginRedeSocialService : ILoginRedeSocial
    {
        private readonly ILoginFacade _loginFacade;

        public LoginRedeSocialService(ILoginFacade loginFacade)
        {
            _loginFacade = loginFacade;
        }

        public void LogarRedeSocial(string email)
        {
            _loginFacade.RealizarLoginRedeSocial(email);
        }
    }
}
