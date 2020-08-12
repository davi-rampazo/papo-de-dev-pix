using System.Net;

namespace Validation 
{
    class ValDecConn 
    {
        public static string Post(string message)
        {
            string url = "https://localhost:6301/ValidationDecoupler/validate";

            WebClient client = new WebClient(); 
            client.Headers.Add("Content-Type","application/json");
            return client.UploadString (url, message);       
        }

    }

}