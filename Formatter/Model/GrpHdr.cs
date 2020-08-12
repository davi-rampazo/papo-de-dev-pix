namespace Model.Doc {
     using System.Xml.Serialization;
        
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class GrpHdr {
        
        private string msgIdField;
        
        private System.DateTime creDtTmField;
        
        private string nbOfTxsField;
        
        private SettlementInstruction7 sttlmInfField;
        
        private PaymentTypeInformation28 pmtTpInfField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MsgId", IsNullable=false)]
        public string MsgId {
            get {
                return this.msgIdField;
            }
            set {
                this.msgIdField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CreDtTm {
            get {
                return this.creDtTmField;
            }
            set {
                this.creDtTmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string NbOfTxs {
            get {
                return this.nbOfTxsField;
            }
            set {
                this.nbOfTxsField = value;
            }
        }
        
        /// <remarks/>
        public SettlementInstruction7 SttlmInf {
            get {
                return this.sttlmInfField;
            }
            set {
                this.sttlmInfField = value;
            }
        }
        
        /// <remarks/>
        public PaymentTypeInformation28 PmtTpInf {
            get {
                return this.pmtTpInfField;
            }
            set {
                this.pmtTpInfField = value;
            }
        }
    }        
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
  
    public partial class SettlementInstruction7 {
        private SettlementMethod1Code sttlmMtdField;
        /// <remarks/>
        public SettlementMethod1Code SttlmMtd {
            get {
                return this.sttlmMtdField;
            }
            set {
                this.sttlmMtdField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]

    public partial class PaymentTypeInformation28 {
        
        private Priority2Code instrPrtyField;
        
        /// <remarks/>
        public Priority2Code InstrPrty {
            get {
                return this.instrPrtyField;
            }
            set {
                this.instrPrtyField = value;
            }
        }
    }    
    [System.SerializableAttribute()]
    public enum Priority2Code {
        
        /// <remarks/>
        HIGH,
        
        /// <remarks/>
        NORM,
    }    

    [System.SerializableAttribute()]
    public enum SettlementMethod1Code {
        
        /// <remarks/>
        CLRG,
    }    
}
        
