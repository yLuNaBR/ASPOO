using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_POO.Domain.Interfaces;
using AS_POO.Domain.Models;

namespace AS_POO.Data.Repositories
{
    public class AutorRepository : IAutorRepository
{
    private readonly BibliotecaContext _context;

    public AutorRepository(BibliotecaContext context)
    {
        _context = context;
    }

    public Autor GetById(int id)
    {
        return _context.Autores.Find(id);
    }

    public void Add(Autor autor)
    {
        _context.Autores.Add(autor);
        _context.SaveChanges();
    }

    public void Update(Autor autor)
    {
        _context.Autores.Update(autor);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var autor = _context.Autores.Find(id);
        if (autor != null)
        {
            _context.Autores.Remove(autor);
            _context.SaveChanges();
        }
    }

    // Outros métodos relevantes para o repositório de Autor
}
}