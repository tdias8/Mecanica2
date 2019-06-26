using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanica2
{
   public class Atendimento
    {
        public string data { get; set; }
        public string hora { get; set; }
        private List<Profissional> listaDeProfissionais = new List<Profissional>();
        private List<Cliente> listaDeCliente = new List<Cliente>();
        public string status { get; set; }
        public string descricao { get; set; }

    }
}
