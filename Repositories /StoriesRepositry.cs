using System.Collections.Generic;
using System.Data;
using Dapper;
using scrambler.Models;

namespace scrambler.Repositories
{
  public class StoriesRepository
  {
    private readonly IDbConnection _db;
    public StoriesRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Story> Get()
    {
      string sql = @"SELECT @ FROM stories";
      return _db.Query<Story>(sql);
    }
    internal Story GetById(int id)
    {
      string sql = "SELECT * FROM stories WHERE id = @id";
      return _db.QueryFirstOrDefault<Story>(sql, new { id });
    }
    internal Story Create(Story newStory)
    {
      string sql = "INSERT INTO stories (title, userId) VALUES (@Title, @UserId); SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newStory);
      newStory.Id = id;
      return newStory;
    }
    internal void Edit(Story update)
    {
      string sql = @"UPDATE stories SET title = @Title, id = @Id WHERE id = @id;";
      _db.Execute(sql, update);
    }
    internal void Delete(int id)
    {
      string sql = "DELETE FROM keeps WHERE id = @id";
      _db.Execute(sql, new { id });
    }
  }
}