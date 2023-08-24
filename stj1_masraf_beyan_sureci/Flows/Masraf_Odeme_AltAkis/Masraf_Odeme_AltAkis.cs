using Bimser.Synergy.Entities.Workflow.EventArguments;
using System;
using Bimser.CSP.Runtime.Common.Extensions;

namespace stj1_masraf_beyan_sureci.Flows
{
    public partial class Masraf_Odeme_AltAkis
    {
		public void Function2_Execute(object sender, OnExecuteEventArguments args)
		{
            Document2.Controls["masFormNum"].Value =  Document1.Controls["DocumentMetadata1"].Value.ToString();
            Document2.Controls["perAdSoyad"].Value =  Document1.Controls["adSoyad"].Value.ToString();
            Document2.Controls["perDep"].Value =  Document1.Controls["pozisyonBilgi"].Value.ToString();
            Document2.Controls["ibanNo"].Value =  Document1.Controls["TextBox2"].Value.ToString();
            Document2.Controls["odencekTutar"].Value =  Document1.Controls["toplamMasraf"].Value.ToString();
            Document2.Controls["TextBoxID"].Value =  ParentDocumentId.Value.ToString();
            LogExtension.Log( DocumentIdInfo,_workflowData.Context);
            Document2.SaveDocument();
		}
 }
}