using System.Data;

namespace dotnet_webapi_library.Repositories
{

  public class LibraryRepository
  {
    private readonly IDbConnection _db;
    public LibraryRepository(IDbConnection db)
    {
      _db = db;
    }
  }

}