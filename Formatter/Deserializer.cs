using System;
using System.IO;
using System.Xml;
//dotnet add package Newtonsoft.Json
using Newtonsoft.Json;
using Model.Doc;
using Model.Head;
using Model.Pacs008;

namespace Serializer
{
    class Deserializer
    {
        public static Pacs008 process(string message)
        {
                XmlDocument pacs008Xml = new XmlDocument();
                pacs008Xml.LoadXml(message);

                string xmlTag = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n"; 

                XmlNode hdr = pacs008Xml.DocumentElement.FirstChild;
                string hdrStr = xmlTag + hdr.OuterXml;

                XmlNode doc = pacs008Xml.DocumentElement.LastChild;
                string docStr = xmlTag + doc.OuterXml;                

                TextReader hdrSr = new StringReader(hdrStr);
                var hdrSerializer = new System.Xml.Serialization.XmlSerializer(typeof(Header));
                Header hdrSer =  (Header)hdrSerializer.Deserialize(hdrSr);

                TextReader docSr = new StringReader(docStr);
                var docSerializer = new System.Xml.Serialization.XmlSerializer(typeof(Document));
                Document docSer =  (Document)docSerializer.Deserialize(docSr);

                Pacs008 pacs008 = new Pacs008();
                pacs008.AppHdr = hdrSer;
                pacs008.Document = docSer;             
          
                return pacs008;
        }
    }
}