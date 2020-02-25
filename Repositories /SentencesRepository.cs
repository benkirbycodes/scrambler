using System.Collections.Generic;
using System.Data;
using scrambler.Models;

namespace scrambler.Repositories
{
  public class SentencesRepository
  {
    private readonly IDbConnection _db;
    public SentencesRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Sentence> Get()
    {
      string sql = "SELECT * FROM sentences";
      return _db.Query<Sentence>(sql);
    }
    internal Sentence GetById(int id)
    {
      string sql = "SELECT * FROM sentences WHERE id = @id";
      return _db.QueryFirstOrDefault<Sentence>(sql, new { id });
    }
    internal Sentence Create(Sentence newSentence)
    {
      string sql = @"INSERT INTO sentences 
      (text) VALUES (@Text);
      SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newSentence);
      return newSentence;
    }
    internal void Delete(int id)
    {
      string sql = "DELETE FROM sentences WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}