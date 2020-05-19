using dotnet_webapi_library.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using dotnet_webapi_library.Models;


namespace dotnet_webapi_library.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class LibraryController : ControllerBase
  {
    private readonly LibraryService _ls;
    public LibraryController(LibraryService ls)
    {
      _ls = ls;
    }


    [HttpGet]
    public ActionResult<IEnumerable<Library>> GetAll()
    {
      try
      {
        return Ok(_ls.GetAll());
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpGet("{id")]
    public ActionResult<Library> GetById(int id)
    {
      try
      {
        return Ok(_ls.GetById(id));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Library> Create([FromBody] Library newLibrary)
    {
      try
      {
        return Ok(_ls.Create(newLibrary));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Library> Delete(int id)
    {
      try
      {
        return Ok(_ls.Delete(id));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}