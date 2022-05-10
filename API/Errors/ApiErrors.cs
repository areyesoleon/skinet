namespace API.Erros
{
    public class ApiErrors
    {
        public ApiErrors(int statusCode, string mEssage = null)
        {
            StatusCode = statusCode;
            MEssage = mEssage ?? GetDefaultMessageStatusCode(statusCode);
        }


        public int StatusCode { get; set; }
        public string MEssage { get; set; }



        private string GetDefaultMessageStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, yo have made",
                401 => "Authorized, you are not",
                404 => "Resource found, it was not",
                500 => "Errors are the path to the dark side. Errors lead to anger. Anger leads to hate. Hate leads co career change",
                _ => null
            };
        }
    }
}