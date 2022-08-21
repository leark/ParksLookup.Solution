using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParksLookup.Models;

namespace ParksLookup.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ParksController : ControllerBase
  {
    private readonly ILogger<ParksController> _logger;
    private readonly ParksLookupContext _db;

    public ParksController(ILogger<ParksController> logger, ParksLookupContext db)
    {
      _logger = logger;
      _db = db;
    }

    [HttpGet]
    public IEnumerable<Park> Get()
    {
      return _db.Parks.ToList();
    }

  }
}