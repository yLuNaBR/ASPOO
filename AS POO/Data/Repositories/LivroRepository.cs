using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_POO.Domain.Interfaces;
using AS_POO.Domain.Models;

namespace AS_POO.Data.Repositories
{
    public class LivroRepository : ILivroRepository
{
    private readonly BibliotecaContext _context;

    public LivroRepository(BibliotecaContext context)
    {
        _context = context;
    }

    public Livro GetById(int id)
    {
        return _context.Livros.Find(id);
    }

    public void Add(Livro livro)
    {
        _context.Livros.Add(livro);
        _context.SaveChanges();
    }

    public void Update(Livro livro)
    {
        _context.Livros.Update(livro);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var livro = _context.Livros.Find(id);
        if (livro != null)
        {
            _context.Livros.Remove(livro);
            _context.SaveChanges();
        }
    }

}
}