using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using real_backend.Data;
using real_backend.Models;
using real_backend.Models.DTO;
namespace real_backend.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class BooksController : ControllerBase
  {
    private readonly AppDbContext database;
    public BooksController(AppDbContext db)
    {
      this.database = db;
    }
    [HttpGet("{id?}")]
    public IActionResult Get(int id = 0)
    {
      try
      {
        var books = database.Books.ToList();
        if (id == 0)
        {
          return Ok(books);
        }
        else
        {
          var book = books.First(item => item.Id == id);
          return Ok(book);
        }
      }
      catch (Exception e)
      {
        return BadRequest(new
        {
          Msg = "An error occurred while getting the information.",
          Error = e.Message
        });
      }
    }
    [HttpPost]
    public IActionResult Post([FromBody] BookDTO bookDTO)
    {
      try
      {
        var book = new Book()
        {
          Title = bookDTO.Title,
          Author = bookDTO.Author,
          Description = bookDTO.Description,
          Cover = bookDTO.Cover,
          Status = bookDTO.Status,
          Liked = bookDTO.Liked
        };
        database.Books.Add(book);
        database.SaveChanges();
        Response.StatusCode = 201;
        return new ObjectResult(new
        {
          Message = "Book registration to Database complete!",
          book = book,
        });
      }
      catch (Exception e)
      {
        return BadRequest(new
        {
          Msg = "An error occurred while processing the information.",
          Error = e.Message
        });
      }
    }
    [HttpPut("{id}")]
    public IActionResult Put([FromBody] BookDTO bookDTO, int id)
    {
      try
      {
        var book = database.Books.Find(id);
        book.Title = bookDTO.Title;
        book.Author = bookDTO.Author;
        book.Description = bookDTO.Description;
        book.Cover = bookDTO.Cover;
        book.Status = bookDTO.Status;
        book.Liked = bookDTO.Liked;
        database.SaveChanges();
        return Ok(bookDTO);
      }
      catch (Exception e)
      {
        return BadRequest(new
        {
          Msg = "An error occurred while processing the information.",
          Error = e.Message
        });
      }
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      try
      {
        var book = database.Books.Find(id);
        database.Books.Remove(book);
        database.SaveChanges();
        return Ok(new { Msg = "Book succefully removed from DB.", book = book });
      }
      catch (Exception e)
      {
        return BadRequest(new
        {
          Msg = "An error occurred while processing the information.",
          Error = e.Message
        });
      }
    }
  }
}