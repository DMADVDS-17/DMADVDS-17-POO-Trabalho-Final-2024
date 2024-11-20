using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Livros
{
    internal class LivroFiccao : Livro
    {
        public string ESCRITOR;

        public LivroFiccao(string _escritor, string _codigo, int _ncopias, string _titulo, DateTime _data) :
           base(_codigo, _ncopias, _titulo, _data)
        {
            ESCRITOR = _escritor;
        }
    }
}
