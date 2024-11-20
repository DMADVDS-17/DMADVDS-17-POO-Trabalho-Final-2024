using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final.Livros
{
    internal class LivroEducativo : Livro
    {
        public int ANOESCOLARIDADE;

        public LivroEducativo(int _anoesc, string _codigo, int _ncopias, string _titulo, DateTime _data): 
            base(_codigo, _ncopias, _titulo, _data)
        {
            ANOESCOLARIDADE = _anoesc;
        }
    }
}
