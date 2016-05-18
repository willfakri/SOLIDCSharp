using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public void Incluir(Produto produto)
        {
            //implementacao
        }

        public void Excluir(int codigoProduto)
        {
            //implementacao            
        }

        public Produto Atualizar(Produto produto)
        {
            //implementacao
            return null;
        }

        public List<Produto> Listar()
        {
            //implementacao
            return null;
        }
    }
}