using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanica2
{
   public class Cliente : Pessoa
    {
        public string endereco { get; set; }
        public string dtNascimento { get; set; }
        public string sexo { get; set; }
        public string estadoCivil { get; set; }
        public string ativo { get; set; }

    }
}
