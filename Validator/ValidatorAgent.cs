namespace Validation
{
    public class ValidatorAgent
    {
        public static bool process(string message) {

            string result = ValDecConn.Post(message);

            return result.Contains("Validated");
            
        } 
    }
}