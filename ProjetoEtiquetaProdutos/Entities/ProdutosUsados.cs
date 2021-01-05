using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEtiquetaProdutos.Entities
{
    class ProdutosUsados: Produto
    {
        public DateTime DataDeFabricaçao { get; set; }

        public ProdutosUsados() { }

        public ProdutosUsados(string nome, double preço, DateTime dataDeFabricaçao): base(nome, preço)
        {
            DataDeFabricaçao = dataDeFabricaçao;
        }

        public override string Etiqueta()
        {
            return Nome
            + "( Usado ) R$ "
            + Preço.ToString("F2")
            + "( Data de fabricação: "
            + DataDeFabricaçao.ToString("dd/MM/yyyy")
            + " )";
        }



    }
}
