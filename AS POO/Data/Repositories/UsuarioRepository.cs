using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_POO.Domain.Interfaces;
using AS_POO.Domain.Models;

namespace AS_POO.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
{
    private readonly BibliotecaContext _context;

    public UsuarioRepository(BibliotecaContext context)
    {
        _context = context;
    }

    public Usuario GetById(int id)
    {
        return _context.Usuarios.Find(id);
    }

    public void Add(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
    }

    public void Update(Usuario usuario)
    {
        _context.Usuarios.Update(usuario);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var usuario = _context.Usuarios.Find(id);
        if (usuario != null)
        {
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }
    }

    
}
}