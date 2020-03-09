using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cadastro.Models
{
    public class Endereco
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }

        public string CEP { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; } 
        public virtual PessoaFisica PessoaFisica { get; set; }
    }
}
