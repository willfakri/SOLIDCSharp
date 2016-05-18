using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public interface IDAOProduto
    {
        void Incluir(Produto produto);

        void Excluir(int codigoProduto);

        Produto Atualizar(Produto produto);

        List<Produto> Listar();
    }

    public class DAOProduto : IDAOProduto
    {
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

    public class Produto
    {
        public Produto(IDAOProduto daoProduto)
        {
            this.DAOProduto = daoProduto;
        }

        public int Codigo { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public IDAOProduto DAOProduto;
    }
}