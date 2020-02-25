using System;
using System.Collections.Generic;
using scrambler.Models;

namespace scrambler.Services
{
  public class StoriesService
  {
    private readonly StoriesRepository _repo;
    public StoriesService(StoriesService repo)
    {
      _repo = repo;
    }
    internal IEnumerable<Story> Get()
    {
      return _repo.Get();
    }
    internal Story GetById(int id)
    {
      var exists = _repo.GetById(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      return exists;
    }
    internal Story Create(Story newStory)
    {
      _repo.Create(newStory);
      return newStory;
    }
    internal Story Edit(Story update)
    {
      var exists = _repo.GetById(update.Id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _repo.Edit(update);
      return update;
    }
    internal string Delete(int id)
    {
      var exists = _repo.GetById(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _repo.Delete(id);
      return "Successfully Deleted";
    }
  }
}