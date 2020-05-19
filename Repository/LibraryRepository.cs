using System.Data;
using System.Collections.Generic;
using Dapper;
using dotnet_webapi_library.Models;

namespace dotnet_webapi_library.Repositories
{

  public class LibraryRepository
  {
    private readonly IDbConnection _db;
    public LibraryRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Library> GetAll()
    {
      string sql = "SELECT * FROM library";
      return _db.Query<Library>(sql);
    }

    internal object Create(Library newLibrary)
    {
      string sql = @"
        INSERT INTO library
        (name, location)
        VALUES
        (@Name, @Location);
        SELECT LAST_INSERT_ID()";
      newLibrary.Id = _db.ExecuteScalar<int>(sql, newLibrary);
      return newLibrary;
    }

    internal Library GetById(int id)
    {
      string sql = "SELECT * FROM library WHERE id = @ID";
      return _db.QueryFirstOrDefault<Library>(sql, new { id });
    }

    internal bool Delete(int id)
    {
      string sql = "DELETE FROM library WHERE id = @Id LIMIT 1";
      int affectedRows = _db.Execute(sql, new { id });
      return affectedRows == 1;
    }

  }

}