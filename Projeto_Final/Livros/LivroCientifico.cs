using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Livros
{
    internal class LivroCientifico : Livro
    {
        public string CATEGORIA;

        public LivroCientifico(string _categoria, string _codigo, int _ncopias, string _titulo, DateTime _data) :
           base(_codigo, _ncopias, _titulo, _data)
        {
            CATEGORIA = _categoria;
        }
    }
}
