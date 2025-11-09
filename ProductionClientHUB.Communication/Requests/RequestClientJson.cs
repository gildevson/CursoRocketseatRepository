using System;
using System.Data;

namespace ProductionClientHUB.Communication.Requests {
    public class RequestClientJson {
        public string Name { get; set; } = string.Empty; // Estou atribuindo name de string vazia 
        public string Email { get; set; } = string.Empty;// Estou atribuindo Email de string vazia 
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}

