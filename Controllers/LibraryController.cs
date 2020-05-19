using dotnet_webapi_library.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

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
  }

}