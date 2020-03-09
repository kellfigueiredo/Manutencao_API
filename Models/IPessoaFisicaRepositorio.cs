using System;
using System.Collections.Generic; 

namespace Cadastro.Models
{
    public interface IPessoaFisicaRepositorio
    {
        void Add(PessoaFisica item);
        IEnumerable<PessoaFisica> GetAll();
        PessoaFisica Find(long key);
        void Remove(long key);
        void Update(long key);   
    }
}
