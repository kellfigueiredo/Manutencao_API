using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro.Models
{
    public class Telefone
    {
        
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TelefoneId { get; set; }
        public string Tipo { get; set; }
        public string Numero { get; set; } 
        public virtual PessoaFisica PessoaFisica { get; set; }
    }
}
