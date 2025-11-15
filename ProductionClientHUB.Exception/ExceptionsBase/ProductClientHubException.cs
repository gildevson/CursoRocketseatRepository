using System;

namespace ProductionClientHUB.Exception.ExceptionsBase {
    public class ProductClientHubException : SystemException {
        public ProductClientHubException(string errorMessageerror) : base(errorMessageerror) {  // esse base chmama de onde esta vindo
            
        }
    }
}
