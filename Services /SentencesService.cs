using System;
using System.Collections.Generic;
using scrambler.Models;
using scrambler.Repositories;

namespace scrambler.Services
{
  public class SentencesService
  {
    private readonly SentencesRepository _repo;
    public SentencesService(SentencesRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Sentence> Get()
    {
      return _repo.Get();
    }
    internal Sentence GetById(int id)
    {
      var exists = _repo.GetById(id);
      if (exists == null) { throw new Exception("Invalid Id"); }
      return exists;
    }
    internal Sentence Create(Sentence newSentence)
    {
      _repo.Create(newSentence);
      return newSentence;
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
