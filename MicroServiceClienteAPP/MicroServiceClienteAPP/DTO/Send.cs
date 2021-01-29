using System;

namespace MicroServiceClienteAPP.DTO
{
    public class Send
    {
        public string mensagem { get; set; }
        public string identificador { get; set; }
        public DateTime timestamp { get; set; }
        public string requisicao { get; set; }
    }
}
