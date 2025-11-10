using ProductionClientHUB.Communication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductionClientHUB.Communication.Requests;

namespace ProductionClientHUB.Communication.UseCases.Clients.Register {
    public class RegisterClientUseCase {


        public ResponseClientJson Execute(RequestClientJson request) {

           var validator = new RegisterClientValidator();

            var result = validator.Validate(request);
            return new ResponseClientJson();
            
        }
    }
}
