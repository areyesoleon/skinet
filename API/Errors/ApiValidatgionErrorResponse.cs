using API.Erros;

namespace API.Errors
{
    public class ApiValidatgionErrorResponse : ApiErrors
    {
        public ApiValidatgionErrorResponse() : base(400)
        {
        }

        public IEnumerable<string> Errors { get; set; }
    }
}