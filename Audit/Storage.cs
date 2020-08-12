using System;
using System.IO;
//dotnet add package Newtonsoft.Json
using Newtonsoft.Json;
using Model.Pacs008;
using Model;

namespace Audit
{
    public class Storage
    {
        public static void process(string message00X)
        {
            try 
            {
                string fileName = "";
                string msgType = "";
                string timeTag = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff-");
                if (message00X.Contains("pacs.002.spi"))
                {
                    fileName = timeTag + "pacs.002.msg";
                    msgType = "Pacs002";
                }
                else
                {
                    fileName = timeTag + "pacs.008.msg";
                    msgType = "Pacs008";
                }

                File.WriteAllText(fileName, message00X);

                Console.WriteLine("Message Type : " + msgType);
                Console.WriteLine("Message File : " + fileName);
 
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}