using Microsoft.AspNetCore.Mvc;
using Bimser.CSP.FormControls.Api;
using Bimser.Framework.Dependency;
using Bimser.Framework.AspNetCore.Mvc.Attributes;

namespace stj1_masraf_beyan_sureci.Forms
{
    [Route("apps/stj1_masraf_beyan_sureci/latest/api/Masraf_tipleri/[action]")]
    [Route("apps/stj1_masraf_beyan_sureci/{v:int:min(1)}/api/Masraf_tipleri/[action]")]
    [Route("api/Masraf_tipleri/[action]")]
    [Produces("application/json")]
    public class Masraf_tipleriController : BaseFormController<Masraf_tipleri>
    {
        public Masraf_tipleriController(IIocManager iocManager) : base(iocManager)
        {

        }

        [HttpGet]
        [ActionName("Ping")]
        [NoRequestHeaders]
        [NoResponseHeaders]
        public string Ping()
        {
            return "Masraf_tipleri API Controller is ok";            
        }
    }
}