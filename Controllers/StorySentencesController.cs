using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using scrambler.Models;
using scrambler.Services;

namespace scrambler.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class StorySentencesController : ControllerBase
  {
    private readonly StorySentencesService _stses;

    public StorySentencesController(StorySentencesService stses)
    {
      _stses = stses;
    }
    [HttpGet("{id}/sentences")]
    public ActionResult<IEnumerable<Sentence>> GetByStoryId(int id)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_stses.GetByStoryId(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<StorySentence> Create([FromBody] StorySentence newStorySentence)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        newStorySentence.UserId = userId;
        return Ok(_stses.Create(newStorySentence));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }

    }
    [HttpPut("{id}")]
    public ActionResult<StorySentence> Edit([FromBody] StorySentence update, int id)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        update.Id = id;
        return Ok(_stses.Edit(update));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{storyId}/sentences/{sentenceId}")]
    public ActionResult<String> Delete(int sentenceId, int storyId)
    {
      try
      {
        var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        return Ok(_stses.Delete(sentenceId, storyId));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}