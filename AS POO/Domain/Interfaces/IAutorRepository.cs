using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_POO.Domain.Models;

namespace AS_POO.Domain.Interfaces
{
    public interface IAutorRepository
    {
        Autor GetById(int id);
        void Add(Autor autor);
        void Update(Autor autor);
        void Delete(int id);
    }
}