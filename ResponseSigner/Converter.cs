using System;
//dotnet add package Newtonsoft.Json
using Newtonsoft.Json;
using Model.Pacs008;
using Model;

namespace ResponseSigner
{
    public class Converter
    {
        public static string process(string message008)
        {
            try 
            {
                Pacs008 pacs008 = JsonConvert.DeserializeObject<Pacs008>(message008);

                string message002 = Serializer.process(pacs008);

                string msgSigned = HSMConn.Post(message002);

                return msgSigned;
 
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}