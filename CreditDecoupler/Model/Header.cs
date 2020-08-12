namespace Model.Head {
    using System.Xml.Serialization;
        
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AppHdr", Namespace="https://www.bcb.gov.br/pi/pacs.008/1.4", IsNullable=false)]
    public class Header {
        private Party9Choice frField;
        
        private Party9Choice toField;
        
        private string bizMsgIdrField;
        
        private string msgDefIdrField;
        
        private System.DateTime creDtField;
        
        private System.Xml.XmlElement sgntrField;

        private string validatonStatus;
        
        /// <remarks/>
        public Party9Choice Fr {
            get {
                return this.frField;
            }
            set {
                this.frField = value;
            }
        }
        
        /// <remarks/>
        public Party9Choice To {
            get {
                return this.toField;
            }
            set {
                this.toField = value;
            }
        }
        
        /// <remarks/>
        public string BizMsgIdr {
            get {
                return this.bizMsgIdrField;
            }
            set {
                this.bizMsgIdrField = value;
            }
        }
        
        /// <remarks/>
        public string MsgDefIdr {
            get {
                return this.msgDefIdrField;
            }
            set {
                this.msgDefIdrField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CreDt {
            get {
                return this.creDtField;
            }
            set {
                this.creDtField = value;
            }
        }
        
        /// <remarks/>
        public System.Xml.XmlElement Sgntr {
            get {
                return this.sgntrField;
            }
            set {
                this.sgntrField = value;
            }
        }        

        [XmlIgnore]
        public string Validationstatus {
            get {
                return this.validatonStatus;
            }
            set {
                this.validatonStatus = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Party9Choice {
        
        private BranchAndFinancialInstitutionIdentification5 itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FIId")]
        public BranchAndFinancialInstitutionIdentification5 Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BranchAndFinancialInstitutionIdentification5 {
        
        private FinancialInstitutionIdentification8 finInstnIdField;
        
        /// <remarks/>
        public FinancialInstitutionIdentification8 FinInstnId {
            get {
                return this.finInstnIdField;
            }
            set {
                this.finInstnIdField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FinancialInstitutionIdentification8 {
        
        private GenericFinancialIdentification1 othrField;
        
        /// <remarks/>
        public GenericFinancialIdentification1 Othr {
            get {
                return this.othrField;
            }
            set {
                this.othrField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GenericFinancialIdentification1 {
        
        private string idField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }    
}