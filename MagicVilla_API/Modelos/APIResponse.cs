using System.Net;

namespace MagicVilla_API.Modelos
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsExitoso { get; set; } = true;

        public List<string>? ErrorMessage { get; set; }
        public object? Resultado { get; set; }
    }
}
