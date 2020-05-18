using dotnet_webapi_library.Repositories;

namespace dotnet_webapi_library.Services
{
  public class LibraryService
  {
    private readonly LibraryRepository _repo;

    public LibraryService(LibraryRepository repo)
    {
      _repo = repo;
    }
  }
}