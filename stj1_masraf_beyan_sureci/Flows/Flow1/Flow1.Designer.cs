using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace stj1_masraf_beyan_sureci.Flows
{
    [WorkflowIdentifier("5e8d6986-1e37-4528-8add-42df86e341b3")]
    public partial class Flow1 : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _flowStart1;
		private FlowEnd _flowEnd1;
		private FlowPosition _akisBasAmiri;
		private FlowPosition _askisBaslatan;
		private FlowPosition _depYonetici;
		private FlowAssign _amirAtama1;
		private FlowAssign _depAtama;
		private FlowCompare _tutarKarsilastirma;
		private FlowMail _redBilgilendirme1;
		private FlowMail _revizBilgilendirme;
		private FlowMail _redBilgilendir;
		private FlowMail _notification2;
		private FlowDepartment _akisBasDepartmani;
		private Variable _topTutar;
		private FlowNode _amirBulamadi;
		private FlowNode _amirBulunamadiOut;
		private FlowNode _nodeIn2;
		private FlowNode _nodeOut2;
		private FlowNode _nodeIn3;
		private FlowNode _nodeOut3;
		private FlowGroup _ikGrubu;
		private FlowGroup _muhGrup;
		private Pauser _masrafOdemeDurma;
		private FlowDocument _document1;
		private FlowDocument _document2;
		private FlowTrigger _masrafOdemeTetikle;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart FlowStart1 => _flowStart1 ??= new FlowStart("FlowStart1", _workflowData, this);
		private FlowEnd FlowEnd1 => _flowEnd1 ??= new FlowEnd("FlowEnd1", _workflowData, this);
		private FlowPosition akisBasAmiri => _akisBasAmiri ??= new FlowPosition("akisBasAmiri", _workflowData, this);
		private FlowPosition askisBaslatan => _askisBaslatan ??= new FlowPosition("askisBaslatan", _workflowData, this);
		private FlowPosition depYonetici => _depYonetici ??= new FlowPosition("depYonetici", _workflowData, this);
		private FlowAssign amirAtama1 => _amirAtama1 ??= new FlowAssign("amirAtama1", _workflowData, this);
		private FlowAssign depAtama => _depAtama ??= new FlowAssign("depAtama", _workflowData, this);
		private FlowCompare tutarKarsilastirma => _tutarKarsilastirma ??= new FlowCompare("tutarKarsilastirma", _workflowData, this);
		private FlowMail redBilgilendirme1 => _redBilgilendirme1 ??= new FlowMail("redBilgilendirme1", _workflowData, this);
		private FlowMail revizBilgilendirme => _revizBilgilendirme ??= new FlowMail("revizBilgilendirme", _workflowData, this);
		private FlowMail redBilgilendir => _redBilgilendir ??= new FlowMail("redBilgilendir", _workflowData, this);
		private FlowMail Notification2 => _notification2 ??= new FlowMail("Notification2", _workflowData, this);
		private FlowDepartment akisBasDepartmani => _akisBasDepartmani ??= new FlowDepartment("akisBasDepartmani", _workflowData, this);
		private Variable topTutar => _topTutar ??= new Variable("topTutar", _workflowData, this);
		private FlowNode amirBulamadi => _amirBulamadi ??= new FlowNode("amirBulamadi", _workflowData, this);
		private FlowNode amirBulunamadiOut => _amirBulunamadiOut ??= new FlowNode("amirBulunamadiOut", _workflowData, this);
		private FlowNode NodeIn2 => _nodeIn2 ??= new FlowNode("NodeIn2", _workflowData, this);
		private FlowNode NodeOut2 => _nodeOut2 ??= new FlowNode("NodeOut2", _workflowData, this);
		private FlowNode NodeIn3 => _nodeIn3 ??= new FlowNode("NodeIn3", _workflowData, this);
		private FlowNode NodeOut3 => _nodeOut3 ??= new FlowNode("NodeOut3", _workflowData, this);
		private FlowGroup ikGrubu => _ikGrubu ??= new FlowGroup("ikGrubu", _workflowData, this);
		private FlowGroup muhGrup => _muhGrup ??= new FlowGroup("muhGrup", _workflowData, this);
		private Pauser masrafOdemeDurma => _masrafOdemeDurma ??= new Pauser("masrafOdemeDurma", _workflowData, this);
		private FlowDocument Document1 => _document1 ??= new FlowDocument("Document1", _workflowData, this);
		private FlowDocument Document2 => _document2 ??= new FlowDocument("Document2", _workflowData, this);
		private FlowTrigger masrafOdemeTetikle => _masrafOdemeTetikle ??= new FlowTrigger("masrafOdemeTetikle", _workflowData, this);


        #endregion

        #region [ctor]        

        public Flow1() : this(null)
        {
            
        }
        
        public Flow1(IRuntimeWorkflowData workflowData) : base(workflowData)
        {
            
        }

        #endregion
    }
}