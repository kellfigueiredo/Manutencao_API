using Cadastro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Data
{
    public class DbInitializer
    {
        public static void Initialize(PessoaFisica_Context context)
        {
             context.Database.EnsureCreated();
            if (context.PessoaFisica.Any())
            {
                return;   // DB has been seeded
            }
            //if (context.PessoaFisica.FirstOrDefault() !=null) { return; }
            var pessoaf = new PessoaFisica[] {
                            new PessoaFisica{ CPF="09571286737"
                                ,Nome ="Teste Numero 01"
                                ,RG ="117095398"
                                ,Telefone =new Telefone(){  Tipo="R", Numero="01234567"  }
                                ,Endereco = new Endereco(){  Logradouro="Teste rua 01", Numero="12", Bairro="Bairro 01",  Municipio="Municipio01", CEP="", UF=""  }
                            },
                               new PessoaFisica{ CPF="45356756756"
                                ,Nome ="Teste Numero 02"
                                ,RG ="117095398"
                                ,Telefone = new Telefone { Tipo="R", Numero="01234567" }
                                ,Endereco = new Endereco(){  Logradouro="Teste rua 02", Numero="12", Bairro="Bairro 01",  Municipio="Municipio01", CEP="", UF=""  }
                            },
                             new PessoaFisica{ CPF="21312312312312"
                                ,Nome ="Teste Numero 03"
                                ,RG ="117095398"
                                ,Telefone =new Telefone { Tipo="R", Numero="01234567" }
                                ,Endereco = new Endereco(){  Logradouro="Teste rua 03", Numero="12", Bairro="Bairro 01",  Municipio="Municipio01", CEP="", UF=""  }
                            }

            };
            foreach (PessoaFisica p in pessoaf)
            {

                context.PessoaFisica.Add(p);
                context.SaveChangesAsync();

            }
            context.SaveChangesAsync();
        }
    }
}
