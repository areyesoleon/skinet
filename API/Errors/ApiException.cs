using API.Erros;

namespace API.Errors
{
    public class ApiException : ApiErrors
    {
        public ApiException(int statusCode, string mEssage = null, string details = null) : base(statusCode, mEssage)
        {
            Details = details;
        }

        public string Details { get; set; }
    }
}