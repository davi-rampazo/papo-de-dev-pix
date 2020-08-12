namespace Model.Doc {
    using System.Xml.Serialization;
        
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Document", Namespace="https://www.bcb.gov.br/pi/pacs.008/1.4", IsNullable=false)]
    public class Document {
        private FIToFICustomerCreditTransferV08 fIToFICstmrCdtTrfField;
        [System.Xml.Serialization.XmlElement("FIToFICstmrCdtTrf")]
        public FIToFICustomerCreditTransferV08 FIToFICstmrCdtTrf {
            get {
                return this.fIToFICstmrCdtTrfField;
            }
            set {
                this.fIToFICstmrCdtTrfField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FIToFICustomerCreditTransferV08 {
        private GrpHdr grpHdrField; 
        [System.Xml.Serialization.XmlElement("GrpHdr")]
        public GrpHdr GrpHdr {
            get {
                return this.grpHdrField;
            }
            set {
                this.grpHdrField = value;
            }
        }      

        private Transaction[] cdtTrfTxInfField;
        [System.Xml.Serialization.XmlElementAttribute("CdtTrfTxInf")]
        public Transaction[] CdtTrfTxInf {
            get {
                return this.cdtTrfTxInfField;
            }
            set {
                this.cdtTrfTxInfField = value;
            }
        }

    }    
}