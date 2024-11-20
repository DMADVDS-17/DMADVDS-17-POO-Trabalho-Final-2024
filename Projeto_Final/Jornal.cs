using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final
{
    internal class Jornal : Geral_Leitura
    {
        public string MARCA;
        public Jornal(string _marca, string _titulo, DateTime _data): base(_titulo, _data) 
        {
            MARCA = _marca;
        }
    }
}
