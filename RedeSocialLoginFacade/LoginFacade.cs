using System;
using System.Collections.Generic;
using System.Text;

namespace RedeSocialLoginFacade
{
    public class LoginFacade : ILoginFacade
    {
        private readonly ILoginFacebook _loginFacebook;

        public LoginFacade(ILoginFacebook loginFacebook)
        {
            _loginFacebook = loginFacebook;
        }

        public void RealizarLoginRedeSocial(string email)
        {
            _loginFacebook.RealizarLoginFacebook(email);
        }

    }
}
