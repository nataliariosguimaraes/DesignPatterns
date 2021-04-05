using System;

namespace RedeSocialLoginFacade
{
    class Program
    {
        private readonly ILoginFacade _loginFacade;
        static void Main(string[] args)
        {
            var login = new LoginRedeSocialService(new LoginFacade(new LoginFacebook()));
            login.LogarRedeSocial("email@email.combr");

        }

    }
}

