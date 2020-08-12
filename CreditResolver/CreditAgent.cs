namespace Credit
{
    public class CreditAgent
    {
        public static bool process(string message) {

            string result = CredDecConn.Post(message);

            return result.Contains("Authorized");
            
        } 
    }
}