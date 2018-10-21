using System.Linq;
using MercurialHttpHooks.Net;
using Microsoft.AspNetCore.Mvc;

namespace HgWeb.Controllers
{
    [Route("/api/mercurial")]
    [ApiController]
    public class MercurialController : ControllerBase
    {

        [HttpPost]
        [Route("permissions")]
        public ProcessResult Post([FromBody] PushInfo obj)
        {
            if (obj.Commits.All(q => q.Message.Length > 10))
                return new ProcessResult()
                {
                    Success = true,
                    Message = "Good job\nDude"
                };

            return new ProcessResult
            {
                Success = false,
                Message = "Sorry but no"
            };
        }

    }

}
