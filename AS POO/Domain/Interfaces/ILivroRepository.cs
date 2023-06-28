using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_POO.Domain.Models;

namespace AS_POO.Domain.Interfaces
{
    public interface ILivroRepository
    {
        Livro GetById(int id);
        void Add(Livro livro);
        void Update(Livro livro);
        void Delete(int id);
    }
}