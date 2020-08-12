namespace Model.Doc {
    using System.Xml.Serialization;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public class Transaction {    
    
        private PaymentIdentification7 pmtIdField;
        [System.Xml.Serialization.XmlElementAttribute("PmtId")]
        public PaymentIdentification7 PmtId {
            get {
                return this.pmtIdField;
            }
            set {
                this.pmtIdField = value;
            }
        }
        
        
        private ActiveCurrencyAndAmount intrBkSttlmAmtField;
        public ActiveCurrencyAndAmount IntrBkSttlmAmt {
            get {
                return this.intrBkSttlmAmtField;
            }
            set {
                this.intrBkSttlmAmtField = value;
            }
        }
        private System.DateTime accptncDtTmField;
        public System.DateTime AccptncDtTm {
            get {
                return this.accptncDtTmField;
            }
            set {
                this.accptncDtTmField = value;
            }
        }

        
        private ChargeBearerType1Code chrgBrField;
        public ChargeBearerType1Code ChrgBr {
            get {
                return this.chrgBrField;
            }
            set {
                this.chrgBrField = value;
            }
        }
        //private IdOrganizationIdentification initgPtyField;
        
        private NmIdPrivateIdentification dbtrField;
        public NmIdPrivateIdentification Dbtr {
            get {
                return this.dbtrField;
            }
            set {
                this.dbtrField = value;
            }
        }
        
        private CashAccount38DbtrAcct dbtrAcctField;
        public CashAccount38DbtrAcct DbtrAcct {
            get {
                return this.dbtrAcctField;
            }
            set {
                this.dbtrAcctField = value;
            }
        }        

        
        private BranchAndFinancialInstitutionIdentification6 dbtrAgtField;
        public BranchAndFinancialInstitutionIdentification6 DbtrAgt {
            get {
                return this.dbtrAgtField;
            }
            set {
                this.dbtrAgtField = value;
            }
        }

        private BranchAndFinancialInstitutionIdentification6 cdtrAgtField;
        public BranchAndFinancialInstitutionIdentification6 CdtrAgt {
            get {
                return this.cdtrAgtField;
            }
            set {
                this.cdtrAgtField = value;
            }
        }           
        
        private IdPrivateIdentification cdtrField;
        public IdPrivateIdentification Cdtr {
            get {
                return this.cdtrField;
            }
            set {
                this.cdtrField = value;
            }
        }

        private CashAccount38CdtrAcct cdtrAcctField;
        public CashAccount38CdtrAcct CdtrAcct {
            get {
                return this.cdtrAcctField;
            }
            set {
                this.cdtrAcctField = value;
            }
        }
        
        private RemittanceInformation16 rmtInfField;
        public RemittanceInformation16 RmtInf {
            get {
                return this.rmtInfField;
            }
            set {
                this.rmtInfField = value;
            }
        }        
       /* 
       /// <remarks/>

        
        /// <remarks/>
        public System.DateTime AccptncDtTm {
            get {
                return this.accptncDtTmField;
            }
            set {
                this.accptncDtTmField = value;
            }
        }
        
        /// <remarks/>
        public ChargeBearerType1Code ChrgBr {
            get {
                return this.chrgBrField;
            }
            set {
                this.chrgBrField = value;
            }
        }
        
        /// <remarks/>
        public IdOrganizationIdentification InitgPty {
            get {
                return this.initgPtyField;
            }
            set {
                this.initgPtyField = value;
            }
        }
        
        /// <remarks/>
        public NmIdPrivateIdentification Dbtr {
            get {
                return this.dbtrField;
            }
            set {
                this.dbtrField = value;
            }
        }
        
        /// <remarks/>
        public CashAccount38DbtrAcct DbtrAcct {
            get {
                return this.dbtrAcctField;
            }
            set {
                this.dbtrAcctField = value;
            }
        }
        
        /// <remarks/>

        
        /// <remarks/>
        public IdPrivateIdentification Cdtr {
            get {
                return this.cdtrField;
            }
            set {
                this.cdtrField = value;
            }
        }
        
        /// <remarks/>

        
        /// <remarks/>
   
        */

    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PaymentIdentification7 {
        
        private string endToEndIdField;
        
        private string txIdField;
        
        /// <remarks/>
        public string EndToEndId {
            get {
                return this.endToEndIdField;
            }
            set {
                this.endToEndIdField = value;
            }
        }
        
        /// <remarks/>
        public string TxId {
            get {
                return this.txIdField;
            }
            set {
                this.txIdField = value;
            }
        }
    }    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ActiveCurrencyAndAmount {
        
        private string ccyField;
        
        private decimal valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ccy {
            get {
                return this.ccyField;
            }
            set {
                this.ccyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    } 

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    public enum ChargeBearerType1Code {
        
        /// <remarks/>
        SLEV,
    }       

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class NmIdPrivateIdentification {
        
        private string nmField;
        
        private PrivateIdentification idField;
        
        /// <remarks/>
        public string Nm {
            get {
                return this.nmField;
            }
            set {
                this.nmField = value;
            }
        }
        
        /// <remarks/>
        public PrivateIdentification Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PrivateIdentification {
        
        private PersonIdentification13 prvtIdField;
        
        /// <remarks/>
        public PersonIdentification13 PrvtId {
            get {
                return this.prvtIdField;
            }
            set {
                this.prvtIdField = value;
            }
        }
    }    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PersonIdentification13 {
        
        private GenericPersonIdentification1 othrField;
        
        /// <remarks/>
        public GenericPersonIdentification1 Othr {
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
    public partial class GenericPersonIdentification1 {
        
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CashAccount38DbtrAcct {
        
        private AccountIdentification4Choice idField;
        
        private CashAccountType2Choice tpField;
        
        [System.Xml.Serialization.XmlElementAttribute("Id")]
        public AccountIdentification4Choice Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Tp")]
        public CashAccountType2Choice Tp {
            get {
                return this.tpField;
            }
            set {
                this.tpField = value;
            }
        }
    }    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AccountIdentification4Choice {
        
        private GenericAccountIdentification1 itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Othr")]
        public GenericAccountIdentification1 Othr {
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
    public partial class GenericAccountIdentification1 {
        
        private string idField;
        
        private string issrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Id", DataType="integer")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Issr",DataType="integer")]
        public string Issr {
            get {
                return this.issrField;
            }
            set {
                this.issrField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CashAccountType2Choice {
        
        private ExternalCashAccountType1Code itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd")]
        public ExternalCashAccountType1Code Item {
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
    public enum ExternalCashAccountType1Code {
        
        /// <remarks/>
        CACC,
        
        /// <remarks/>
        SLRY,
        
        /// <remarks/>
        SVGS,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BranchAndFinancialInstitutionIdentification6 {
        
        private FinancialInstitutionIdentification18 finInstnIdField;
        
        /// <remarks/>
        public FinancialInstitutionIdentification18 FinInstnId {
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
    public partial class FinancialInstitutionIdentification18 {
        
        private ClearingSystemMemberIdentification2 clrSysMmbIdField;
        
        /// <remarks/>
        public ClearingSystemMemberIdentification2 ClrSysMmbId {
            get {
                return this.clrSysMmbIdField;
            }
            set {
                this.clrSysMmbIdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ClearingSystemMemberIdentification2 {
        
        private string mmbIdField;
        
        /// <remarks/>
        public string MmbId {
            get {
                return this.mmbIdField;
            }
            set {
                this.mmbIdField = value;
            }
        }
    }    

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IdPrivateIdentification {
        
        private PrivateIdentification idField;
        
        /// <remarks/>
        public PrivateIdentification Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }    

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CashAccount38CdtrAcct {
        
        private AccountIdentification4Choice idField;
        
        private CashAccountType2Choice tpField;
               
        /// <remarks/>
        public AccountIdentification4Choice Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public CashAccountType2Choice Tp {
            get {
                return this.tpField;
            }
            set {
                this.tpField = value;
            }
        }
        
        /*
        private ProxyAccountIdentification1 prxyField;        
        public ProxyAccountIdentification1 Prxy {
            get {
                return this.prxyField;
            }
            set {
                this.prxyField = value;
            }
        }
        */
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]

    public partial class RemittanceInformation16 {
        
        private string ustrdField;
        
        /// <remarks/>
        public string Ustrd {
            get {
                return this.ustrdField;
            }
            set {
                this.ustrdField = value;
            }
        }
    }

}