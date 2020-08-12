using System.Net;

namespace BacenReceiver 
{
    class BacenConn 
    {
        public static string GetMessage()
        {
            string url = "https://localhost:5001/api/bacen";

            WebClient client = new WebClient();     

            return client.DownloadString (url);       
        }

    }

}