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
    internal IEnumerable<Sentence> GetByStoryId(int id, string userId)
    {
      var exists = _repo.GetByStoryId(id, userId);
      if (exists == null) { throw new Exception("Invalid Id"); }
      return exists;
    }
    internal StorySentence Create(StorySentence newStorySentence)
    {
      _repo.Create(newStorySentence);
      return newStorySentence;
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