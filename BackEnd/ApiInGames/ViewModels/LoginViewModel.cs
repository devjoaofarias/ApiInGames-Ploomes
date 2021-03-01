using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInGames.ViewModels
{
    public class LoginViewModel
    {
        //Definindo que é obrigatório informar um email para realizar o login
        [Required(ErrorMessage = "Informe o email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //Definindo que é obrigatório informar uma senha para realizar o login
        [Required(ErrorMessage = "Informe a senha!")]
        [DataType(DataType.EmailAddress)]
        public string Senha { get; set; }
    }
}
