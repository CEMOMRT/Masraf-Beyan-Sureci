using Bimser.CSP.Workflow.Runtime.Base;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Microsoft.AspNetCore.Mvc;
using WorkflowCore.Interface;

namespace stj1_masraf_beyan_sureci.Flows
{
    [Route("apps/stj1_masraf_beyan_sureci/latest/api/Masraf_Odeme_AltAkis/[action]")]
    [Route("apps/stj1_masraf_beyan_sureci/{v:int:min(1)}/api/Masraf_Odeme_AltAkis/[action]")]
    [Route("api/Masraf_Odeme_AltAkis/[action]")]
    [Produces("application/json")]
    public class Masraf_Odeme_AltAkisController : BaseFlowController
    {
        private readonly string _flowFileName = "Masraf_Odeme_AltAkis";

        public Masraf_Odeme_AltAkisController(IIocManager iocManager, IWorkflowController workflowController, IWorkflowRegistry workflowRegistry, IDefinitionLoader definitionLoader) 
            : base(iocManager, workflowController, workflowRegistry, definitionLoader)
        {
            FlowFileName = _flowFileName;
        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Masraf_Odeme_AltAkis API Controller is ok";
        }
    }
}