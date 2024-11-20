using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Livros
{
    internal class Livro : Geral_Leitura
    {
        public string CODIGO;
        public int NCOPIAS;

        public Livro(string _codigo, int _ncopias, string _titulo, DateTime _data): base( _titulo, _data)
        {
            CODIGO = _codigo;
            NCOPIAS = _ncopias;
        }
    }
}
