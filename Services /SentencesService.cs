using System;
using System.Collections.Generic;
using scrambler.Models;

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
      _repo.Edit(exists);
      return exists;
    }
    internal Sentence Create(Sentence newSentence)
    {
      _repo.Create(newSentence);
      return newSentence;
    }
    internal Sentence Edit(Sentence update)
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
