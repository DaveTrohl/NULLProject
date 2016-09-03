using System;
using System.Net;
using System.Web.Http;
using NULL_API.Models;
using Swashbuckle.Swagger.Annotations;

namespace NULL_API.Controllers
{
    [SwaggerResponse(HttpStatusCode.InternalServerError, "An error has occured")]
    public class LinkedInController : ApiController
    {
        [SwaggerResponse(HttpStatusCode.OK, "Attached LinkedIn Profile")]
        [Route(Routes.GetLinkedInUser), HttpGet]
        public IHttpActionResult GetProfile(string name)
        {
            try
            {
                UserProfile profile = new UserProfile
                {
                    Name        = name,
                    Occupation  = "Chief Windows Installer",
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
