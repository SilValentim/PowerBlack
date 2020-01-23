using System;
using System.Collections.Generic;
using System.Text;
using PowerBlack.Model.Entidades;

namespace PowerBlack.ViewModel.Login
{
    public class LoginViewModel
    {
        public Model.Entidades.Login _login { get; set; }

        public LoginViewModel()
        {
            _login = new Model.Entidades.Login()
            {
                Email = "Testando@123.com"
            };
        }

    }
}
