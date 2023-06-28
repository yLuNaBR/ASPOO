using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_POO.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AS_POO.Domain.Models;

namespace AS_POO.Controllers
{
[ApiController]
[Route("api/[controller]")]
public class AutorController : ControllerBase
{
    private readonly BibliotecaContext _context;

    public AutorController(BibliotecaContext context)
    {
        _context = context;
    }

    // GET: api/Autor
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Autor>>> GetAutores()
    {
        var autores = await _context.Autores.ToListAsync();
        return autores;
    }

    // GET: api/Autor/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Autor>> GetAutor(int id)
    {
        var autor = await _context.Autores.FindAsync(id);

        if (autor == null)
        {
            return NotFound();
        }

        return autor;
    }

    // POST: api/Autor
    [HttpPost]
    public async Task<ActionResult<Autor>> CreateAutor(Autor autor)
    {
        _context.Autores.Add(autor);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetAutor), new { id = autor.Id }, autor);
    }

    // PUT: api/Autor/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAutor(int id, Autor autor)
    {
        if (id != autor.Id)
        {
            return BadRequest();
        }

        _context.Entry(autor).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // DELETE: api/Autor/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAutor(int id)
    {
        var autor = await _context.Autores.FindAsync(id);

        if (autor == null)
        {
            return NotFound();
        }

        _context.Autores.Remove(autor);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
}