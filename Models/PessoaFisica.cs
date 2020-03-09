using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cadastro.Models
{
    public class PessoaFisica

    {
         
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int PessoaFisicaId { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }  
        public int TelefoneId { get; set; }
        public virtual Telefone Telefone { get; set; } 

    }
}
