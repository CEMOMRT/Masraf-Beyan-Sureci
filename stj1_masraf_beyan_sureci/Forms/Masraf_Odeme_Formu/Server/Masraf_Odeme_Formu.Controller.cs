using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace stj1_masraf_beyan_sureci.Forms
{
    [Route("apps/stj1_masraf_beyan_sureci/latest/api/Masraf_Odeme_Formu/[action]")]
    [Route("apps/stj1_masraf_beyan_sureci/{v:int:min(1)}/api/Masraf_Odeme_Formu/[action]")]
    [Route("api/Masraf_Odeme_Formu/[action]")]
    [Produces("application/json")]
    public class Masraf_Odeme_FormuController : BaseFormController<Masraf_Odeme_Formu>
    {
        public Masraf_Odeme_FormuController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Masraf_Odeme_Formu API Controller is ok";            
        }
    }
}