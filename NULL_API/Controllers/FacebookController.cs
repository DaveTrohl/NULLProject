using System;
using System.Net;
using System.Web.Http;
using NULL_API.Models;
using NULL_API.WebApiResources;
using Swashbuckle.Swagger.Annotations;

namespace NULL_API.Controllers
{
    [SwaggerResponse(HttpStatusCode.InternalServerError, "An error has occured")]
    public class FacebookController : ApiController
    {
        [SwaggerResponse(HttpStatusCode.OK, "Attached Facebook Profile")]
        [Route(Routes.GetFacebookUser), HttpGet]
        public IHttpActionResult GetProfile(string name)
        {
            try
            {
                return Ok(FacebookResources.GetFacebookProfile(name));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
