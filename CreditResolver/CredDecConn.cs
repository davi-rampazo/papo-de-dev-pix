using System.Net;

namespace Credit 
{
    class CredDecConn 
    {
        public static string Post(string message)
        {
            string url = "https://localhost:6401/CreditDecoupler/authorize";

            WebClient client = new WebClient(); 
            client.Headers.Add("Content-Type","application/json");
            return client.UploadString (url, message);       
        }

    }

}