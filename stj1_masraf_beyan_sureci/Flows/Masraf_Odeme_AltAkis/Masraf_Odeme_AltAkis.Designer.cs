using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace stj1_masraf_beyan_sureci.Flows
{
    [WorkflowIdentifier("a2d4ac0a-2fd9-4f4a-8cd2-b6335f63015a")]
    public partial class Masraf_Odeme_AltAkis : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _flowStart1;
		private FlowEnd _flowEnd1;
		private FlowPosition _position1;
		private Variable _userID;
		private Variable _parentProcessId;
		private Variable _parentDocumentId;
		private Variable _documentIdInfo;
		private FlowScript _function2;
		private FlowDocument _document1;
		private FlowDocument _document2;
		private FlowCreateDocument _createDocument1;
		private FlowCreateDocument _createDocument2;
		private FlowPDFExport _exportToPDF2;
		private FlowContinue _flowContinue1;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart FlowStart1 => _flowStart1 ??= new FlowStart("FlowStart1", _workflowData, this);
		private FlowEnd FlowEnd1 => _flowEnd1 ??= new FlowEnd("FlowEnd1", _workflowData, this);
		private FlowPosition Position1 => _position1 ??= new FlowPosition("Position1", _workflowData, this);
		private Variable userID => _userID ??= new Variable("userID", _workflowData, this);
		private Variable ParentProcessId => _parentProcessId ??= new Variable("ParentProcessId", _workflowData, this);
		private Variable ParentDocumentId => _parentDocumentId ??= new Variable("ParentDocumentId", _workflowData, this);
		private Variable DocumentIdInfo => _documentIdInfo ??= new Variable("DocumentIdInfo", _workflowData, this);
		private FlowScript Function2 => _function2 ??= new FlowScript("Function2", _workflowData, this);
		private FlowDocument Document1 => _document1 ??= new FlowDocument("Document1", _workflowData, this);
		private FlowDocument Document2 => _document2 ??= new FlowDocument("Document2", _workflowData, this);
		private FlowCreateDocument CreateDocument1 => _createDocument1 ??= new FlowCreateDocument("CreateDocument1", _workflowData, this);
		private FlowCreateDocument CreateDocument2 => _createDocument2 ??= new FlowCreateDocument("CreateDocument2", _workflowData, this);
		private FlowPDFExport ExportToPDF2 => _exportToPDF2 ??= new FlowPDFExport("ExportToPDF2", _workflowData, this);
		private FlowContinue FlowContinue1 => _flowContinue1 ??= new FlowContinue("FlowContinue1", _workflowData, this);


        #endregion

        #region [ctor]        

        public Masraf_Odeme_AltAkis() : this(null)
        {
            
        }
        
        public Masraf_Odeme_AltAkis(IRuntimeWorkflowData workflowData) : base(workflowData)
        {
            
        }

        #endregion
    }
}