using System;
using System.Net;
using System.Web.Http;
using NULL_API.Models;
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
                UserProfile profile = new UserProfile
                {
                    Name        = name,
                    Address     = "123 Fake Street.",
                    DateOfBirth = DateTime.UtcNow.AddYears(-25),
                };

                return Ok(profile);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
