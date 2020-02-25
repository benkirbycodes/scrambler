
using Microsoft.AspNetCore.Mvc;

namespace scrambler.Controllers
{
  [ApiController]
  [Route("api/[controller")]
  public class StoriesController : ControllerBase
  {
    private readonly StoriesService _sts;

    public StoriesController(StoriesService sts)
    {
      _sts = sts;
    }
    [HttpGet]

  }
}