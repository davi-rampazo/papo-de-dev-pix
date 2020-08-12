using System.Net;

namespace BacenSender 
{
    class BacenConn 
    {
        public static string SendMessage(string message)
        {
            string url = "https://localhost:5001/api/bacen";

            WebClient client = new WebClient(); 
            client.Headers.Add("Content-Type","text/xml");
            return client.UploadString (url, message);       
        }

    }

}