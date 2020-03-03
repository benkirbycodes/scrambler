
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
  public class StoriesController : ControllerBase
  {
    private readonly StoriesService _sts;

    public StoriesController(StoriesService sts)
    {
      _sts = sts;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Story>> Get()
    {
      try
      {
        return Ok(_sts.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Story> GetById(int id)
    {
      try
      {
        return Ok(_sts.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Story> Create([FromBody] Story newStory)
    {
      try
      {

        return Ok(_sts.Create(newStory));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Story> Edit([FromBody] Story update, int id)
    {
      try
      {

        return Ok(_sts.Edit(update));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    [HttpDelete("{id}")]
    public ActionResult<String> Delete(int id)
    {
      try
      {
        return Ok(_sts.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}