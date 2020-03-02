using System.Collections.Generic;
using System.Data;
using Dapper;
using scrambler.Models;

namespace scrambler.Repositories
{
  public class StorySentencesRepository
  {
    private readonly IDbConnection _db;
    public StorySentencesRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Sentence> GetByStoryId(int storyId, string userId)
    {
      string sql = "SELECT s.* FROM storysentences ss INNER JOIN sentences s ON s.id = ss.sentenceId WHERE (storyId = @storyId AND ss.userId = @userId);";
      return _db.Query<Sentence>(sql, new { storyId, userId });
    }
    internal StorySentence GetById(int id)
    {
      string sql = "SELECT * FROM storysentences WHERE id = @id";
      return _db.QueryFirstOrDefault<StorySentence>(sql, new { id });
    }
    internal StorySentence GetByIds(int sentenceId, int storyId)
    {
      string sql = "SELECT * FROM storysentences WHERE (sentenceId = @sentenceId AND storyId = @storyId)";
      return _db.QueryFirstOrDefault<StorySentence>(sql, new { sentenceId, storyId });
    }
    internal StorySentence Create(StorySentence newStorySentence)
    {
      string sql = @"REPLACE INTO storysentences (sentenceId, storyId, order, userId) VALUES (@SentenceId, @StoryId, @Order, @UserId); SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newStorySentence);
      newStorySentence.Id = id;
      return newStorySentence;
    }
    internal void Edit(StorySentence update)
    {
      string sql = @"UPDATE storysentences SET storyId = @StoryId, sentenceId = @SentenceId, id = @Id, order = @Order;";
      _db.Execute(sql, update);

    }
    internal void Delete(int id)
    {
      string sql = "DELETE FROM storysentences WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}