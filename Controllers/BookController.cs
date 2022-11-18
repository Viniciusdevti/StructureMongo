using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.Serialization.Attributes;
using StructureMongo.Domain.Entities;
using StructureMongo.Service.Interface;

namespace StructureMongo.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{

    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet("getall")]
    public async Task<IActionResult> Get(string id)
    {
        CancellationToken cancellationToken = HttpContext.RequestAborted;
        var result = await _bookService.Get(id,cancellationToken);

        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        CancellationToken cancellationToken = HttpContext.RequestAborted;
        var result = await _bookService.GetAll(cancellationToken);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Book book)
    {
        CancellationToken cancellationToken = HttpContext.RequestAborted;
        await _bookService.Post(book,cancellationToken);

        return Ok();
    }
}
