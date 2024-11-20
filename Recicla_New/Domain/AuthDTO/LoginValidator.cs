using Domain.Common.AuthDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AuthDTO
{
    public class LoginValidator
    {
        public ValidationResult ValidateLogin(LoginDTO loginDto)
        {
            var validationResult = new ValidationResult();

            if (string.IsNullOrEmpty(loginDto.Username) || string.IsNullOrWhiteSpace(loginDto.Username))
            {
                validationResult.Errors.Add("Preencha o Campo de Usuário.");
            }

            if (string.IsNullOrEmpty(loginDto.Password) || string.IsNullOrWhiteSpace(loginDto.Password))
            {
                validationResult.Errors.Add("Preencha o Campo de Senha.");
            }

            if (loginDto.Password.Length < 6) // Exemplo de senha com critério mínimo
            {
                validationResult.Errors.Add("A Senha deve conter no mínimo 6 caracteres.");
            }

            return validationResult;
        }
    }
}
