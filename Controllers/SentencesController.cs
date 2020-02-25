using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using scrambler.Models;

namespace scrambler.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class SentencesController : ControllerBase
  {
    private readonly SentencesService _ses;

    public SentencesController(SentencesService ses)
    {
      _ses = ses;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Sentence>> Get()
    {
      try
      {
        return Ok(_ses.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      };
    }
    [HttpGet("{id}")]
    public ActionResult<Sentence> GetById(int id)
    {
      try
      {
        return Ok(_ses.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    [Authorize]
    public ActionResult<Sentence> Create([FromBody] Sentence newSentence)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        // newSentence.UserId = userId;
        return Ok(_ses.Create(newSentence));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete]
    [Authorize]
    public ActionResult<String> Delete(int id)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_ses.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}