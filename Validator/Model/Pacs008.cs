using Model.Head;
using Model.Doc;

namespace Model.Pacs008 {
    using System.Xml.Serialization;
        
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://www.bcb.gov.br/pi/pacs.008/1.4")]
    [System.Xml.Serialization.XmlRootAttribute("Envelope", Namespace="https://www.bcb.gov.br/pi/pacs.008/1.4", IsNullable=false)]

    public class Pacs008 {
        private Header appHdrField;
        
        [System.Xml.Serialization.XmlElement("AppHdr", IsNullable=false)]
        public Header AppHdr {
            get {
                return this.appHdrField;
            }
            set {
                this.appHdrField = value;
            }
        }
        private Document documentField;
        
        [System.Xml.Serialization.XmlElement("Document", IsNullable=false)]
        public Document Document {
            get {
                return this.documentField;
            }
            set {
                this.documentField = value;
            }
        }



    }
}
