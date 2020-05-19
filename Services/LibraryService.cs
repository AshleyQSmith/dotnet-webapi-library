using dotnet_webapi_library.Repositories;
using System;
using System.Collections.Generic;
using dotnet_webapi_library.Models;

namespace dotnet_webapi_library.Services
{
  public class LibraryService
  {
    private readonly LibraryRepository _repo;

    public LibraryService(LibraryRepository repo)
    {
      _repo = repo;
    }

    public IEnumerable<Library> GetAll()
    {
      return _repo.GetAll();
    }

    internal object Create(Library newLibrary)
    {
      return _repo.Create(newLibrary);
    }

    internal Library GetById(int id)
    {
      Library foundLibrary = _repo.GetById(id);
      if (foundLibrary == null)
      {
        throw new Exception("invalid id");
      }
      return foundLibrary;
    }

    internal Library Delete(int id)
    {
      Library foundLibrary = GetById(id);
      if (_repo.Delete(id))
      {
        return foundLibrary;
      }
      throw new Exception("something failed");
    }

  }
}