using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_POO.Domain.Models;

namespace AS_POO.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario GetById(int id);
        void Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(int id);
    }
}