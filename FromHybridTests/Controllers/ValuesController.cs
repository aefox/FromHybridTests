using HybridModelBinding;
using Microsoft.AspNetCore.Mvc;

namespace FromHybridTests.Controllers
{
    [Route("api")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("cmd1/{id}")]
        public ActionResult<Cmd1> GetCmd1([FromHybrid] Cmd1 cmd1)
        {
            return cmd1;
        }

        [HttpGet("cmd2/{id}")]
        public ActionResult<Cmd2> GetCmd2([FromHybrid] Cmd2 cmd2)
        {
            return cmd2;
        }

        [HttpGet("cmd3/{id}")]
        public ActionResult<Cmd3> GetCmd3([FromHybrid] Cmd3 cmd3)
        {
            return cmd3;
        }

        [HttpGet("cmd4/{id}")]
        public ActionResult<Cmd4> GetCmd4([FromHybrid] Cmd4 cmd4)
        {
            return cmd4;
        }

        [HttpPost("cmd5/{id}")]
        public ActionResult<Cmd5> GetCmd5([FromHybrid] Cmd5 cmd5)
        {
            return cmd5;
        }

        [HttpPost("cmd6/{id}")]
        public ActionResult<Cmd6> GetCmd6([FromHybrid] Cmd6 cmd6)
        {
            return cmd6;
        }
    }
}
