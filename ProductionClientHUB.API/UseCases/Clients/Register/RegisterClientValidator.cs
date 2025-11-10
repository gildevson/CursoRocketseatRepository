using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductionClientHUB.Communication.Requests;

namespace ProductionClientHUB.Communication.UseCases.Clients.Register {
    internal class RegisterClientValidator : AbstractValidator<RequestClientJson> {
        // para essa classe funcionar como validator, precisa herdar de AbstractValidator<RegisterClientCommand> Herança 

        public RegisterClientValidator() { // digite ctor ele cria um construtor

            RuleFor(client => client.Name).NotEmpty().WithMessage("O nome nãp pode ser vazia."); // NoEmpty () valida se o campo não está vazio
            RuleFor(client => client.Email).EmailAddress().WithMessage("O email não é valido."); // FluentValidation ja possui função para validar
        }
    }
}
