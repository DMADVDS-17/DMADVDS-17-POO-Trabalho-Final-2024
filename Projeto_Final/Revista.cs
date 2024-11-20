using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    internal class Revista : Geral_Leitura
    {
        public string N_EDICAO;
        public Revista(string n_edi,string _titulo, DateTime _data): base(_titulo, _data) 
        {
            N_EDICAO = n_edi;
        }
    }
}
