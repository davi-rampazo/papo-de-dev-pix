using System.Net;

namespace ResponseSigner 
{
    class HSMConn 
    {
        public static string Post(string message)
        {
            string url = "https://localhost:6201/HSM/sign";

            WebClient client = new WebClient(); 
            client.Headers.Add("Content-Type","text/xml");
            return client.UploadString (url, message);       
        }

    }

}