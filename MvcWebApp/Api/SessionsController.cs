using MvcWebApp.Helpers;
using MvcWebApp.Models.Data;

namespace MvcWebApp.Api
{
    public class SessionsController : BaseApiController<Session>
    {
        public SessionsController()
        {
            Includes = new[] { "SessionType", "Location", "TimeSlot", "Level" };
        }
    }
}