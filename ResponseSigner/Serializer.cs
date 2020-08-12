using Model.Doc;
using Model.Head;
using Model.Pacs008;
using Model;
using System.Xml.Serialization;
using System.IO;
using System;

namespace ResponseSigner
{
    class Serializer
    {
        public static string process(Pacs008 pacs008)
        {
                //From
                Model.GenericFinancialIdentification1 othrFr = 
                    new Model.GenericFinancialIdentification1();
                othrFr.Id = pacs008.AppHdr.Fr.Item.FinInstnId.Othr.Id;
                Model.FinancialInstitutionIdentification8 finInstnIdFr = 
                    new Model.FinancialInstitutionIdentification8();
                finInstnIdFr.Othr = othrFr;
                Model.BranchAndFinancialInstitutionIdentification5 fiidFr = 
                    new Model.BranchAndFinancialInstitutionIdentification5();
                fiidFr.FinInstnId = finInstnIdFr;
                Model.Party9Choice from = new Model.Party9Choice();
                from.Item = fiidFr;
                //To
                Model.GenericFinancialIdentification1 othrTo = 
                    new Model.GenericFinancialIdentification1();
                othrTo.Id = pacs008.AppHdr.To.Item.FinInstnId.Othr.Id;
                Model.FinancialInstitutionIdentification8 finInstnIdTo = 
                    new Model.FinancialInstitutionIdentification8();
                finInstnIdTo.Othr = othrTo;
                Model.BranchAndFinancialInstitutionIdentification5 fiidTo = 
                    new Model.BranchAndFinancialInstitutionIdentification5();
                fiidTo.FinInstnId = finInstnIdTo;
                Model.Party9Choice to = new Model.Party9Choice();
                to.Item = fiidTo;
                //Outros campos do Header
                SPIhead00100101 header = new SPIhead00100101();
                header.Fr = from;
                header.To = to;
                header.BizMsgIdr = pacs008.AppHdr.BizMsgIdr;
                header.MsgDefIdr = "pacs.002.spi.1.3";
                header.CreDt = pacs008.AppHdr.CreDt;

                // Group do Rpt
                GroupHeader91 grpHdr = new GroupHeader91();
                // Aqui estou colocando a mesma MsgId, mas aqui deve-se criar uma nova
                grpHdr.MsgId = pacs008.Document.FIToFICstmrCdtTrf.GrpHdr.MsgId;
                grpHdr.CreDtTm = pacs008.Document.FIToFICstmrCdtTrf.GrpHdr.CreDtTm;
                // TxInfAndSts
                PaymentTransaction110 txInfAndSts = new PaymentTransaction110();
                txInfAndSts.OrgnlInstrId = pacs008.Document.FIToFICstmrCdtTrf.CdtTrfTxInf[0].PmtId.EndToEndId;
                txInfAndSts.OrgnlEndToEndId = pacs008.Document.FIToFICstmrCdtTrf.CdtTrfTxInf[0].PmtId.EndToEndId;
                txInfAndSts.TxSts = ExternalPaymentTransactionStatus1Code.ACSP;

                FIToFIPaymentStatusReportV10 fIToFIPmtStsRpt = new FIToFIPaymentStatusReportV10();
                fIToFIPmtStsRpt.GrpHdr = grpHdr;
                PaymentTransaction110[] array = new PaymentTransaction110[1];
                array[0] = txInfAndSts;
                fIToFIPmtStsRpt.TxInfAndSts = array;
                
                SPIpacs00200110 doc = new SPIpacs00200110();
                doc.FIToFIPmtStsRpt = fIToFIPmtStsRpt;

                SPIEnvelopeMessage pacs002 = new SPIEnvelopeMessage();
                pacs002.AppHdr = header;
                pacs002.Document = doc;

                //using System.Xml.Serialization
                /*XmlSerializer ser = new XmlSerializer(typeof(SPIEnvelopeMessage));
                StringWriter textWriter = new StringWriter();
                ser.Serialize(textWriter, pacs002);
                */

                MemoryStream stream = new MemoryStream();
                StreamWriter writer = new StreamWriter(stream, System.Text.Encoding.UTF8);
                XmlSerializer serUtf8 = new XmlSerializer(typeof(SPIEnvelopeMessage));
                serUtf8.Serialize(writer, pacs002);

            return System.Text.Encoding.UTF8.GetString(stream.ToArray());
        }
    }
}