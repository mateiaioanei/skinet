using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string mesage = null)
        {
            StatusCode = statusCode;
            Mesage = mesage ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Mesage { get; set; }
        
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch 
            {
                400 => "A bad request, you have made",
                401 => "Authorize, you are not",
                404 => "Resource found, it was not",
                500 => "Errors are the path to the dark side"
            };
        }
    }
}