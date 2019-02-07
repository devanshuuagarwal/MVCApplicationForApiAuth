using System.Web.Http;
using System.Web.Http.Description;
using System.Web.UI.WebControls;
using WebApiForAuthantication.Validate;

namespace WebApiForAuthantication.Controllers
{
    [BaseAuth]
    public class LoginController : ApiController
    {
        [HttpGet]
        [ResponseType(typeof(Login))]
        public IHttpActionResult Login()
        {
            return Ok("exist");
        }
    }
}