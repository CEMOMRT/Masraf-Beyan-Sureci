using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace stj1_masraf_beyan_sureci.Forms
{
    [Route("apps/stj1_masraf_beyan_sureci/latest/api/Masraf_harcama/[action]")]
    [Route("apps/stj1_masraf_beyan_sureci/{v:int:min(1)}/api/Masraf_harcama/[action]")]
    [Route("api/Masraf_harcama/[action]")]
    [Produces("application/json")]
    public class Masraf_harcamaController : BaseFormController<Masraf_harcama>
    {
        public Masraf_harcamaController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Masraf_harcama API Controller is ok";            
        }
    }
}