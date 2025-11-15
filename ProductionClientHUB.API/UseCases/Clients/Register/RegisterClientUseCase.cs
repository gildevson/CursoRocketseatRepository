using ProductionClientHUB.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductionClientHUB.Communication.Requests;
using ProductionClientHUB.Exception.ExceptionsBase;

namespace ProductionClientHUB.Communication.UseCases.Clients.Register {
    public class RegisterClientUseCase {


        public ResponseClientJson Execute(RequestClientJson request) {

           var validator = new RegisterClientValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false) {
                throw new ProductClientHubException("Erro nos dados recebidos"); //
            }
            //SE FOR VALIDO CONTINUA REGRA DE NEGOCIO

            return new ResponseClientJson();
            
        }
    }
}
