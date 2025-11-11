using System.Collections.Generic;

namespace ProductionClientHUB.Communication.Responses {
    public class ResponseErrorMessagesJson {
        public List<string> Errors { get; private set; }

        public ResponseErrorMessagesJson(string message) {
            Errors = new List<string> { message };
        }
    }
}
