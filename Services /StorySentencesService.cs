using System;
using System.Collections.Generic;
using scrambler.Models;
using scrambler.Repositories;

namespace scrambler.Services
{
  public class StorySentencesService
  {
    private readonly StorySentencesRepository _repo;
    public StorySentencesService(StorySentencesRepository repo)
    {
      _repo = repo;
    }
    internal IEnumerable<Sentence> GetByStoryId(int id)
    {
      var exists = _repo.GetByStoryId(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      return exists;
    }
    internal StorySentence Create(StorySentence newStorySentence)
    {
      _repo.Create(newStorySentence);
      return newStorySentence;
    }
    internal StorySentence Edit(StorySentence update)
    {
      var exists = _repo.GetById(update.Id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      _repo.Edit(update);
      return update;
    }

    internal string Delete(int sentenceId, int storyId)
    {
      var exists = _repo.GetByIds(sentenceId, storyId);
      if (exists == null) { throw new Exception("Invalid Ids"); }
      _repo.Delete(exists.Id);
      return "Successfully Deleted";
    }
  }
}