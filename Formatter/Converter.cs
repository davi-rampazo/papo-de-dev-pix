using System;
//dotnet add package Newtonsoft.Json
using Newtonsoft.Json;
using Model.Pacs008;

namespace Formatter
{
    public class Converter
    {
        public static string process(string message)
        {
            try 
            {
                string msgUnsigned = HSMConn.Post(message);
                
                Pacs008 pacs008 = Serializer.Deserializer.process(msgUnsigned);
                pacs008.AppHdr.Validationstatus = "Pending";
                return JsonConvert.SerializeObject(pacs008, Newtonsoft.Json.Formatting.Indented);
 
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}